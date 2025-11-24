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
        public frmTitles()
        {
            InitializeComponent();
            
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = ValidateRequiredString(txtTitle, "Title");
            if (title == null) return;

            int? royalty = ParseNullableInt(txtRoyalty, "Royalty");
            decimal? price = ParseNullableDecimal(txtPrice, "Price");
            decimal? advance = ParseNullableDecimal(txtAdvance, "Advance");

            if (txtRoyalty.Text.Length > 0 && royalty == null) return;
            if (txtPrice.Text.Length > 0 && price == null) return;
            if (txtAdvance.Text.Length > 0 && advance == null) return;

        }



        private string ValidateRequiredString(TextBox txt, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show($"{fieldName} is required.");
                return null; 
            }
            return txt.Text;
        }
        private int? ParseNullableInt(TextBox txt, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(txt.Text)) return null; 
            if (int.TryParse(txt.Text, out int value)) return value;

            MessageBox.Show($"{fieldName} must be a valid integer.");
            return null; 
        }
        private decimal? ParseNullableDecimal(TextBox txt, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(txt.Text)) return null; 
            if (decimal.TryParse(txt.Text, out decimal value)) return value;

            MessageBox.Show($"{fieldName} must be a valid decimal number.");
            return null; 
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls) if (ctrl is TextBox txt) { txt.Clear(); }
        }

    }
}
