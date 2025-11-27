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
    public partial class frmTitles : Form
    {
        private Validator validator = new Validator();

        public frmTitles()
        {
            InitializeComponent();
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string titleId = validator.ValidateRequiredString(txtTitleID, "Title ID");
            string titleName = validator.ValidateRequiredString(txtTitle, "Title");
            string type = validator.ValidateRequiredString(txtType, "Type");
            string publisherId = "test";
                //validator.ValidateComboSelection(cboPub, "Publisher");
            decimal? price = validator.ParseNullableDecimal(txtPrice, "Price");
            decimal? advance = validator.ParseNullableDecimal(txtAdvance, "Advance");
            int? royalty = validator.ParseNullableInt(txtRoyalty, "Royalty");
            int? ytdSales = validator.ParseNullableInt(txtYtdSales, "YTD Sales");
            string notes = txtNotes.Text;
            DateTime? pubDate = dtpPubDate.Checked ? dtpPubDate.Value : (DateTime?)null;

            if (titleId == null || titleName == null) return;

            Title t = new Title
            {
                TitleId = titleId,
                TitleName = titleName,
                Type = type,
                PublisherId = publisherId,
                Price = price,
                Advance = advance,
                Royalty = royalty,
                YtdSales = ytdSales,
                Notes = notes,
                PubDate = pubDate
            };

            try
            {
                t.save();
                MessageBox.Show("Title saved!", "Yippee", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex) { 
                MessageBox.Show($"Error saving title: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTitleID.Clear();
            txtTitle.Clear();
            txtType.Clear();
            cboPub.SelectedIndex = -1;
            txtPrice.Clear();
            txtAdvance.Clear();
            txtRoyalty.Clear();
            txtYtdSales.Clear();
            txtNotes.Clear();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {

        }
    }
}
