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
    public partial class frmAuthors : Form
    {
        private Validator validator = new Validator();
        
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string auId = validator.ValidateRequiredString(mskAuId, "Author ID");
            string lastName = validator.ValidateRequiredString(txtLastName, "Last Name");
            string firstName = validator.ValidateRequiredString(txtFirstName, "First Name");
            string phone = validator.ValidateRequiredString(mskTxtPhone, "Phone");
            string? address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
            string? city = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text;
            string? state = string.IsNullOrWhiteSpace(txtState.Text) ? null : txtState.Text;
            string? zip = string.IsNullOrWhiteSpace(mskTxtZip.Text) ? null : mskTxtZip.Text;
            bool contract = chkContract.Checked;

            if (auId == null || lastName == null || firstName == null || phone == null) return;

            Author author = new Author
            {
                AuthorId = auId,
                LastName = lastName,
                FirstName = firstName,
                Phone = phone,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Contract = contract
            };

            Console.WriteLine($"auid: {auId}");
            Console.WriteLine($"lname: {lastName}");
            Console.WriteLine($"fname: {firstName}");
            Console.WriteLine($"phone: {phone}");
            Console.WriteLine($"address: {address}");
            Console.WriteLine($"city: {city}");
            Console.WriteLine($"state: {state}");
            Console.WriteLine($"zip: {zip}");
            try
            {
                author.Save();
                MessageBox.Show("Author saved!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving author: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            mskAuId.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            mskTxtPhone.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mskTxtZip.Clear();
            chkContract.Checked = false;
        }

        private void txtAuId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
