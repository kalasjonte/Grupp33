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
            RssController controller = new RssController();
        }

        private void btnPodCreate_Click(object sender, EventArgs e)
        {
            PodCreateForm podCreateForm = new PodCreateForm();
            Podcast podcast = podCreateForm.GetNewPodcast();

            listViewPod.View = View.Details;
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ListViewItem item1 = new ListViewItem(podcast.Name, 0);
            item1.SubItems.Add(podcast.NumberOfEpisodes.ToString());
            item1.SubItems.Add(podcast.UpdateFrequency.ToString());
            item1.SubItems.Add(podcast.Category.Name);
            

            listViewPod.Items.Add(item1);
        }

        private void btnCatCreate_Click(object sender, EventArgs e)
        {
            CatCreateForm catCreateForm = new CatCreateForm();
            Category category = catCreateForm.GetNewCategory();
            listViewCat.Items.Add(category.Name);
            
        }
    }
}
