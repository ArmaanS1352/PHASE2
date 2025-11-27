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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPosition.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Add row to DataGridView
            dgvEmployees.Rows.Add(txtName.Text, txtPosition.Text, txtID.Text);

            // Clear fields
            txtName.Clear();
            txtPosition.Clear();
            txtID.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an employee to edit.");
                return;
            }

            // Fill textboxes with selected row
            var row = dgvEmployees.SelectedRows[0];
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtPosition.Text = row.Cells["Position"].Value.ToString();
            txtID.Text = row.Cells["ID"].Value.ToString();

            // Remove the row so it can be re-added
            dgvEmployees.Rows.Remove(row);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an employee to delete.");
                return;
            }

            dgvEmployees.Rows.RemoveAt(dgvEmployees.SelectedRows[0].Index);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
