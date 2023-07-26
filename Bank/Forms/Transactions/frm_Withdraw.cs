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
    public partial class frm_Withdraw : Form
    {
        string _AccountNumber = "";
        clsClient Client;
        public frm_Withdraw(string AccountNumber)
        {
            InitializeComponent();
            _AccountNumber = AccountNumber;
        }

        private void frm_Withdraw_Load(object sender, EventArgs e)
        {
            btnWithdraw.BackColor = clsGlobalSettings.color;

            Client = clsClient.FindByAccountNumber(_AccountNumber);

            tbAccountNumber.Text = Client.AccountNumber;
            tbPinCode.Text = Client.PinCode;
            tbFirstName.Text = Client.FirstName;
            tbLastName.Text = Client.LastName;
            tbPhone.Text = Client.Phone;
            tbEmail.Text = Client.Email;
            tbBalance.Text = Client.Balance.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (updownWithdraw.Value == 0)
            {
                MessageBox.Show("Enter a posotive ammount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (updownWithdraw.Value > Client.Balance)
            {
                MessageBox.Show($"You can only withdraw amount up to {Client.Balance}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (MessageBox.Show($"Are you sure to withdraw {updownWithdraw.Value} from {_AccountNumber} Account", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Client.Balance -= updownWithdraw.Value;
                if (Client.Save())
                {
                    tbBalance.Text = Client.Balance.ToString();
                    MessageBox.Show($"withdraw Done Successfully, New balance is {Client.Balance}");
                }
                else
                {
                    MessageBox.Show("withdraw didn't Complete successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
