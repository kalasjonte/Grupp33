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
        public PodCreateForm()
        {
            InitializeComponent();
            
        }

        private Podcast pod;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category(coBoxCat.SelectedItem.ToString());
            pod= new Podcast(txtTitle.Text, category, Int32.Parse(coBoxUpdFreq.SelectedItem.ToString()), txtURL.Text, "Podcast");
            this.Close();
        }

        public Podcast GetNewPodcast()
        {
            this.ShowDialog();
            return pod;

        }
    }
}
