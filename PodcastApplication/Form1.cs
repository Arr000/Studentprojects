using PodcastBL;
using PodcastModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPodcastDal dataacess = new PodcastDataAccess.PodcastDal();
                PodcastService service = new PodcastService(dataacess);
                // var s = "https://www.svt.se/rss.xml";
                var podcast = service.Load(textBox1.Text);

                ListViewItem item1 = new ListViewItem("item1", 0);
                item1.Checked = true;
                var podcastinfo = new List<string>();
                podcastinfo.Add(podcast.Name);
                podcastinfo.Add(podcast.Episodes.ToString());

                foreach (var item in podcastinfo)
                {
                    listView1.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    } 

}