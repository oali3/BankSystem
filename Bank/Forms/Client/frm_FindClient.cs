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
    public partial class frm_FindClient : Form
    {
        public frm_FindClient()
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

                pnlInfo.Enabled = true;
            }
        }

        private void frm_FindClient_Load(object sender, EventArgs e)
        {
            btnFindDeleteClient.BackColor = clsGlobalSettings.color;
        }
    }
}
