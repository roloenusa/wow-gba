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

namespace GuildBank
{
    public partial class Form1 : Form
    {
        configurations configs;
        Cache cache;

        List<page> guildLogs = new List<page>();

        Banklogs comList = new Banklogs();
        List<Banklog[]> logList = new List<Banklog[]>();
        List<BanklogItem> itemList = new List<BanklogItem>();
        DataTable dt = wowhead.CreateTable("CachedItems");
        List<PlayerTransactions> pt = new List<PlayerTransactions>();




        //Configurations and settings
        page guildLog = new page();

        public Form1()
        {
            InitializeComponent();
            
            configs = new configurations();
            PlayerTransactions.Configurations = configs = (configurations)Util.DeserializeXML("config.xml", typeof(configurations));

            configs.configurationsInit();
            configs.configurationInterface(this.tabConfigs);

            cache = new Cache();

            dgvCachedItems.DataSource = dt;
        }

        private void SaveLogEvent_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult OPEN = saveFileDialog1.ShowDialog();
            if (OPEN == DialogResult.OK)          
            {
                //Get the transactions from the web
                string path = saveFileDialog1.FileName; // The Path to the .Xml file //                
                Util.SerializeXML(path, guildLog, typeof(page));
            }

        }

        private string consolidateTransactions()
        {
            dgvPlayerSumary.DataSource = pt;
            dgvParsedItems.DataSource = itemList;

            DataGridViewRefresh();


            //Linq test
            var t = from o in cache.Items
                    where o.Value.Items.name == "Lichbloom"//"Icethorn"
                    select new { o.Value.Items.id, o.Value.Items.name };
            dataGridView1.DataSource = t.ToArray();

            foreach (var rslt in t)
                Console.WriteLine(rslt.ToString());
            //End Linq test

            return "Hello"; // bl3.Count.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cache.Populate();
            
            foreach(wowhead t in cache.Items.Values)
                dt.Rows.Add(t.ToObjectArray());

        }

        private static int compareAsc(Banklog bl1, Banklog bl2)
        {
            if (bl1.ts < bl2.ts) return -1;
            else if (bl1.ts == bl2.ts) return 0;
            else if (bl1.ts > bl2.ts) return 1;
            return 0;
        }

        private static int compareDesc(Banklog bl1, Banklog bl2)
        {
            if (bl1.ts < bl2.ts) return -1;
            else if (bl1.ts == bl2.ts) return 0;
            else if (bl1.ts > bl2.ts) return 1;
            return 0;
        }

        private void buttonSaveConfigs_Click(object sender, EventArgs e)
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
            for(int i = 0; i < cache.Items.Count; i++)
            {
                //dt.Rows.Add(cache[i].ToObjectArray());
            }
            dgvCachedItems.DataSource = dt;
        }


        private void AddType(Banklog temp)
        {

            //Get the item and add it to the configurations of needed. 
            //We only index new categories if they're not in. 
            if (temp.type == (int)TransactionType.DepositItem ||
                temp.type == (int)TransactionType.WithdrawItem)
            {
                //Determine if the item needs to be cached.
                if (!File.Exists(configs.CacheItemPath + temp.item[0].id.ToString() + ".xml"))
                {
                    //If we're asking to cache all, then cache and add to the list of cached items.
                    if (checkBoxCacheItems.CheckState == CheckState.Checked)
                    {
                        wowhead wh = (wowhead)cache.ItemFromWeb(temp.item[0].id, typeof(wowhead));
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
                Util.SerializeXML(configs.CacheItemPath+wh.Items.id+".xml", wh, wh.GetType());
                dt.Rows.Add(wh.ToObjectArray());
                cache.Add(wh);
            }
        }

        private void LoadFileEvent_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult OPEN = openFileDialog1.ShowDialog();
            if (OPEN == DialogResult.OK)
            {

                //Get the transactions from the Original File
                string path = openFileDialog1.FileName; // The Path to the .Xml file //
                guildLog = (page)Util.DeserializeXML(path, typeof(page));
                guildLogs.Add((page)Util.DeserializeXML(path, typeof(page)));


                Banklog[] bl = guildLogs[guildLogs.Count - 1].guildInfo[0].guildBank[0].banklogs[0].banklog;
                logList.Add(bl);

                //Generate From Date
                TimeSpan ts = TimeSpan.FromMilliseconds(bl[0].ts + Util.LINUXTIMEOFFSET);
                DateTime dt = new DateTime(ts.Ticks);
                string strFromDate = "";
                strFromDate += dt.ToString();

                //Generate To Date
                ts = TimeSpan.FromMilliseconds(bl[bl.Length - 1].ts + Util.LINUXTIMEOFFSET);
                dt = new DateTime(ts.Ticks);
                string strToDate = "";
                strToDate += dt.ToString();

                this.dgvLogList.Rows.Add(new object[] { true, strFromDate, strToDate, bl.Length });
            }
        }

        private void CompileSelectedEvent_Click(object sender, EventArgs e)
        {
            comList = new Banklogs();

            for (int i = 0; i < dgvLogList.Rows.Count; i++ )
            {
                if (dgvLogList.Rows[i].Cells["ColumnCheckBox"].Value.Equals(true))
                {
                    comList.MergeBanklogs(logList[i]);
                }
            }

            CompileLog(comList);

            dgvPlayerSumary.DataSource = null;
            dgvPlayerSumary.DataSource = pt;
            dgvParsedItems.DataSource = itemList;
        }

        private void CompileLog(Banklogs log)
        {
            pt.Clear();

            foreach (Banklog temp in log.banklog)
            {
                AddType(temp);


                //Get the transaction data and add to player data

                int j = 0;
                for (j = 0; j < pt.Count; j++)
                    if ((pt[j].Player == null && temp.player == null) || pt[j].Player == temp.player)
                        break;

                if (j == pt.Count)
                    pt.Add(new PlayerTransactions(temp.player));

                pt[j].AddTransaction(temp);

            } 
        }

        private void checkBoxCacheItems_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCacheItems.Checked== true &&
                MessageBox.Show("This option will attempt to cache from wowhead.com every item in the log. It might decrease performance and might result in the IP being banned if there are too many calls. \n\nAre you sure you want to do this?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                checkBoxCacheItems.Checked = false;
            }
        }

    }//End Form1 Class
}//End Namespace GuildBank