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

namespace Bank.Forms.Users
{
    public partial class frm_ShowAllUsers : Form
    {
        public frm_ShowAllUsers()
        {
            InitializeComponent();
        }

        private void frm_ShowAllUsers_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = clsUser.GetAllUsers();
        }
    }
}
