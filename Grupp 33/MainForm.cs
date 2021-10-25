using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp_33
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            listViewCat.View = View.Details;
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPod.FullRowSelect = true;

            CategoryController ccontroller = new CategoryController();
            ccontroller.DeSerializeCat();
            PodcastController podcontroll = new PodcastController();
            podcontroll.DeserializePodcast();

            LoadPodListView();
        }

        public List<Category> categories = new List<Category>();
        public List<Podcast> podcastList = new List<Podcast>();

        private async void btnPodCreate_Click(object sender, EventArgs e)
        {
            PodCreateForm podCreateForm = new PodCreateForm();
            Podcast podcast = (Podcast)podCreateForm.GetNewPodcast();
           // RssController controller = new RssController();
           // controller.PodcastRss(podcast);
            PodcastController podcontroll = new PodcastController();
            var boolresultat = await podcontroll.FetchNewPodcastAsync(podcast);
            podcastList.Add(podcast);
            

            ListViewItem item1 = new ListViewItem(podcast.Name, 0);
            item1.SubItems.Add(podcast.NumberOfItems.ToString());
            item1.SubItems.Add(podcast.UpdateFrequency.ToString());
            item1.SubItems.Add(podcast.Category.Name);

            listViewPod.Items.Add(item1);
            
        }

        private void btnCatCreate_Click(object sender, EventArgs e)
        {
            CatCreateForm catCreateForm = new CatCreateForm();
            Category category = catCreateForm.GetNewCategory();
            categories.Add(category);
            //denna blir null när man kryssar catCreate förnstret utan att skriva något
            listViewCat.Items.Add(category.Name);
            
        }

        private void btnCatSave_Click(object sender, EventArgs e)
        {
            CategoryController controller = new CategoryController();
            controller.SerializeCat(categories);
            
        }

        private void btnPodSave_Click(object sender, EventArgs e)
        {
            PodcastController controller = new PodcastController();
            controller.SerializePodcasts(podcastList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadPodListView()
        {
            PodcastController podcontroll = new PodcastController();
            podcastList = podcontroll.DeserializePodcast();
            fillPodListview(podcastList);
        }

        public void fillPodListview(List<Podcast> PodList)
        {
            listViewPod.View = View.Details;
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listViewPod.FullRowSelect = true;

            foreach (var pod in PodList)
            {
                ListViewItem item1 = new ListViewItem(pod.Name, 0);
                item1.SubItems.Add(pod.NumberOfItems.ToString());
                item1.SubItems.Add(pod.UpdateFrequency.ToString());
                item1.SubItems.Add(pod.Category.Name);

                listViewPod.Items.Add(item1);
            }
        }

        private void listViewPod_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewEp.Items.Clear();
            if (listViewPod.SelectedItems.Count > 0){

                var podrad = listViewPod.SelectedItems[0];
                string name = podrad.Text; // == namnet på podden
                var query = from pod in podcastList
                            where pod.Name == name
                            select pod;
                
                Podcast selectedPod = query.First();
                List<Item> itemList = selectedPod.items;
                LoadEpListView(itemList);
            }

        }
        private void LoadEpListView(List<Item> itemList)
        {
            listViewEp.View = View.Details;
            listViewEp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (var ep in itemList)
            {
                ListViewItem item = new ListViewItem(ep.Name, 0);
                listViewEp.Items.Add(item);
            }

        }

        private void listViewEp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtEpDes.Text = "";
            //if (listViewEp.SelectedItems.Count > 0)
            //{

            //    var eprad = listViewEp.SelectedItems[0];
            //    string name = eprad.Text; // == namnet på avsnittet
            //    var query = from pod in podcastList
            //                where pod.Name == name
            //                select pod;

            //    Podcast selectedPod = query.First();
            //    List<Item> itemList = selectedPod.items;
            //    LoadEpListView(itemList);
            //}
        }
    }
}
