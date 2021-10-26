﻿using BLL;
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
            string selectedCategory = coBoxCat.SelectedItem.ToString();
            var query = from cat in categoryList
                        where cat.Name == selectedCategory
                        select cat;
            Category category = query.First();

            pod = new Podcast(txtTitle.Text, txtURL.Text, "Podcast", Int32.Parse(coBoxUpdFreq.SelectedItem.ToString()),  category);
            category.podcastsList.Add(pod);
            catControll.SerializeCat(categoryList);
            this.Close();
        }

        public Media GetNewPodcast()
        {
            this.ShowDialog();
            return pod;

        }
    }
}
