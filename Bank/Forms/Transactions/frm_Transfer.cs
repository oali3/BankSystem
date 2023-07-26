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
    public partial class frm_Transfer : Form
    {
        string _AccountNumber = "";
        string _AccountNumber2 = "";
        clsClient Client;
        clsClient Client2;
        public frm_Transfer(string Acc1, string Acc2)
        {
            InitializeComponent();
            _AccountNumber = Acc1;
            _AccountNumber2 = Acc2;
        }

        private void frm_Transfer_Load(object sender, EventArgs e)
        {
            btnTransfer.BackColor = clsGlobalSettings.color;

            Client = clsClient.FindByAccountNumber(_AccountNumber);

            tbAccountNumber.Text = Client.AccountNumber;
            tbPinCode.Text = Client.PinCode;
            tbFirstName.Text = Client.FirstName;
            tbLastName.Text = Client.LastName;
            tbPhone.Text = Client.Phone;
            tbEmail.Text = Client.Email;
            tbBalance.Text = Client.Balance.ToString();


            Client2 = clsClient.FindByAccountNumber(_AccountNumber2);

            tb2AccountNumber.Text = Client2.AccountNumber;
            tb2PinCode.Text = Client2.PinCode;
            tb2FirstName.Text = Client2.FirstName;
            tb2LastName.Text = Client2.LastName;
            tb2Phone.Text = Client2.Phone;
            tb2Email.Text = Client2.Email;
            tb2Balance.Text = Client2.Balance.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (updownTransfer.Value == 0)
            {
                MessageBox.Show("Enter a posotive ammount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (updownTransfer.Value > Client.Balance)
            {
                MessageBox.Show($"You can only Transfer amount up to {Client.Balance}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (MessageBox.Show($"Are you sure to Transfer {updownTransfer.Value} from {_AccountNumber} to {_AccountNumber2}", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Client.Balance -= updownTransfer.Value;
                Client2.Balance += updownTransfer.Value;
                if (Client.Save() && Client2.Save())
                {
                    
                    tbBalance.Text = Client.Balance.ToString();
                    tb2Balance.Text = Client2.Balance.ToString();
                    MessageBox.Show($"Transfer Done Successfully");
                }
                else
                {
                    MessageBox.Show("Transfer didn't Complete successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
