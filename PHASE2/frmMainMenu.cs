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
            
            
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnTitles_Click(object sender, EventArgs e)
        {
            var f = new frmTitles();
            f.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var f = new frmEmployees();
            f.ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            var f = new frmAuthors();
            f.ShowDialog();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            var f = new frmCart();
            f.ShowDialog();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            var f = new frmPublishers();    
            f.ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            var f = new frmInvoice();
            f.ShowDialog();
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            var f = new frmStores();
            f.ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            var f = new frmSalesReport();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
