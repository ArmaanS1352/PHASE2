using System;
using System.Windows.Forms;

namespace PHASE2
{
    internal class Validator
    {
        
        public string ValidateRequiredString(TextBoxBase txt, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show($"{fieldName} is required.");
                return null;
            }
            return txt.Text.Trim();
        }

        
        public int? ParseNullableInt(TextBox txt, string fieldName, bool required = false)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (required)
                {
                    MessageBox.Show($"{fieldName} is required.");
                    return null;
                }
                return null;
            }

            if (int.TryParse(txt.Text, out int value)) return value;

            MessageBox.Show($"{fieldName} must be a valid integer.");
            return null;
        }


        
        public decimal? ParseNullableDecimal(TextBox txt, string fieldName, bool required = false)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (required)
                {
                    MessageBox.Show($"{fieldName} is required.");
                    return null;
                }
                return null;
            }

            if (decimal.TryParse(txt.Text, out decimal value)) return value;

            MessageBox.Show($"{fieldName} must be a valid decimal number.");
            return null;
        }

        
        public DateTime? ParseNullableDate(TextBox txt, string fieldName, bool required = false)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (required)
                {
                    MessageBox.Show($"{fieldName} is required.");
                    return null;
                }
                return null;
            }

            if (DateTime.TryParse(txt.Text, out DateTime value)) return value;

            MessageBox.Show($"{fieldName} must be a valid date.");
            return null;
        }

       
        public string ValidateComboSelection(ComboBox cbo, string fieldName)
        {
            if (cbo.SelectedIndex < 0)
            {
                MessageBox.Show($"Please select a {fieldName}.");
                return null;
            }
            return cbo.SelectedValue?.ToString();
        }

        
        public bool ValidateRange(int value, int min, int max, string fieldName)
        {
            if (value < min || value > max)
            {
                MessageBox.Show($"{fieldName} must be between {min} and {max}.");
                return false;
            }
            return true;
        }

        
        public string ValidateMaskedInput(MaskedTextBox mtxt, string fieldName)
        {
            if (!mtxt.MaskCompleted)
            {
                MessageBox.Show($"{fieldName} is incomplete.");
                return null;
            }
            return mtxt.Text;
        }


        public string ValidatePubID(ComboBox cbo, MaskedTextBox msk)
        {
            if (cbo.SelectedItem != null && msk.MaskFull)
            {
                MessageBox.Show("Please EITHER select an ID OR enter a custom 99XX ID");
                return null;
            }
            else if (cbo.SelectedItem == null && !msk.MaskFull)
            {
                MessageBox.Show("Pub ID is a required field.");
                return null;
            }
            else if (cbo.SelectedItem != null)
            {
                return cbo.SelectedItem.ToString();
            }
            else
            {
                return msk.Text;
            }

        }
    }
}
