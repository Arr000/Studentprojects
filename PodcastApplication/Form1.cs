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

        PodcastService service = null;
      
        
        public Form1()
        {
            InitializeComponent();

            IPodcastDal dataacess = new PodcastDataAccess.PodcastDal();
            service = new PodcastService(dataacess);
            service.Initialize();
            var savedPodcasts = service.GetAllPodcast();
            foreach (var p in savedPodcasts)
            {
                string[] podcastInfo = { p.ID.ToString(), p.Name, p.Episodes.ToString(), p.RefreshInterval.ToString(), p.Category };
                ListViewItem PodcastListDisplay = new ListViewItem(podcastInfo);
                listPodcast.Items.Add(PodcastListDisplay);
            }

            listPodcast.FullRowSelect = true;
            fillMyCategoryList();
            fillMyCombobox();
        }


        private void fillMyCombobox()
        {
            cbxFrekvens.Items.Add("500");
            cbxFrekvens.Items.Add("1000");
            cbxFrekvens.Items.Add("3000");
        }
        
        private void fillMyCategoryList()
        {
            listCategory.Items.Add("Drama");
            listCategory.Items.Add("Action");
            listCategory.Items.Add("Komedi");
            listCategory.Items.Add("Thriller");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        try
            {
                // var s = "https://www.svt.se/rss.xml";
                
                var podcast = service.Load(txtPodcastUrl.Text);
              
                string[] podcastInfo = {podcast.ID.ToString(),podcast.Name, podcast.Episodes.ToString(), "" , ""};

                ListViewItem PodcastListDisplay = new ListViewItem(podcastInfo);

                listPodcast.Items.Add(PodcastListDisplay);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

       private void btnAddCategory_Click(object sender, EventArgs e)
        {
            listCategory.Items.Add(txtInsertCategory.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                listPodcast.SelectedItems[0].SubItems[4].Text = txtChooseCategory.Text;
                listPodcast.SelectedItems[0].SubItems[3].Text = cbxFrekvens.Text;
                listPodcast.SelectedItems[0].SubItems[1].Text = txtTitel.Text;
        }

        private void listCategory_MouseDown(object sender, MouseEventArgs e)
        {
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listEpisodes.Items.Clear();
            var PodcastID  = listPodcast.SelectedItems[0].SubItems[0].Text;
            var podcast = service.Get(int.Parse(PodcastID));

           //var test = podcast.Items.First().Title.Text;

            foreach(var p in podcast.Items)
            {
                listEpisodes.Items.Add(p.Name);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPodcast = listPodcast.SelectedItems[0].Text;

            var podcast = service.Get(int.Parse(selectedPodcast));

            service.Delete(podcast);

            foreach (ListViewItem eachItem in listPodcast.SelectedItems)
            {
                listPodcast.Items.Remove(eachItem);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var selectedPodcast = listPodcast.SelectedItems[0].Text;
            if(selectedPodcast.Length >= 1)
            {
                var podcast = service.Get(int.Parse(selectedPodcast));
                podcast.Category = txtChooseCategory.Text;
                podcast.RefreshInterval = int.Parse(cbxFrekvens.Text);
                podcast.Name = txtTitel.Text;

                service.Save(podcast);
                service.Serialize();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           var p =  listPodcast.SelectedItems[0].Text;
           var podcast = service.Get(int.Parse(p)); 

            
           var itemTitle = listEpisodes.SelectedItem.ToString();

           var chosenEpisode = podcast.Items.Where(i => i.Name == itemTitle).FirstOrDefault();

           var c = chosenEpisode.Summary;
           listDescription.Items.Add(c);

        }

        private void listPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}