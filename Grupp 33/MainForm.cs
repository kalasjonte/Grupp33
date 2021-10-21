using BLL;
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

    }
}
