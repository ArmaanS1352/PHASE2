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
    public partial class frmPublishers : Form
    {
        private Validator validator = new Validator();

        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            mskPubID.Mask = "\\9\\9##";
            mskPubID.PromptChar = ' ';
            cboPubID.Items.AddRange(new string[] {"1756", "1622", "0877", "0736", "1389"});
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pubId = validator.ValidatePubID(cboPubID, mskPubID);
            if (pubId == null) return;

            Publisher publisher = new Publisher
            {
                PublisherId = pubId,
                PublisherName = string.IsNullOrWhiteSpace(txtPubName.Text) ? null : txtPubName.Text,
                City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text,
                State = string.IsNullOrWhiteSpace(txtState.Text) ? null : txtState.Text,
                Country = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text
            };

            try
            {
                publisher.Save();
                MessageBox.Show("Publisher saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving publisher: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void ClearForm()
        {
            cboPubID.SelectedIndex = -1;
            mskPubID.Clear();
            txtPubName.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
        }
    }
}
