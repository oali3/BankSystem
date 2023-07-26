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
    public partial class frm_Transaction_Find : Form
    {
        public string AccountNumber = "";
        bool IsUserClosing = true;
        public frm_Transaction_Find(string message)
        {
            InitializeComponent();
            lbMessage.Text = message;
        }


        private void btnFindDeleteClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumber.Text))
            {
                MessageBox.Show("Enter Account Number First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsClient.IsExist(tbAccountNumber.Text))
            {
                AccountNumber = tbAccountNumber.Text;
                IsUserClosing = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Client Not Found\nEnter another Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Transaction_Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserClosing)
                AccountNumber = "-";
        }

        private void frm_Transaction_Find_Load(object sender, EventArgs e)
        {
            btnFindDeleteClient.BackColor = clsGlobalSettings.color;
        }
    }
}
