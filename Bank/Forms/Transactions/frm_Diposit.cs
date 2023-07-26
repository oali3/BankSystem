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

namespace Bank.Forms.Transactions
{
    public partial class frm_Diposit : Form
    {        
        string _AccountNumber = "";
        clsClient Client;
        public frm_Diposit(string AccountNumber)
        {
            InitializeComponent();
            _AccountNumber = AccountNumber;
        }

        private void frm_Diposit_Load(object sender, EventArgs e)
        {
            btnDeposit.BackColor = clsGlobalSettings.color;

            Client = clsClient.FindByAccountNumber(_AccountNumber);

            tbAccountNumber.Text = Client.AccountNumber;
            tbPinCode.Text = Client.PinCode;
            tbFirstName.Text = Client.FirstName;
            tbLastName.Text = Client.LastName;
            tbPhone.Text = Client.Phone;
            tbEmail.Text = Client.Email;
            tbBalance.Text = Client.Balance.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (updownDiposit.Value == 0)
            {
                MessageBox.Show("Enter a posotive ammount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure to diposit {updownDiposit.Value} into {_AccountNumber} Account", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Client.Balance += updownDiposit.Value;
                if(Client.Save())
                {
                    tbBalance.Text = Client.Balance.ToString();
                    MessageBox.Show($"Diposit Done Successfully, New balance is {Client.Balance}");
                }
                else
                {
                    MessageBox.Show("Diposit didn't Complete successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }
}
