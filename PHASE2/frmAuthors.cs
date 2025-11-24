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
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = ValidateRequiredString(txtFirstName, "First Name");
            string lastName = ValidateRequiredString(txtLastName, "Last Name");
            if (firstName != null || lastName != null) return;

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
        


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls) if (ctrl is TextBox txt) { txt.Clear(); }
        }
    }
}
