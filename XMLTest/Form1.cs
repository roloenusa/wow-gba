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
using System.Linq;

namespace XMLTest
{
    public partial class Form1 : Form
    {
        List<pageGuildInfoGuildBankBanklogsBanklog> bl1 = new List<pageGuildInfoGuildBankBanklogsBanklog>();
        List<pageGuildInfoGuildBankBanklogsBanklog> bl2 = new List<pageGuildInfoGuildBankBanklogsBanklog>();

        List<pageGuildInfoGuildBankBanklogsBanklogItem> itemList = new List<pageGuildInfoGuildBankBanklogsBanklogItem>();
        Cache<int, wowhead> cache = new Cache<int, wowhead>();
        DataTable dt = wowhead.CreateTable("CachedItems");

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
            PlayerTransactions.Configurations = configs = (configurations)Util.DeserializeXML("config.xml", typeof(configurations));

            dgvCachedItems.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult OPEN = openFileDialog1.ShowDialog();            
            if (OPEN == DialogResult.OK)            
            {  

                //Get the transactions from the Original File
                string path = openFileDialog1.FileName; // The Path to the .Xml file //
                file1 = (page)Util.DeserializeXML(path, typeof(page));

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
                file2 = (page)Util.DeserializeXML(path, typeof(page));

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
                Util.SerializeXML(path, file1, typeof(page));
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

            dgvPlayerSumary.DataSource = pt;
            dgvParsedItems.DataSource = itemList;

            DataGridViewRefresh();


            //Linq test
            var t = from o in pt
                    //where o.id == 17720
                    select o.Player;

            foreach (var rslt in t)
                Console.WriteLine(rslt.ToString());
            //End Linq test

            return bl3.Count.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<object> objList = Util.GetCache("cache", typeof(wowhead), ".xml");
            foreach (object obj in objList)
            {
                wowhead t = obj as wowhead;
                cache.Add(t.Items.id, t);
                dt.Rows.Add(t.ToObjectArray());
            }

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

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmation Box", "title?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.WriteLine(DialogResult.Yes.ToString());
                //configurations.saveConfigurations(configs);
                Util.SerializeXML("config.xml", configs, typeof(configurations));
            }
        }

        private void DataGridViewRefresh()
        {
            //Set the link name
            foreach (DataGridViewRow row in dgvParsedItems.Rows)
            {
                row.Cells["Link"].Value = row.Cells[5].Value;
                row.Cells["Link"].ToolTipText = row.Cells[5].Value.ToString();
            }

            //Refresh datatable.
            dt.Rows.Clear();
            for(int i = 0; i < cache.Count; i++)
            {
                dt.Rows.Add(cache[i].ToObjectArray());
            }
            dgvCachedItems.DataSource = dt;
        }


        private void AddType(pageGuildInfoGuildBankBanklogsBanklog temp)
        {

            //Get the item and add it to the configurations of needed. 
            //We only index new categories if they're not in. 
            if (temp.type == (int)TransactionType.DepositItem ||
                temp.type == (int)TransactionType.WithdrawItem)
            {
                if (!Directory.Exists("cache"))
                    Directory.CreateDirectory("cache");


                //Determine if the item needs to be cached.
                if (!File.Exists("cache\\" + temp.item[0].id.ToString() + ".xml"))
                {
                    //If we're asking to cache all, then cache and add to the list of cached items.
                    if (checkBoxCacheItems.CheckState == CheckState.Checked)
                    {
                        wowhead wh = (wowhead)Util.CacheItemFromWeb(temp.item[0].id); 
                        cache.Add(wh.Items.id, wh);
                    }
                    //else add to the list of items that could be cached.
                    else
                    {
                        itemList.Add(temp.item[0]);
                    }
                }
            }
        
        }



        wowhead wh;
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //We try to see if the user has parsed an item first.
            int id;
            if (!int.TryParse(textBoxSearch.Text, out id))
                return;

            wh = Util.GetItemFromWeb(id);
            //We have to make sure that the item is not null as this is a possible option.
            if (wh == null)
                return;

            Console.WriteLine(wh.Items.name);

            //WebBrowser
            string strHTML = "<html> \n<head>\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/basic.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/global.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/locale_enus.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/Book.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/Mapper.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/Mapper.css?644\" /><!--[if IE]>\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/global_ie.css?644\" /><![endif]--><!--[if lte IE 6]>\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/basic_ie6.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/global_ie6.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/Mapper_ie6.css?644\" /><![endif]--><!--[if lte IE 7]>\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/basic_ie67.css?644\" />\n";
            strHTML += "<link rel=\"stylesheet\" type=\"text/css\" href=\"http://static.wowhead.com/css/global_ie67.css?644\" /><![endif]-->\n";

            //strHTML += "<script src=\"http://static.wowhead.com/widgets/power.js\"></script>\n";
            strHTML += "<script>onload = function() {var links = document.getElementsByTagName('a'); for(var i = 0; i < links.length; ++i) { links[i].setAttribute('target', '_blank');}}</script>";
            strHTML += "</head>\n";

            strHTML += "<div style=\"float: left; padding-top: 1px;\">\n";
            strHTML += wh.Items.htmlTooltip + "\n";
            strHTML += "</div>\n";
            strHTML += "</html>";

            //webBrowser1.AllowNavigation = true;
            webBrowser1.DocumentText = strHTML;
            //webBrowser1.AllowNavigation = false;
           
        }

        private void buttonAddToCache_Click(object sender, EventArgs e)
        {
            if (wh == null)
                return;

            if (MessageBox.Show("Are you sure you want to add " + wh.Items.name + " to the cache?", "Adding item to cache", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Util.SerializeXML("cache\\"+wh.Items.id+".xml", wh, wh.GetType());
                dt.Rows.Add(wh.ToObjectArray());
                cache.Add(wh.Items.id, wh);
            }
        }





    }
}