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
            CategoryController ccontroller = new CategoryController();
            ccontroller.DeSerializeCat();
            PodcastController podcontroll = new PodcastController();
            podcontroll.DeserializePodcast();
        }

        public List<Category> categories = new List<Category>();
        public List<Podcast> podcastList = new List<Podcast>();

        private void btnPodCreate_Click(object sender, EventArgs e)
        {
            PodCreateForm podCreateForm = new PodCreateForm();
            Podcast podcast = (Podcast)podCreateForm.GetNewPodcast();
            RssController controller = new RssController();
            controller.PodcastRss(podcast);
            podcastList.Add(podcast);

            listViewPod.View = View.Details;
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
    }
}
