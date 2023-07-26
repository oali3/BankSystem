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
    public partial class frm_DeleteClient : Form
    {
        public frm_DeleteClient()
        {
            InitializeComponent();
        }

        private void btnFindDeleteClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumber.Text))
            {
                MessageBox.Show("Enter Account Number First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsClient Client = clsClient.FindByAccountNumber(tbAccountNumber.Text);


            if (Client == null)
            {
                btnDelete.Enabled = false;
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

                btnDelete.Enabled = true;
                pnlInfo.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Client", "warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }


            if (clsClient.DeleteClient(tbAccountNumber.Text))
            {
                MessageBox.Show("Client deleted successfully");
                tbAccountNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPinCode.Text = "";
            updownBalance.Value = 0;
        }

        private void frm_DeleteClient_Load(object sender, EventArgs e)
        {
            btnDelete.BackColor = clsGlobalSettings.color;
            btnFindDeleteClient.BackColor = clsGlobalSettings.color;
        }
    }
}
