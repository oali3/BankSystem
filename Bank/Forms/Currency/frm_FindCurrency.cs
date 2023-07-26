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

namespace Bank.Forms.Currency
{
    public partial class frm_FindCurrency : Form
    {
        public frm_FindCurrency()
        {
            InitializeComponent();
        }

        private void rbCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCode.Checked == true)
            {
                lbInput.Text = "Code";
            }
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCountry.Checked == true)
            {
                lbInput.Text = "Country";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbInput.Text))
            {
                MessageBox.Show($"Enter {lbInput.Text} First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsCurrency Currency;
            if (rbCode.Checked == true)
                Currency = clsCurrency.FindByCode(tbInput.Text);
            else
                Currency = clsCurrency.FindByCountry(tbInput.Text);
            


            if (Currency == null)
            {
                MessageBox.Show("Currency Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbCountry.Text = Currency.Country;
                tbCode.Text = Currency.Code;
                tbName.Text = Currency.Name;
                tbRate.Text = Currency.Rate.ToString();
            }
        }

        private void frm_FindCurrency_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
        }
    }
}
