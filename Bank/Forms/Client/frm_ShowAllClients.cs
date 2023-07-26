using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank.Forms.Client
{
    public partial class frm_ShowAllClients : Form
    {
        public frm_ShowAllClients()
        {
            InitializeComponent();
        }

        private void frm_ShowAllClients_Load(object sender, EventArgs e)
        {
            dgvClients.DataSource = clsClient.GetAllClients();
        }
    }
}
