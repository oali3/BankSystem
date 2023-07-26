using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank.Forms
{
    public partial class frm_AddNewClient : Form
    {
        public frm_AddNewClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumber.Text) || string.IsNullOrWhiteSpace(tbPinCode.Text)
                || string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text) 
                || string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Please fill all the information first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            clsClient Client = new clsClient();

            Client.AccountNumber = tbAccountNumber.Text;
            Client.PinCode = tbPinCode.Text;
            Client.FirstName = tbFirstName.Text;
            Client.LastName = tbLastName.Text;
            Client.Phone = tbPhone.Text;
            Client.Email = tbEmail.Text;
            Client.Balance = updownBalance.Value;

            if(Client.Save())
            {
                MessageBox.Show($"Client Added Sucessfully with ID = {Client.ClientID}", "Saved");
            }
            else
            {
                MessageBox.Show("Failed to Add", "Failed");
            }

        }

        private void frm_AddNewClient_Load(object sender, EventArgs e)
        {
            btnSave.BackColor = clsGlobalSettings.color;
        }
    }
}
