
namespace QuanLyDoanhNghiep
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionProjectImplementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfCompletedEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grv_staffList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_staffName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_corName = new System.Windows.Forms.Label();
            this.txt_M_searchKey = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_M_search = new System.Windows.Forms.Button();
            this.btn_M_clear = new System.Windows.Forms.Button();
            this.pn_search = new System.Windows.Forms.Panel();
            this.lbl_M_searchType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_staffList)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.newToolStripMenuItem1,
            this.viewMenu,
            this.toolsMenu,
            this.statisticsToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1501, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.changeDataBaseToolStripMenuItem,
            this.restoreDatabaseToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            this.systemToolStripMenuItem.MouseEnter += new System.EventHandler(this.systemToolStripMenuItem_MouseEnter);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // changeDataBaseToolStripMenuItem
            // 
            this.changeDataBaseToolStripMenuItem.Name = "changeDataBaseToolStripMenuItem";
            this.changeDataBaseToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.changeDataBaseToolStripMenuItem.Text = "Change Database";
            this.changeDataBaseToolStripMenuItem.Visible = false;
            this.changeDataBaseToolStripMenuItem.Click += new System.EventHandler(this.changeDataBaseToolStripMenuItem_Click);
            // 
            // restoreDatabaseToolStripMenuItem
            // 
            this.restoreDatabaseToolStripMenuItem.Name = "restoreDatabaseToolStripMenuItem";
            this.restoreDatabaseToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.restoreDatabaseToolStripMenuItem.Text = "Restore Database";
            this.restoreDatabaseToolStripMenuItem.Click += new System.EventHandler(this.restoreDatabaseToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.userToolStripMenuItem});
            this.newToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            this.newToolStripMenuItem1.MouseEnter += new System.EventHandler(this.newToolStripMenuItem1_MouseEnter_1);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Visible = false;
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Visible = false;
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.staffListToolStripMenuItem,
            this.departmentListToolStripMenuItem,
            this.positionListToolStripMenuItem,
            this.genderListToolStripMenuItem,
            this.nationListToolStripMenuItem,
            this.projectInfomationToolStripMenuItem});
            this.viewMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(55, 24);
            this.viewMenu.Text = "&View";
            this.viewMenu.Click += new System.EventHandler(this.viewMenu_Click);
            this.viewMenu.MouseEnter += new System.EventHandler(this.viewMenu_MouseEnter);
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.CheckOnClick = true;
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.staffListToolStripMenuItem.Text = "Staff List";
            this.staffListToolStripMenuItem.Visible = false;
            this.staffListToolStripMenuItem.Click += new System.EventHandler(this.staffListToolStripMenuItem_Click);
            // 
            // departmentListToolStripMenuItem
            // 
            this.departmentListToolStripMenuItem.Name = "departmentListToolStripMenuItem";
            this.departmentListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.departmentListToolStripMenuItem.Text = "Department List";
            this.departmentListToolStripMenuItem.Visible = false;
            this.departmentListToolStripMenuItem.Click += new System.EventHandler(this.departmentListToolStripMenuItem_Click);
            // 
            // positionListToolStripMenuItem
            // 
            this.positionListToolStripMenuItem.Name = "positionListToolStripMenuItem";
            this.positionListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.positionListToolStripMenuItem.Text = "Position List";
            this.positionListToolStripMenuItem.Visible = false;
            this.positionListToolStripMenuItem.Click += new System.EventHandler(this.positionListToolStripMenuItem_Click);
            // 
            // genderListToolStripMenuItem
            // 
            this.genderListToolStripMenuItem.Name = "genderListToolStripMenuItem";
            this.genderListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.genderListToolStripMenuItem.Text = "Gender List";
            this.genderListToolStripMenuItem.Visible = false;
            this.genderListToolStripMenuItem.Click += new System.EventHandler(this.genderListToolStripMenuItem_Click);
            // 
            // nationListToolStripMenuItem
            // 
            this.nationListToolStripMenuItem.Name = "nationListToolStripMenuItem";
            this.nationListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nationListToolStripMenuItem.Text = "Nation List";
            this.nationListToolStripMenuItem.Visible = false;
            this.nationListToolStripMenuItem.Click += new System.EventHandler(this.nationListToolStripMenuItem_Click);
            // 
            // projectInfomationToolStripMenuItem
            // 
            this.projectInfomationToolStripMenuItem.Name = "projectInfomationToolStripMenuItem";
            this.projectInfomationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.projectInfomationToolStripMenuItem.Text = "Projects Infomation";
            this.projectInfomationToolStripMenuItem.Click += new System.EventHandler(this.projectInfomationToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.searchToolStripMenuItem1,
            this.divisionProjectImplementToolStripMenuItem});
            this.toolsMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(58, 24);
            this.toolsMenu.Text = "&Tools";
            this.toolsMenu.Click += new System.EventHandler(this.toolsMenu_Click);
            this.toolsMenu.MouseEnter += new System.EventHandler(this.toolsMenu_MouseEnter);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(271, 26);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // divisionProjectImplementToolStripMenuItem
            // 
            this.divisionProjectImplementToolStripMenuItem.Name = "divisionProjectImplementToolStripMenuItem";
            this.divisionProjectImplementToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.divisionProjectImplementToolStripMenuItem.Text = "Division Project Implement";
            this.divisionProjectImplementToolStripMenuItem.Visible = false;
            this.divisionProjectImplementToolStripMenuItem.Click += new System.EventHandler(this.divisionProjectImplementToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfCompletedEmployeesToolStripMenuItem});
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // numberOfCompletedEmployeesToolStripMenuItem
            // 
            this.numberOfCompletedEmployeesToolStripMenuItem.Name = "numberOfCompletedEmployeesToolStripMenuItem";
            this.numberOfCompletedEmployeesToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.numberOfCompletedEmployeesToolStripMenuItem.Text = "Number of Completed Employees";
            this.numberOfCompletedEmployeesToolStripMenuItem.Click += new System.EventHandler(this.numberOfCompletedEmployeesToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.windowsMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(84, 24);
            this.windowsMenu.Text = "&Windows";
            this.windowsMenu.Click += new System.EventHandler(this.windowsMenu_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vietnameseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.vietnameseToolStripMenuItem.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(55, 24);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1006);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1501, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // grv_staffList
            // 
            this.grv_staffList.AllowUserToAddRows = false;
            this.grv_staffList.AllowUserToDeleteRows = false;
            this.grv_staffList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_staffList.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.grv_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_staffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.grv_staffList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grv_staffList.Location = new System.Drawing.Point(0, 164);
            this.grv_staffList.Name = "grv_staffList";
            this.grv_staffList.RowHeadersWidth = 51;
            this.grv_staffList.RowTemplate.Height = 24;
            this.grv_staffList.Size = new System.Drawing.Size(1500, 361);
            this.grv_staffList.TabIndex = 6;
            this.grv_staffList.Visible = false;
            this.grv_staffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_staffList_CellContentClick);
            this.grv_staffList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_staffList_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maNV";
            this.Column1.HeaderText = "Staff ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenNV";
            this.Column2.HeaderText = "Staff Fullname";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cccd";
            this.Column3.HeaderText = "Citizen Identification";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenGT";
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tenDT";
            this.Column5.HeaderText = "Nation";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngaySinh";
            this.Column6.HeaderText = "Date of birth";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "diaChi";
            this.Column7.HeaderText = "Address";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sdt";
            this.Column8.HeaderText = "Phone Number";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "email";
            this.Column9.HeaderText = "Email";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "tenCV";
            this.Column10.HeaderText = "Position";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_staffName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_corName);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2500, 133);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(716, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Restart the Application";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(599, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.BackColor = System.Drawing.Color.White;
            this.lbl_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_staffName.Location = new System.Drawing.Point(156, 105);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(185, 25);
            this.lbl_staffName.TabIndex = 2;
            this.lbl_staffName.Text = "label3daaaaaaaaaa";
            this.lbl_staffName.Click += new System.EventHandler(this.lbl_staffName_Click);
            this.lbl_staffName.MouseEnter += new System.EventHandler(this.lbl_staffName_MouseEnter);
            this.lbl_staffName.MouseLeave += new System.EventHandler(this.lbl_staffName_MouseLeave);
            this.lbl_staffName.MouseHover += new System.EventHandler(this.lbl_staffName_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome User:";
            // 
            // lbl_corName
            // 
            this.lbl_corName.AutoSize = true;
            this.lbl_corName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_corName.Location = new System.Drawing.Point(18, 15);
            this.lbl_corName.Name = "lbl_corName";
            this.lbl_corName.Size = new System.Drawing.Size(391, 54);
            this.lbl_corName.TabIndex = 0;
            this.lbl_corName.Text = "ABC Corporation";
            // 
            // txt_M_searchKey
            // 
            this.txt_M_searchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_M_searchKey.Location = new System.Drawing.Point(214, 7);
            this.txt_M_searchKey.Name = "txt_M_searchKey";
            this.txt_M_searchKey.Size = new System.Drawing.Size(574, 27);
            this.txt_M_searchKey.TabIndex = 9;
            this.txt_M_searchKey.TextChanged += new System.EventHandler(this.txt_M_searchKey_TextChanged);
            this.txt_M_searchKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_searchKey_KeyPress);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_search.Location = new System.Drawing.Point(24, 14);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(140, 20);
            this.lbl_search.TabIndex = 8;
            this.lbl_search.Text = "Enter Search Key";
            // 
            // btn_M_search
            // 
            this.btn_M_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_M_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_M_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_M_search.Image")));
            this.btn_M_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_M_search.Location = new System.Drawing.Point(1641, 8);
            this.btn_M_search.Name = "btn_M_search";
            this.btn_M_search.Size = new System.Drawing.Size(133, 31);
            this.btn_M_search.TabIndex = 11;
            this.btn_M_search.Text = "   Search";
            this.btn_M_search.UseVisualStyleBackColor = true;
            this.btn_M_search.Click += new System.EventHandler(this.btn_M_search_Click);
            // 
            // btn_M_clear
            // 
            this.btn_M_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_M_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_M_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_M_clear.Image")));
            this.btn_M_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_M_clear.Location = new System.Drawing.Point(1780, 8);
            this.btn_M_clear.Name = "btn_M_clear";
            this.btn_M_clear.Size = new System.Drawing.Size(132, 31);
            this.btn_M_clear.TabIndex = 12;
            this.btn_M_clear.Text = "    Clear";
            this.btn_M_clear.UseVisualStyleBackColor = true;
            this.btn_M_clear.Click += new System.EventHandler(this.btn_M_clear_Click);
            // 
            // pn_search
            // 
            this.pn_search.Controls.Add(this.lbl_M_searchType);
            this.pn_search.Controls.Add(this.btn_M_clear);
            this.pn_search.Controls.Add(this.btn_M_search);
            this.pn_search.Controls.Add(this.lbl_search);
            this.pn_search.Controls.Add(this.txt_M_searchKey);
            this.pn_search.Location = new System.Drawing.Point(0, 959);
            this.pn_search.Name = "pn_search";
            this.pn_search.Size = new System.Drawing.Size(2500, 45);
            this.pn_search.TabIndex = 10;
            // 
            // lbl_M_searchType
            // 
            this.lbl_M_searchType.AutoSize = true;
            this.lbl_M_searchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_M_searchType.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_M_searchType.Location = new System.Drawing.Point(802, 10);
            this.lbl_M_searchType.Name = "lbl_M_searchType";
            this.lbl_M_searchType.Size = new System.Drawing.Size(244, 20);
            this.lbl_M_searchType.TabIndex = 13;
            this.lbl_M_searchType.Text = "...............................................";
            this.lbl_M_searchType.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 726);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 699);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 696);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excel.ForeColor = System.Drawing.Color.Black;
            this.btn_Excel.Location = new System.Drawing.Point(1396, 531);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(104, 42);
            this.btn_Excel.TabIndex = 17;
            this.btn_Excel.Text = "Export Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Visible = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1501, 1032);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_search);
            this.Controls.Add(this.grv_staffList);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_staffList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_search.ResumeLayout(false);
            this.pn_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.DataGridView grv_staffList;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_corName;
        private System.Windows.Forms.ToolStripMenuItem departmentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.Label lbl_staffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionProjectImplementToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_M_searchKey;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_M_search;
        private System.Windows.Forms.Button btn_M_clear;
        private System.Windows.Forms.Panel pn_search;
        private System.Windows.Forms.Label lbl_M_searchType;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ToolStripMenuItem restoreDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectInfomationToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfCompletedEmployeesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Excel;
    }
}



