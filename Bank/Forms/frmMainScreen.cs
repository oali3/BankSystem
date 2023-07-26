using Bank.Forms;
using Bank.Forms.Client;
using Bank.Forms.Currency;
using Bank.Forms.Transactions;
using Bank.Forms.Users;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmMainScreen : Form
    {
        bool IsSideBarExpand = true;
        bool IsClientsExpand = false;
        bool IsUsersExpand = false;
        bool IsTransactionsExpand = false;
        bool IsCurrenciesExpand = false;




        Random rand;
        int index;
        Button CurrentButton;
        Button PreviousButton;
        
        public frmMainScreen()
        {
            InitializeComponent();
        }

        void GiveAccesses(int Permission)
        {
            if ((Permission & 1) == 1)
                btnManageUsers.Enabled = true;
            if ((Permission & 2) == 2)
                btnManageClients.Enabled = true;
            if ((Permission & 4) == 4)
                btnTransactions.Enabled = true;
            if ((Permission & 8) == 8)
                btnCurrency.Enabled = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmMainScreen_Load(object sender, System.EventArgs e)
        {
            rand = new Random();

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (clsGlobalSettings.user != null) 
                GiveAccesses(clsGlobalSettings.user.Permissions);

            this.ControlBox = false;
        }



        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            SideBarTimer.Start();
        }
        private void SideBarTimer_Tick(object sender, System.EventArgs e)
        {
            if (IsSideBarExpand)
            {
                pnlSideBar.Width -= 10;
                if (pnlSideBar.Width == pnlSideBar.MinimumSize.Width)
                {
                    SideBarTimer.Stop();
                    IsSideBarExpand = false;
                }

            }
            else
            {
                pnlSideBar.Width += 10;
                if (pnlSideBar.Width == pnlSideBar.MaximumSize.Width)
                {
                    SideBarTimer.Stop();
                    IsSideBarExpand = true;
                }
            }


        }
        private void TimerClients_Tick(object sender, System.EventArgs e)
        {
            if (IsClientsExpand)
            {
                pnlClients.Height -= 10;
                if (pnlClients.Height == pnlClients.MinimumSize.Height)
                {
                    TimerClients.Stop();
                    IsClientsExpand = false;
                }

            }
            else
            {
                pnlClients.Height += 10;
                if (pnlClients.Height == pnlClients.MaximumSize.Height)
                {
                    TimerClients.Stop();
                    IsClientsExpand = true;
                }
            }
        }
        private void TimerUsers_Tick(object sender, System.EventArgs e)
        {
            if (IsUsersExpand)
            {
                pnlUsers.Height -= 10;
                if (pnlUsers.Height == pnlUsers.MinimumSize.Height)
                {
                    TimerUsers.Stop();
                    IsUsersExpand = false;
                }

            }
            else
            {
                pnlUsers.Height += 10;
                if (pnlUsers.Height == pnlUsers.MaximumSize.Height)
                {
                    TimerUsers.Stop();
                    IsUsersExpand = true;
                }
            }
        }
        private void TimerTransactions_Tick(object sender, System.EventArgs e)
        {
            if (IsTransactionsExpand)
            {
                pnlTransactions.Height -= 10;
                if (pnlTransactions.Height == pnlTransactions.MinimumSize.Height)
                {
                    TimerTransactions.Stop();
                    IsTransactionsExpand = false;
                }

            }
            else
            {
                pnlTransactions.Height += 10;
                if (pnlTransactions.Height == pnlTransactions.MaximumSize.Height)
                {
                    TimerTransactions.Stop();
                    IsTransactionsExpand = true;
                }
            }
        }
        private void TimerCurrencies_Tick(object sender, System.EventArgs e)
        {
            if (IsCurrenciesExpand)
            {
                pnlCurrencies.Height -= 10;
                if (pnlCurrencies.Height == pnlCurrencies.MinimumSize.Height)
                {
                    TimerCurrencies.Stop();
                    IsCurrenciesExpand = false;
                }

            }
            else
            {
                pnlCurrencies.Height += 10;
                if (pnlCurrencies.Height == pnlCurrencies.MaximumSize.Height)
                {
                    TimerCurrencies.Stop();
                    IsCurrenciesExpand = true;
                }
            }
        }
        void DeExpandAll()
        {
            if (IsClientsExpand)
                TimerClients.Start();
            if (IsUsersExpand)
                TimerUsers.Start();
            if (IsTransactionsExpand)
                TimerTransactions.Start();
            if (IsCurrenciesExpand)
                TimerCurrencies.Start();
        }
        private void btnManageClients_Click(object sender, System.EventArgs e)
        {
            pnlMain.Controls.Clear();
            SelectButton((Button)sender);
            DeExpandAll();
            TimerClients.Start();
        }
        private void btnManageUsers_Click(object sender, System.EventArgs e)
        {
            pnlMain.Controls.Clear();
            SelectButton((Button)sender);
            DeExpandAll();
            TimerUsers.Start();
        }
        private void btnTransactions_Click(object sender, System.EventArgs e)
        {
            pnlMain.Controls.Clear();
            SelectButton((Button)sender);
            DeExpandAll();
            TimerTransactions.Start();
        }
        private void btnCurrency_Click(object sender, System.EventArgs e)
        {
            pnlMain.Controls.Clear();
            SelectButton((Button)sender);
            DeExpandAll();
            TimerCurrencies.Start();
        }



        //  Clients
        private void btnShowAllClients_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Clients List";
            frm_ShowAllClients frm = new frm_ShowAllClients();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnAddClient_Click(object sender, System.EventArgs e)
        {

            lbHeader.Text = "Add New Client";
            frm_AddNewClient frm = new frm_AddNewClient();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnDeleteClient_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Delete Client";
            frm_DeleteClient frm = new frm_DeleteClient();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnUpdateClient_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Update Client";
            frm_UpdateClient frm = new frm_UpdateClient();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnFind_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Find Client";
            frm_FindClient frm = new frm_FindClient();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }



        //  Users
        private void btnShowAllUsers_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Users List";
            frm_ShowAllUsers frm = new frm_ShowAllUsers();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnAddUser_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Add New User";
            frm_AddNewUser frm = new frm_AddNewUser();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnDeleteUser_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Delete User";
            frm_DeleteUser frm = new frm_DeleteUser();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnUpdateUser_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Update User";
            frm_UpdateUser frm = new frm_UpdateUser();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnFindUser_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Find User";
            frm_FindUser frm = new frm_FindUser();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }



        //  Transactions 
        private void btnDeposit_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Diposit";
            frm_Transaction_Find Find = new frm_Transaction_Find("Enter Account Number ");
            Find.ShowDialog();
            string AccountNumber = Find.AccountNumber;

            if (AccountNumber == "-")
                return;

            frm_Diposit frm = new frm_Diposit(AccountNumber);
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnWithdraw_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Withdraw";
            frm_Transaction_Find Find = new frm_Transaction_Find("Enter Account Number ");
            Find.ShowDialog();
            string AccountNumber = Find.AccountNumber;

            if (AccountNumber == "-")
                return;

            frm_Withdraw frm = new frm_Withdraw(AccountNumber);
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnTransfer_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Transfer";
            frm_Transaction_Find Find = new frm_Transaction_Find("Enter Account Number for Client 1");
            Find.ShowDialog();
            string AccountNumber = Find.AccountNumber;

            if (AccountNumber == "-")
                return;

            frm_Transaction_Find Find2 = new frm_Transaction_Find("Enter Account Number for Client 2");
            Find2.ShowDialog();
            string AccountNumber2 = Find2.AccountNumber;

            if (AccountNumber2 == "-")
                return;



            frm_Transfer frm = new frm_Transfer(AccountNumber, AccountNumber2);
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }



        //  Currency
        private void btnListCurrencies_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Currencies List";
            frm_ShowAllCurrencies frm = new frm_ShowAllCurrencies();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnFindCurrency_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Find Currency";
            frm_FindCurrency frm = new frm_FindCurrency();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnUpdateRate_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Update Currency";
            frm_UpdateRate frm = new frm_UpdateRate();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnCalculater_Click(object sender, System.EventArgs e)
        {
            lbHeader.Text = "Currency Calculator";
            frm_CurrencyCalculater frm = new frm_CurrencyCalculater();
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }


        //  Colors

        private Color GetRandomThemeColor()
        {
            int temp = rand.Next(clsGlobalSettings.ColorList.Length);
            while (index == temp)
            {
                temp = rand.Next(clsGlobalSettings.ColorList.Length);
            }
            index = temp;


            return ColorTranslator.FromHtml(clsGlobalSettings.ColorList[index]);
        }


        private void SelectButton(Button btn)
        {
            if (btn != null)
            {
                if (CurrentButton != btn)
                {
                    lbHeader.Text = btn.Tag.ToString();
                    ResetButtons();
                    Color color = GetRandomThemeColor();
                    clsGlobalSettings.color = color;

                    foreach (Form frm in pnlMain.Controls)
                    {
                        foreach (Control btn2 in frm.Controls)
                        {
                            if (btn2.GetType() == typeof(Button))
                            {
                                btn2.BackColor = color;
                            }
                        }
                    }

                    CurrentButton = btn;
                    CurrentButton.BackColor = color;
                    pnlHeader.BackColor = color;
                    CurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lbHeader.Text = "HOME";
                    ResetButtons();
                    CurrentButton = null;
                }
            }
        }

        private void ResetButtons()
        {
            foreach (Control pnl in pnlSideBar.Controls)
            {
                if (pnl.GetType() == typeof(Panel))
                {
                    foreach (Control btn in pnl.Controls)
                    {
                        btn.BackColor = Color.FromArgb(35, 40, 45);
                        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void pbMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



    }
}
