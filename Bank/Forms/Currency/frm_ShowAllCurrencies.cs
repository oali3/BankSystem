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
    public partial class frm_ShowAllCurrencies : Form
    {
        public frm_ShowAllCurrencies()
        {
            InitializeComponent();
        }

        private void frm_ShowAllCurrencies_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsCurrency.GetAllCurrencies();
        }
    }
}
