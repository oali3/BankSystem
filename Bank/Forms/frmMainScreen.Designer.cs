namespace Bank
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlCurrencies = new System.Windows.Forms.Panel();
            this.btnCalculater = new System.Windows.Forms.Button();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.btnListCurrencies = new System.Windows.Forms.Button();
            this.btnFindCurrency = new System.Windows.Forms.Button();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnShowAllClients = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerClients = new System.Windows.Forms.Timer(this.components);
            this.TimerUsers = new System.Windows.Forms.Timer(this.components);
            this.TimerTransactions = new System.Windows.Forms.Timer(this.components);
            this.TimerCurrencies = new System.Windows.Forms.Timer(this.components);
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.pnlCurrencies.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlClients.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlSideBar.Controls.Add(this.pnlCurrencies);
            this.pnlSideBar.Controls.Add(this.pnlTransactions);
            this.pnlSideBar.Controls.Add(this.pnlUsers);
            this.pnlSideBar.Controls.Add(this.pnlClients);
            this.pnlSideBar.Controls.Add(this.pnlMenu);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(212, 1080);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(67, 696);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(212, 696);
            this.pnlSideBar.TabIndex = 3;
            // 
            // pnlCurrencies
            // 
            this.pnlCurrencies.Controls.Add(this.btnCalculater);
            this.pnlCurrencies.Controls.Add(this.btnCurrency);
            this.pnlCurrencies.Controls.Add(this.btnUpdateRate);
            this.pnlCurrencies.Controls.Add(this.btnListCurrencies);
            this.pnlCurrencies.Controls.Add(this.btnFindCurrency);
            this.pnlCurrencies.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrencies.Location = new System.Drawing.Point(0, 248);
            this.pnlCurrencies.MaximumSize = new System.Drawing.Size(212, 237);
            this.pnlCurrencies.MinimumSize = new System.Drawing.Size(212, 60);
            this.pnlCurrencies.Name = "pnlCurrencies";
            this.pnlCurrencies.Size = new System.Drawing.Size(212, 60);
            this.pnlCurrencies.TabIndex = 8;
            // 
            // btnCalculater
            // 
            this.btnCalculater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculater.FlatAppearance.BorderSize = 0;
            this.btnCalculater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculater.ForeColor = System.Drawing.Color.White;
            this.btnCalculater.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculater.Image")));
            this.btnCalculater.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculater.Location = new System.Drawing.Point(0, 191);
            this.btnCalculater.Name = "btnCalculater";
            this.btnCalculater.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCalculater.Size = new System.Drawing.Size(209, 39);
            this.btnCalculater.TabIndex = 9;
            this.btnCalculater.Text = "          Calculator";
            this.btnCalculater.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculater.UseVisualStyleBackColor = true;
            this.btnCalculater.Click += new System.EventHandler(this.btnCalculater_Click);
            // 
            // btnCurrency
            // 
            this.btnCurrency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrency.Enabled = false;
            this.btnCurrency.FlatAppearance.BorderSize = 0;
            this.btnCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrency.ForeColor = System.Drawing.Color.White;
            this.btnCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrency.Image")));
            this.btnCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrency.Location = new System.Drawing.Point(0, 0);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCurrency.Size = new System.Drawing.Size(212, 60);
            this.btnCurrency.TabIndex = 4;
            this.btnCurrency.Tag = "Currency Exchange";
            this.btnCurrency.Text = "             Currency";
            this.btnCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrency.UseVisualStyleBackColor = true;
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateRate.FlatAppearance.BorderSize = 0;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRate.Image")));
            this.btnUpdateRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRate.Location = new System.Drawing.Point(0, 149);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUpdateRate.Size = new System.Drawing.Size(209, 39);
            this.btnUpdateRate.TabIndex = 8;
            this.btnUpdateRate.Text = "          Update Rate";
            this.btnUpdateRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // btnListCurrencies
            // 
            this.btnListCurrencies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListCurrencies.FlatAppearance.BorderSize = 0;
            this.btnListCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCurrencies.ForeColor = System.Drawing.Color.White;
            this.btnListCurrencies.Image = ((System.Drawing.Image)(resources.GetObject("btnListCurrencies.Image")));
            this.btnListCurrencies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCurrencies.Location = new System.Drawing.Point(0, 65);
            this.btnListCurrencies.Name = "btnListCurrencies";
            this.btnListCurrencies.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnListCurrencies.Size = new System.Drawing.Size(209, 39);
            this.btnListCurrencies.TabIndex = 6;
            this.btnListCurrencies.Text = "          List Currencies";
            this.btnListCurrencies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCurrencies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListCurrencies.UseVisualStyleBackColor = true;
            this.btnListCurrencies.Click += new System.EventHandler(this.btnListCurrencies_Click);
            // 
            // btnFindCurrency
            // 
            this.btnFindCurrency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindCurrency.FlatAppearance.BorderSize = 0;
            this.btnFindCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCurrency.ForeColor = System.Drawing.Color.White;
            this.btnFindCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCurrency.Image")));
            this.btnFindCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCurrency.Location = new System.Drawing.Point(0, 107);
            this.btnFindCurrency.Name = "btnFindCurrency";
            this.btnFindCurrency.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnFindCurrency.Size = new System.Drawing.Size(209, 39);
            this.btnFindCurrency.TabIndex = 7;
            this.btnFindCurrency.Text = "          Find Currency";
            this.btnFindCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCurrency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCurrency.UseVisualStyleBackColor = true;
            this.btnFindCurrency.Click += new System.EventHandler(this.btnFindCurrency_Click);
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.btnTransfer);
            this.pnlTransactions.Controls.Add(this.btnTransactions);
            this.pnlTransactions.Controls.Add(this.btnWithdraw);
            this.pnlTransactions.Controls.Add(this.btnDeposit);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 190);
            this.pnlTransactions.MaximumSize = new System.Drawing.Size(212, 191);
            this.pnlTransactions.MinimumSize = new System.Drawing.Size(212, 58);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(212, 58);
            this.pnlTransactions.TabIndex = 7;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(3, 146);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(209, 39);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "                 Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.Enabled = false;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(0, 0);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(212, 60);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Tag = "Transactions";
            this.btnTransactions.Text = "             Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(3, 104);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(209, 39);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "                 Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(3, 62);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(209, 39);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "                 Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.btnFindUser);
            this.pnlUsers.Controls.Add(this.btnManageUsers);
            this.pnlUsers.Controls.Add(this.btnShowAllUsers);
            this.pnlUsers.Controls.Add(this.btnUpdateUser);
            this.pnlUsers.Controls.Add(this.btnAddUser);
            this.pnlUsers.Controls.Add(this.btnDeleteUser);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsers.Location = new System.Drawing.Point(0, 132);
            this.pnlUsers.MaximumSize = new System.Drawing.Size(212, 272);
            this.pnlUsers.MinimumSize = new System.Drawing.Size(212, 58);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(212, 58);
            this.pnlUsers.TabIndex = 6;
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.Location = new System.Drawing.Point(3, 226);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnFindUser.Size = new System.Drawing.Size(209, 39);
            this.btnFindUser.TabIndex = 11;
            this.btnFindUser.Text = "                 Find User";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.Enabled = false;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnManageUsers.Size = new System.Drawing.Size(212, 60);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Tag = "Manage Users";
            this.btnManageUsers.Text = "             Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowAllUsers.FlatAppearance.BorderSize = 0;
            this.btnShowAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowAllUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllUsers.Image")));
            this.btnShowAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllUsers.Location = new System.Drawing.Point(3, 58);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnShowAllUsers.Size = new System.Drawing.Size(209, 39);
            this.btnShowAllUsers.TabIndex = 7;
            this.btnShowAllUsers.Text = "                 Show All Users";
            this.btnShowAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(3, 184);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(209, 39);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "                 Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(3, 100);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(209, 39);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "                 Add New User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(3, 142);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(209, 39);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "                 Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // pnlClients
            // 
            this.pnlClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlClients.Controls.Add(this.btnFindClient);
            this.pnlClients.Controls.Add(this.btnUpdateClient);
            this.pnlClients.Controls.Add(this.btnDeleteClient);
            this.pnlClients.Controls.Add(this.btnAddClient);
            this.pnlClients.Controls.Add(this.btnShowAllClients);
            this.pnlClients.Controls.Add(this.btnManageClients);
            this.pnlClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClients.Location = new System.Drawing.Point(0, 72);
            this.pnlClients.MaximumSize = new System.Drawing.Size(212, 272);
            this.pnlClients.MinimumSize = new System.Drawing.Size(212, 60);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(212, 60);
            this.pnlClients.TabIndex = 5;
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.White;
            this.btnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindClient.Image")));
            this.btnFindClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.Location = new System.Drawing.Point(3, 227);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnFindClient.Size = new System.Drawing.Size(209, 39);
            this.btnFindClient.TabIndex = 6;
            this.btnFindClient.Text = "                 Find Client";
            this.btnFindClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateClient.Image")));
            this.btnUpdateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.Location = new System.Drawing.Point(3, 185);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUpdateClient.Size = new System.Drawing.Size(209, 39);
            this.btnUpdateClient.TabIndex = 5;
            this.btnUpdateClient.Text = "                 Update Client";
            this.btnUpdateClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(3, 143);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDeleteClient.Size = new System.Drawing.Size(209, 39);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Text = "                 Delete Client";
            this.btnDeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.Location = new System.Drawing.Point(3, 101);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAddClient.Size = new System.Drawing.Size(209, 39);
            this.btnAddClient.TabIndex = 3;
            this.btnAddClient.Text = "                 Add New Client";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnShowAllClients
            // 
            this.btnShowAllClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowAllClients.FlatAppearance.BorderSize = 0;
            this.btnShowAllClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllClients.ForeColor = System.Drawing.Color.White;
            this.btnShowAllClients.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllClients.Image")));
            this.btnShowAllClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllClients.Location = new System.Drawing.Point(3, 59);
            this.btnShowAllClients.Name = "btnShowAllClients";
            this.btnShowAllClients.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnShowAllClients.Size = new System.Drawing.Size(209, 39);
            this.btnShowAllClients.TabIndex = 2;
            this.btnShowAllClients.Text = "                 Show All Clients";
            this.btnShowAllClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllClients.UseVisualStyleBackColor = true;
            this.btnShowAllClients.Click += new System.EventHandler(this.btnShowAllClients_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageClients.Enabled = false;
            this.btnManageClients.FlatAppearance.BorderSize = 0;
            this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.ForeColor = System.Drawing.Color.White;
            this.btnManageClients.Image = ((System.Drawing.Image)(resources.GetObject("btnManageClients.Image")));
            this.btnManageClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageClients.Location = new System.Drawing.Point(0, 0);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageClients.Size = new System.Drawing.Size(212, 60);
            this.btnManageClients.TabIndex = 1;
            this.btnManageClients.Tag = "Manage Clients";
            this.btnManageClients.Text = "             Manage Clients";
            this.btnManageClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageClients.UseVisualStyleBackColor = true;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(212, 72);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // TimerClients
            // 
            this.TimerClients.Interval = 10;
            this.TimerClients.Tick += new System.EventHandler(this.TimerClients_Tick);
            // 
            // TimerUsers
            // 
            this.TimerUsers.Interval = 10;
            this.TimerUsers.Tick += new System.EventHandler(this.TimerUsers_Tick);
            // 
            // TimerTransactions
            // 
            this.TimerTransactions.Interval = 10;
            this.TimerTransactions.Tick += new System.EventHandler(this.TimerTransactions_Tick);
            // 
            // TimerCurrencies
            // 
            this.TimerCurrencies.Interval = 10;
            this.TimerCurrencies.Tick += new System.EventHandler(this.TimerCurrencies_Tick);
            // 
            // lbHeader
            // 
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(913, 72);
            this.lbHeader.TabIndex = 6;
            this.lbHeader.Text = "HOME";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlHeader.Controls.Add(this.pbMaximize);
            this.pnlHeader.Controls.Add(this.pbMinimize);
            this.pnlHeader.Controls.Add(this.pbClose);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(212, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(913, 72);
            this.pnlHeader.TabIndex = 8;
            // 
            // pbMaximize
            // 
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximize.Image")));
            this.pbMaximize.Location = new System.Drawing.Point(842, 12);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(25, 25);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximize.TabIndex = 8;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(808, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 7;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click_1);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(878, 17);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(19, 16);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(212, 72);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(913, 503);
            this.pnlMain.TabIndex = 9;
            // 
            // frmMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1125, 575);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(828, 474);
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlCurrencies.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlClients.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Button btnShowAllClients;
        private System.Windows.Forms.Timer TimerClients;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Panel pnlCurrencies;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Timer TimerUsers;
        private System.Windows.Forms.Timer TimerTransactions;
        private System.Windows.Forms.Timer TimerCurrencies;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnCalculater;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.Button btnListCurrencies;
        private System.Windows.Forms.Button btnFindCurrency;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
    }
}