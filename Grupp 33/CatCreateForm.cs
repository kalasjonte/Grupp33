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
    public partial class CatCreateForm : Form
    {

        public CatCreateForm()
        {

            InitializeComponent();
        }

       
        private string name;

        private void btnCatCreate_Click(object sender, EventArgs e)
        {
            
            name = txtCatName.Text;
            if (!Validation.CheckEmptyTxt(name) && !Validation.isCategoryNameTaken(name))
            {
                CategoryController controll = new CategoryController();
                controll.createCategory(name);
                this.Close();
            }

        }

        private void btnCatCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public string GetNewCategory()
        {
            this.ShowDialog();
            return name;
            
        }
    }
}
