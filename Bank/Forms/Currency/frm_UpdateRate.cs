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
using System.Xml.Linq;

namespace Bank.Forms.Currency
{
    public partial class frm_UpdateRate : Form
    {            
        clsCurrency Currency;
        public frm_UpdateRate()
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


            if (rbCode.Checked == true)
                Currency = clsCurrency.FindByCode(tbInput.Text);
            else
                Currency = clsCurrency.FindByCountry(tbInput.Text);



            if (Currency == null)
            {
                MessageBox.Show("Currency Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updownRate.Enabled = false;
                btnUpdate.Enabled = false;
                return;
            }
            else
            {
                tbRate.Text = Currency.Rate.ToString();
                updownRate.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updownRate.Value == 0)
            {
                MessageBox.Show("Enter New Rate First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Currency.UpdateRate(updownRate.Value))
            {
                tbRate.Text = updownRate.Value.ToString();
                MessageBox.Show("Update Done Successfully", "Done");
            }
            else
            {
                MessageBox.Show("Not Updated Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_UpdateRate_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
            btnUpdate.BackColor = clsGlobalSettings.color;
        }
    }
}
