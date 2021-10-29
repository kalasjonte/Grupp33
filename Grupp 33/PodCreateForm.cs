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
    public partial class PodCreateForm : Form
    {
        private Media pod;
        private CategoryController catControll = new CategoryController();
        private List<Category> categoryList;

        public PodCreateForm()
        {
            InitializeComponent();
            //hämta category xml --> lista cmbbox
             categoryList = catControll.DeSerializeCat();
            foreach (var item in categoryList)
            {
                coBoxCat.Items.Add(item.Name);
            }
            
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Validation.CheckURL(txtURL.Text) && !Validation.ContainsWhiteSpace(txtURL.Text) && !Validation.isPodcastNameTaken(txtTitle.Text))
            {
                string selectedCategory = coBoxCat.SelectedItem.ToString();

                Category category = catControll.GetCategoryByName(selectedCategory);

                int updatefreq = Int32.Parse(coBoxUpdFreq.SelectedItem.ToString() + "000");

                pod = new Podcast(txtTitle.Text, txtURL.Text, "Podcast", updatefreq, category);
                category.podcastsList.Add(pod.Name);
                catControll.SerializeCat(categoryList);
                this.Close();
            }

        }

        public Media GetNewPodcast()
        {
            this.ShowDialog();
            return pod;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
