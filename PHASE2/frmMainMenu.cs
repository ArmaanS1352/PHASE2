using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHASE2
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            //temp testing code to instantly launch form being tested
            frmTitles titles = new frmTitles();
            titles.ShowDialog();
            frmAuthors authors = new frmAuthors();
            authors.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
