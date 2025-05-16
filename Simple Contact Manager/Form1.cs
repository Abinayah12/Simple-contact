using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Contact_Manager
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    if (
 (phone.StartsWith("+") && phone.Length >= 11 && phone.Length <= 13 && phone.Substring(1).All(char.IsDigit)) ||
 (phone.Length >= 10 && phone.Length <= 12 && phone.All(char.IsDigit))
)
                    {
                        string name = txtName.Text;

                        // Bug: Doesn't check if fields are empty
                        // Bug: Accepts invalid phone number
                        lstDisplay.Items.Add(name + " - " + phone);

                        txtPhone.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Phone number must be between 10 to 12 digits and contain only numbers");
                    }
                }
                else
                {
                    MessageBox.Show("Phone Canot be Null");
                }


            }
            else
            {
                MessageBox.Show("Name Canot be Null");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text="";
            txtPhone.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lstDisplay.SelectedItem != null)
            {
                lstDisplay.Items.Remove(lstDisplay.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select a contact to delete");
            }
        }
    }
}
