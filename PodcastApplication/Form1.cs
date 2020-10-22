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

        public string categoryText;
        ListViewItem item1 = new ListViewItem();
        List<Podcast> podcasts = new List<Podcast>();
        PodcastService service = null;
      
        
        public Form1()
        {
            IPodcastDal dataacess = new PodcastDataAccess.PodcastDal();
            service = new PodcastService(dataacess);
            
            InitializeComponent();
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
                // var s = ""https://www.svt.se/rss.xml";
                var podcast = service.Load("https://feed.pod.space/filipandfredrik");
              

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
            categoryText = txtInsertCategory.Text;
            listCategory.Items.Add(categoryText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtChooseCategory.Text != "" && txtTitel.Text != "" && listPodcast.SelectedItems.Count >= 1)
            {
                 listPodcast.SelectedItems[0].SubItems[3].Text = txtChooseCategory.Text;
                 listPodcast.SelectedItems[0].SubItems[1].Text = txtTitel.Text;
            }
            else
            {
                MessageBox.Show("Fyll i värden och välj från podcast vilken lista du vill ändra");
            }
        }

        private void listCategory_MouseDown(object sender, MouseEventArgs e)
        {
            txtChooseCategory.Text = listCategory.SelectedItems[0].ToString();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            var PodcastID  = listPodcast.SelectedItems[0].SubItems[0].Text;
            var podcast = service.Get(int.Parse(PodcastID));

           //var test = podcast.Items.First().Title.Text;

            foreach(var p in podcast.Items)
            {
                listEpisodes.Items.Add(p.Title.Text);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPodcast = listPodcast.SelectedItems[0].Text;
            var podcast = service.Get(int.Parse(selectedPodcast));

            service.Delete(podcast);

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var selectedPodcast = listPodcast.SelectedItems[0].Text;
            var podcast = service.Get(int.Parse(selectedPodcast));

            podcast.Category = "kalleanka";
            podcast.RefreshInterval = int.Parse("400");

            service.savePodcast(podcast);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hämta en podcast via index från listview
            // hämta itemindex från listcategori
            // LINQ där jag frågar hämta item.index där index lika med selecteditem(från listbox)


           var p =  listPodcast.SelectedItems[0].Text;
           var podcast = service.Get(int.Parse(p)); 

           
            
           var itemTitle = listEpisodes.SelectedItem.ToString();

            var chosenEpisode = podcast.Items.Where(i => i.Title.Text == itemTitle).FirstOrDefault();

           var c = chosenEpisode.Summary.Text;
           listDescription.Items.Add(c);




        }

        private void listDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
           





        }
    } 
}