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
    public partial class frm_CurrencyCalculater : Form
    {            
        clsCurrency Currency;
        clsCurrency Currency2;
        public frm_CurrencyCalculater()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCode.Text))
            {
                MessageBox.Show($"Enter Code First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Currency = clsCurrency.FindByCode(tbCode.Text);

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

                tb2Code.Enabled = true;
                btn2Find.Enabled = true;
            }
        }

        private void btn2Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb2Code.Text))
            {
                MessageBox.Show($"Enter Code First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Currency2 = clsCurrency.FindByCode(tb2Code.Text);

            if (Currency2 == null)
            {
                MessageBox.Show("Currency Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tb2Country.Text = Currency2.Country;
                tb2Code.Text = Currency2.Code;
                tb2Name.Text = Currency2.Name;
                tb2Rate.Text = Currency2.Rate.ToString();

                updownAmount.Enabled = true;
                btnExchange.Enabled = true;
            }
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (updownAmount.Value == 0)
            {
                MessageBox.Show("Enter Exchange Amount First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double result;
            if (Currency.Code == "USD")
            {
                result = (double)updownAmount.Value * (double)Currency2.Rate;
            }
            else
                result = (double)updownAmount.Value / (double)Currency.Rate;


            lbResult.Text = $"{updownAmount.Value} {tbCode.Text} = {result} {tb2Code.Text}";


        }

        private void frm_CurrencyCalculater_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
            btn2Find.BackColor = clsGlobalSettings.color;
            btnExchange.BackColor = clsGlobalSettings.color;
        }
    }
}
