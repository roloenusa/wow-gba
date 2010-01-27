using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.Xml;
using System.IO;

using System.Xml.Serialization;

namespace XMLTest
{
    public partial class Form1 : Form
    {
        List<pageGuildInfoGuildBankBanklogsBanklog> bl1 = new List<pageGuildInfoGuildBankBanklogsBanklog>();
        List<pageGuildInfoGuildBankBanklogsBanklog> bl2 = new List<pageGuildInfoGuildBankBanklogsBanklog>();
        
        //Configurations and settings
        configurations configs;
        int typeRow = 0;
        int subTypeRow = 0;
        int itemRow = 0;

        bool indexNewItems = false;




        page file1 = new page();
        page file2 = new page();

        public Form1()
        {
            InitializeComponent();
            configs = new configurations();
            PlayerTransactions.Configurations = configs = configurations.getConfigurations();

            dataGridView2.DataSource = configs.Weights[0].TypeList;
            dataGridView3.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList;
            dataGridView4.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList[subTypeRow].ItemList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult OPEN = openFileDialog1.ShowDialog();            
            if (OPEN == DialogResult.OK)            
            {  

                //Get the transactions from the Original File
                string path = openFileDialog1.FileName; // The Path to the .Xml file //
                file1 = deserializePage(path);

                bl1.Clear();
                foreach (pageGuildInfoGuildBankBanklogsBanklog r in file1.guildInfo[0].guildBank[0].banklogs[0].banklog)
                {
                    bl1.Add(r);
                }

                label1.Text = bl1.Count.ToString() ; // Load Type //                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.DialogResult OPEN = openFileDialog1.ShowDialog();
            if (OPEN == DialogResult.OK)
            {

                //Get the transactions from the web
                string path = openFileDialog1.FileName; // The Path to the .Xml file //                
                file2 = deserializePage(path);

                bl2.Clear();
                foreach (pageGuildInfoGuildBankBanklogsBanklog r in file2.guildInfo[0].guildBank[0].banklogs[0].banklog)
                {
                    bl2.Add(r);
                }

                label2.Text = bl2.Count.ToString();                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = consolidateTransactions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult OPEN = saveFileDialog1.ShowDialog();
            if (OPEN == DialogResult.OK)          
            {
                //Get the transactions from the web
                string path = saveFileDialog1.FileName; // The Path to the .Xml file //                
                serializePage(path, file1);
            }

        }

        private string consolidateTransactions()
        {
            //If there is no data.
            if (bl2.Count == 0 && bl1.Count == 0)
                return "No Data";
            
            //Find index and rebuil the list with the difference.
            List<pageGuildInfoGuildBankBanklogsBanklog> bl3 = new List<pageGuildInfoGuildBankBanklogsBanklog>();
            
            //sort Lists
            bl1.Sort(compareAsc);
            bl2.Sort(compareAsc);

            //Add list 1
            bl3 = bl1;

            //Find the matching index of list 2
            int i = 0;
            for (i = bl2.Count -1; i >=0 ; i--)
            {
                if(bl3[bl3.Count - 1].ts.Equals(bl2[i].ts))
                    break;
            }
            //add the list at the point where it starts.
            for( i += 1; i < bl2.Count; i++)
                bl3.Add(bl2[i]);


            //int indexToRemove = findIndexOfEqual(bl1[0].ts, bl2);
            //bl2.RemoveRange(indexToRemove, bl2.Count - indexToRemove);
            //bl1.AddRange(bl2);
            bl3.Sort(compareDesc);


            //Create an array and get the list in the new array
            pageGuildInfoGuildBankBanklogsBanklog[] x = new pageGuildInfoGuildBankBanklogsBanklog[bl3.Count];
            for (i = 0; i < bl3.Count; i++)
                x[i] = bl3[i];
            //Copy the array to the original instance
            file1.guildInfo[0].guildBank[0].banklogs[0].banklog = x;

            List<PlayerTransactions> pt = new List<PlayerTransactions>();
            foreach (pageGuildInfoGuildBankBanklogsBanklog temp in x)
            {
                AddType(temp);


                //Get the transaction data and add to player data
                 
                int j = 0;
                for (j = 0; j < pt.Count; j++)
                    if ((pt[j].Player == null && temp.player == null) || pt[j].Player == temp.player)
                        break;
                
                if(j == pt.Count)
                    pt.Add(new PlayerTransactions(temp.player));

                pt[j].AddTransaction(temp);

            }

            dataGridView1.DataSource = pt;

            DataGridViewRefresh();

            return bl3.Count.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static int compareAsc(pageGuildInfoGuildBankBanklogsBanklog bl1, pageGuildInfoGuildBankBanklogsBanklog bl2)
        {
            if (bl1.ts < bl2.ts) return -1;
            else if (bl1.ts == bl2.ts) return 0;
            else if (bl1.ts > bl2.ts) return 1;
            return 0;
        }

        private static int compareDesc(pageGuildInfoGuildBankBanklogsBanklog bl1, pageGuildInfoGuildBankBanklogsBanklog bl2)
        {
            if (bl1.ts < bl2.ts) return -1;
            else if (bl1.ts == bl2.ts) return 0;
            else if (bl1.ts > bl2.ts) return 1;
            return 0;
        }

        private static page deserializePage(string filePath)
        {
            System.IO.StreamReader str = new System.IO.StreamReader(filePath);
            System.Xml.Serialization.XmlSerializer xSerializer = new System.Xml.Serialization.XmlSerializer(typeof(page));
            page res = (page)xSerializer.Deserialize(str);
            str.Close();

            return res;
        }

        private static void serializePage(string filePath, page res)
        {
            //TEST FOR WRITER
            System.IO.StreamWriter strOut = new System.IO.StreamWriter("Test.xml");
            System.Xml.Serialization.XmlSerializer xSerializerOut = new System.Xml.Serialization.XmlSerializer(typeof(page));
            xSerializerOut.Serialize(strOut, res);

            strOut.Close();
        }

        private static int findIndexOfEqual(string str, List<pageGuildInfoGuildBankBanklogsBanklog> bl2)
        {
            int i = 0;
            for (i = 0; i < bl2.Count; i++)
                if (str.Equals(bl2[i].ts))
                    break;

            return i;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.typeRow = e.RowIndex < 0 ? 0 : e.RowIndex;
            this.subTypeRow = 0;
            dataGridView3.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList;
            dataGridView4.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList[subTypeRow].ItemList;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.subTypeRow = e.RowIndex < 0 ? 0 : e.RowIndex;
            dataGridView4.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList[subTypeRow].ItemList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmation Box", "title?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.WriteLine(DialogResult.Yes.ToString());
                configurations.saveConfigurations(configs);
            }
        }

        private void DataGridViewRefresh()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = configs.Weights[0].TypeList;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList;
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = configs.Weights[0].TypeList[typeRow].subTypeList[subTypeRow].ItemList;
        }


        private void AddType(pageGuildInfoGuildBankBanklogsBanklog temp)
        {
            //Get the item and add it to the configurations of needed. 
            //We only index new categories if they're not in. 
            if (temp.type == (int)TransactionType.DepositItem ||
                temp.type == (int)TransactionType.WithdrawItem)
            {
                int trow = 0;
                for (trow = 0; trow < configs.Weights[0].TypeList.Count; trow++)
                {
                    int strow = 0;
                    //If the type is in the list, then look for the subtype.
                    if (temp.item[0].type.Equals(configs.Weights[0].TypeList[trow].name))
                    {
                        for (strow = 0; strow < configs.Weights[0].TypeList[trow].subTypeList.Count; strow++)
                        {
                            if (temp.item[0].subtype.Equals(configs.Weights[0].TypeList[trow].subTypeList[strow].name))
                                break;
                        }


                        //iF the subtype is on the list, then it was found and no need to keep going.
                        if (strow == configs.Weights[0].TypeList[trow].subTypeList.Count)
                        {
                            configs.Weights[0].type[trow].AddSubType(temp.item[0].subtype);
                        }


                        //We check to see if we're going to add and index all items. 
                        //This is time consuming so we should not do it by default.
                        if (AddItemsCheckbox.CheckState == CheckState.Unchecked)
                            break;

                        //Now we look for the item. If it's not on the subtype, we'll add it.
                        int irow = 0;
                        for (irow = 0; irow < configs.Weights[0].type[trow].subTypeList[strow].ItemList.Count; irow++)
                        {
                            if (temp.item[0].id == configs.Weights[0].type[trow].subTypeList[strow].ItemList[irow].id)
                                break;
                        }

                        if (irow == configs.Weights[0].type[trow].subTypeList[strow].ItemList.Count)
                        {
                            configs.Weights[0].type[trow].subTypeList[strow].AddItem(new configurationsWeightsTypeSubtypeItem().NewItem(temp.item[0].id, temp.item[0].name, 10));
                        }

                        //Finally we break the loop because the item was either ignored or added.
                        break;
                    }

                }

                //if the type was not found, then we add the type and subtype. 
                if (trow == configs.Weights[0].TypeList.Count)
                {
                    configs.Weights[0].AddType(temp.item[0].type);
                    if (!temp.item[0].subtype.Equals(""))
                    {
                        configs.Weights[0].TypeList[trow].AddSubType(temp.item[0].subtype);
                    }
                }
                /**/
            }
        }
    }
}