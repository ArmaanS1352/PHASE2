using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            UpdateTotals();
            btnCommitOrdeer.Enabled = false;
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
                subtotal += Convert.ToDecimal(row.Cells["colLineTotal"].Value);
            }

            // Tax (adjust rate if needed)
            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;

            // Display results in text boxes (formatted as currency)
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtTitleSearch.Text.Trim();
            string sql = @"SELECT title_id, title, price, pub_id
                            FROM titles
                            WHERE title LIKE @input + '%'";

            SqlParameter[] sp = { new SqlParameter("@input", input) };
            DataTable result = DatabaseHelper.ExecuteReader(sql, sp);
            dgvFoundItems.DataSource = result;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow != null)
            {
                string titleId = dgvFoundItems.CurrentRow.Cells["colID"].Value.ToString();
                string title = dgvFoundItems.CurrentRow.Cells["colTitle"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvFoundItems.CurrentRow.Cells["colPrice"].Value.ToString());
                int qty = (int)numQty.Value;

                dgvCart.Rows.Add(titleId, title, qty, price, qty * price);
                UpdateTotals();
            }
        }
    }
}







/*
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
*/