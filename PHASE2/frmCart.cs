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
    public partial class frmCart : Form
    {
        private const decimal TAX_RATE = 0.08m;
        private DataTable cartTable;
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            SetupFoundItemsGrid();
            SetupCartGrid();
            InitCartTable();
            UpdateTotals();

            btnCommitOrdeer.Enabled = false;
        }

        private void SetupFoundItemsGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.ReadOnly = true;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.MultiSelect = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.RowHeadersVisible = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCart.Columns.Add("TitleId", "TitleId");
            dgvCart.Columns.Add("Title", "Title");
            dgvCart.Columns.Add("Qty", "Qty");
            dgvCart.Columns.Add("Price", "Price");

            dgvCart.Columns["TitleId"].Visible = false;
        }

        private void InitCartTable()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("TitleId", typeof(string));
            cartTable.Columns.Add("Title", typeof(string));
            cartTable.Columns.Add("Qty", typeof(int));
            cartTable.Columns.Add("Price", typeof(decimal));
            dgvCart.DataSource = cartTable;
        }

        private void SearchTitles()
        {

        }

        private void SetupCartGrid()
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchTitle_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void lblFoundItems_Click(object sender, EventArgs e)
        {

        }

        private void dgvFoundItems_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotalValue_Click(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTaxValue_Click(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalValue_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCommitOrdeer_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotals()
        {
            decimal subtotal = 0m;

            // Loop through cart rows and calculate subtotal
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Price"].Value != null && row.Cells["Qty"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    subtotal += price * qty;
                }
            }

            // Tax (adjust rate if needed)
            decimal taxRate = 0.08m;   // 8%
            decimal tax = subtotal * taxRate;

            decimal total = subtotal + tax;

            // Display results in text boxes (formatted as currency)
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
        }
    }
}
