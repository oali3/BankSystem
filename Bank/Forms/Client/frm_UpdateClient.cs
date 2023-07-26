using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms.Client
{
    public partial class frm_UpdateClient : Form
    {
        public frm_UpdateClient()
        {
            InitializeComponent();
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPinCode.Text = "";
            updownBalance.Value = 0;
        }

        private void btnFindUpdateClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumber.Text))
            {
                MessageBox.Show("Enter Account Number First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsClient Client = clsClient.FindByAccountNumber(tbAccountNumber.Text);


            if (Client == null)
            {
                btnUpdate.Enabled = false;
                MessageBox.Show("Client Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbFirstName.Text = Client.FirstName;
                tbLastName.Text = Client.LastName;
                tbPhone.Text = Client.Phone;
                tbEmail.Text = Client.Email;
                tbPinCode.Text = Client.PinCode;
                updownBalance.Value = Client.Balance;

                btnUpdate.Enabled = true;
                pnlInfo.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumber.Text) || string.IsNullOrWhiteSpace(tbPinCode.Text)
             || string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)
             || string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Please fill all the information first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsClient Client = clsClient.FindByAccountNumber(tbAccountNumber.Text);

            Client.FirstName = tbFirstName.Text;
            Client.LastName = tbLastName.Text;
            Client.Phone = tbPhone.Text;
            Client.Email = tbEmail.Text;
            Client.PinCode = tbPinCode.Text;
            Client.Balance = updownBalance.Value;



            if (Client.Save())
            {
                MessageBox.Show("Client Updated successfully");
                tbAccountNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_UpdateClient_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
            btnUpdate.BackColor = clsGlobalSettings.color;
        }
    }
}
