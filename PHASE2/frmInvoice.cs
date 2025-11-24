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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            txtOrderNumberValue.Text = GenerateOrderNumber();
        }

        private void lblOrderNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvInvoiceItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            string orderNumber = txtOrderNumberValue.Text.Trim();

            if (orderNumber == "")
            {
                MessageBox.Show("Order number cannot be blank.");
                return;
            }

            // Later: save order to DB.
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalValue_Click(object sender, EventArgs e)
        {

        }

        private string GenerateOrderNumber()
        {
            // Simple order number generation logic
            return DateTime.Now.Ticks.ToString().Substring(10);
        }
    }
}
