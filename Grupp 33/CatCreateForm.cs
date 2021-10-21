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

        private void btnCatCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category(txtCatName.Text);
            this.Close();
        }

        private void btnCatCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
