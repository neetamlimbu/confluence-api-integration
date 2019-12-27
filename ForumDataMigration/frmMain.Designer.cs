namespace ForumDataMigration
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
            this.dgForumThread = new System.Windows.Forms.DataGridView();
            this.cmdUploadForumThread = new System.Windows.Forms.Button();
            this.tbcForum = new System.Windows.Forms.TabControl();
            this.tbpForum = new System.Windows.Forms.TabPage();
            this.dgForum = new System.Windows.Forms.DataGridView();
            this.txtForumApiUrl = new System.Windows.Forms.TextBox();
            this.lblForumApiUrl = new System.Windows.Forms.Label();
            this.cmdForumUpload = new System.Windows.Forms.Button();
            this.txtForumNoOfRows = new System.Windows.Forms.TextBox();
            this.lblForumNoOfRows = new System.Windows.Forms.Label();
            this.lblForumOrderBy = new System.Windows.Forms.Label();
            this.cmbForumOrderBy = new System.Windows.Forms.ComboBox();
            this.txtForumID = new System.Windows.Forms.TextBox();
            this.lblForumID = new System.Windows.Forms.Label();
            this.cmdClearAllForum = new System.Windows.Forms.Button();
            this.cmdSelectAllForum = new System.Windows.Forms.Button();
            this.cmdLoadForum = new System.Windows.Forms.Button();
            this.tbpSubForum = new System.Windows.Forms.TabPage();
            this.cmdAssignSubForum = new System.Windows.Forms.Button();
            this.txtForumThreadNoOfRows = new System.Windows.Forms.TextBox();
            this.lblForumThreadNoOfRows = new System.Windows.Forms.Label();
            this.lblForumThreadOrderBy = new System.Windows.Forms.Label();
            this.cmbForumThreadOrderBy = new System.Windows.Forms.ComboBox();
            this.txtSubForumID = new System.Windows.Forms.TextBox();
            this.lblSubForumID = new System.Windows.Forms.Label();
            this.txtSubForumFID = new System.Windows.Forms.TextBox();
            this.lblSubForumFID = new System.Windows.Forms.Label();
            this.cmdClearAllSubForum = new System.Windows.Forms.Button();
            this.cmdSelectAllSubForum = new System.Windows.Forms.Button();
            this.txtSubForumApiUrl = new System.Windows.Forms.TextBox();
            this.lblSubForumApiUrl = new System.Windows.Forms.Label();
            this.cmdLoadSubForum = new System.Windows.Forms.Button();
            this.cmdUploadSubForum = new System.Windows.Forms.Button();
            this.dgSubForum = new System.Windows.Forms.DataGridView();
            this.tbpForumThread = new System.Windows.Forms.TabPage();
            this.cmdAssignForumThread = new System.Windows.Forms.Button();
            this.txtForumPostNoOfRows = new System.Windows.Forms.TextBox();
            this.lblForumPostNoOfRows = new System.Windows.Forms.Label();
            this.lblForumPostOrderBy = new System.Windows.Forms.Label();
            this.cmbForumPostOrderBy = new System.Windows.Forms.ComboBox();
            this.txtForumThreadSFID = new System.Windows.Forms.TextBox();
            this.lblForumThreadSFID = new System.Windows.Forms.Label();
            this.txtForumThreadFID = new System.Windows.Forms.TextBox();
            this.lblForumThreadFID = new System.Windows.Forms.Label();
            this.txtForumThreadID = new System.Windows.Forms.TextBox();
            this.lblForumThreadID = new System.Windows.Forms.Label();
            this.cmdClearAllForumThread = new System.Windows.Forms.Button();
            this.cmdSelectAllForumThread = new System.Windows.Forms.Button();
            this.txtForumThreadApiUrl = new System.Windows.Forms.TextBox();
            this.lblForumThreadApiUrl = new System.Windows.Forms.Label();
            this.cmdLoadForumThread = new System.Windows.Forms.Button();
            this.tbpUsers = new System.Windows.Forms.TabPage();
            this.txtApiUserUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGetUsers = new System.Windows.Forms.Button();
            this.txtUsersNoOfRows = new System.Windows.Forms.TextBox();
            this.lblUsersNoOfRows = new System.Windows.Forms.Label();
            this.cmdClearAllUsers = new System.Windows.Forms.Button();
            this.cmdSelectAllUsers = new System.Windows.Forms.Button();
            this.cmdLoadUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.colErrorMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblSpace = new System.Windows.Forms.Label();
            this.txtSpace = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pbUploadForumThread = new System.Windows.Forms.ProgressBar();
            this.lblForumThreadProgressCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgForumThread)).BeginInit();
            this.tbcForum.SuspendLayout();
            this.tbpForum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgForum)).BeginInit();
            this.tbpSubForum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubForum)).BeginInit();
            this.tbpForumThread.SuspendLayout();
            this.tbpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgForumThread
            // 
            this.dgForumThread.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgForumThread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForumThread.Location = new System.Drawing.Point(6, 126);
            this.dgForumThread.Name = "dgForumThread";
            this.dgForumThread.Size = new System.Drawing.Size(664, 64);
            this.dgForumThread.TabIndex = 2;
            // 
            // cmdUploadForumThread
            // 
            this.cmdUploadForumThread.Location = new System.Drawing.Point(494, 92);
            this.cmdUploadForumThread.Name = "cmdUploadForumThread";
            this.cmdUploadForumThread.Size = new System.Drawing.Size(75, 23);
            this.cmdUploadForumThread.TabIndex = 3;
            this.cmdUploadForumThread.Text = "Upload";
            this.cmdUploadForumThread.UseVisualStyleBackColor = true;
            this.cmdUploadForumThread.Click += new System.EventHandler(this.cmdUploadForumThread_Click);
            // 
            // tbcForum
            // 
            this.tbcForum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcForum.Controls.Add(this.tbpForum);
            this.tbcForum.Controls.Add(this.tbpSubForum);
            this.tbcForum.Controls.Add(this.tbpForumThread);
            this.tbcForum.Controls.Add(this.tbpUsers);
            this.tbcForum.Location = new System.Drawing.Point(0, 128);
            this.tbcForum.Name = "tbcForum";
            this.tbcForum.SelectedIndex = 0;
            this.tbcForum.Size = new System.Drawing.Size(684, 196);
            this.tbcForum.TabIndex = 4;
            // 
            // tbpForum
            // 
            this.tbpForum.Controls.Add(this.dgForum);
            this.tbpForum.Controls.Add(this.txtForumApiUrl);
            this.tbpForum.Controls.Add(this.lblForumApiUrl);
            this.tbpForum.Controls.Add(this.cmdForumUpload);
            this.tbpForum.Controls.Add(this.txtForumNoOfRows);
            this.tbpForum.Controls.Add(this.lblForumNoOfRows);
            this.tbpForum.Controls.Add(this.lblForumOrderBy);
            this.tbpForum.Controls.Add(this.cmbForumOrderBy);
            this.tbpForum.Controls.Add(this.txtForumID);
            this.tbpForum.Controls.Add(this.lblForumID);
            this.tbpForum.Controls.Add(this.cmdClearAllForum);
            this.tbpForum.Controls.Add(this.cmdSelectAllForum);
            this.tbpForum.Controls.Add(this.cmdLoadForum);
            this.tbpForum.Location = new System.Drawing.Point(4, 22);
            this.tbpForum.Name = "tbpForum";
            this.tbpForum.Padding = new System.Windows.Forms.Padding(3);
            this.tbpForum.Size = new System.Drawing.Size(676, 170);
            this.tbpForum.TabIndex = 2;
            this.tbpForum.Text = "Forum";
            this.tbpForum.UseVisualStyleBackColor = true;
            // 
            // dgForum
            // 
            this.dgForum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgForum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForum.Location = new System.Drawing.Point(6, 126);
            this.dgForum.Name = "dgForum";
            this.dgForum.Size = new System.Drawing.Size(664, 38);
            this.dgForum.TabIndex = 47;
            // 
            // txtForumApiUrl
            // 
            this.txtForumApiUrl.Location = new System.Drawing.Point(61, 94);
            this.txtForumApiUrl.Name = "txtForumApiUrl";
            this.txtForumApiUrl.Size = new System.Drawing.Size(275, 20);
            this.txtForumApiUrl.TabIndex = 46;
            this.txtForumApiUrl.Text = "rest/api/content";
            // 
            // lblForumApiUrl
            // 
            this.lblForumApiUrl.AutoSize = true;
            this.lblForumApiUrl.Location = new System.Drawing.Point(11, 97);
            this.lblForumApiUrl.Name = "lblForumApiUrl";
            this.lblForumApiUrl.Size = new System.Drawing.Size(38, 13);
            this.lblForumApiUrl.TabIndex = 45;
            this.lblForumApiUrl.Text = "Api Url";
            // 
            // cmdForumUpload
            // 
            this.cmdForumUpload.Location = new System.Drawing.Point(342, 91);
            this.cmdForumUpload.Name = "cmdForumUpload";
            this.cmdForumUpload.Size = new System.Drawing.Size(75, 23);
            this.cmdForumUpload.TabIndex = 44;
            this.cmdForumUpload.Text = "Upload";
            this.cmdForumUpload.UseVisualStyleBackColor = true;
            this.cmdForumUpload.Click += new System.EventHandler(this.cmdForumUpload_Click);
            // 
            // txtForumNoOfRows
            // 
            this.txtForumNoOfRows.Enabled = false;
            this.txtForumNoOfRows.Location = new System.Drawing.Point(82, 35);
            this.txtForumNoOfRows.Name = "txtForumNoOfRows";
            this.txtForumNoOfRows.Size = new System.Drawing.Size(63, 20);
            this.txtForumNoOfRows.TabIndex = 43;
            // 
            // lblForumNoOfRows
            // 
            this.lblForumNoOfRows.AutoSize = true;
            this.lblForumNoOfRows.Location = new System.Drawing.Point(14, 40);
            this.lblForumNoOfRows.Name = "lblForumNoOfRows";
            this.lblForumNoOfRows.Size = new System.Drawing.Size(61, 13);
            this.lblForumNoOfRows.TabIndex = 42;
            this.lblForumNoOfRows.Text = "No of rows:";
            // 
            // lblForumOrderBy
            // 
            this.lblForumOrderBy.AutoSize = true;
            this.lblForumOrderBy.Location = new System.Drawing.Point(158, 13);
            this.lblForumOrderBy.Name = "lblForumOrderBy";
            this.lblForumOrderBy.Size = new System.Drawing.Size(48, 13);
            this.lblForumOrderBy.TabIndex = 41;
            this.lblForumOrderBy.Text = "Order By";
            // 
            // cmbForumOrderBy
            // 
            this.cmbForumOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForumOrderBy.FormattingEnabled = true;
            this.cmbForumOrderBy.Items.AddRange(new object[] {
            "FID",
            "Display Order"});
            this.cmbForumOrderBy.Location = new System.Drawing.Point(213, 9);
            this.cmbForumOrderBy.Name = "cmbForumOrderBy";
            this.cmbForumOrderBy.Size = new System.Drawing.Size(121, 21);
            this.cmbForumOrderBy.TabIndex = 40;
            // 
            // txtForumID
            // 
            this.txtForumID.Location = new System.Drawing.Point(45, 9);
            this.txtForumID.Name = "txtForumID";
            this.txtForumID.Size = new System.Drawing.Size(100, 20);
            this.txtForumID.TabIndex = 37;
            // 
            // lblForumID
            // 
            this.lblForumID.AutoSize = true;
            this.lblForumID.Location = new System.Drawing.Point(14, 12);
            this.lblForumID.Name = "lblForumID";
            this.lblForumID.Size = new System.Drawing.Size(24, 13);
            this.lblForumID.TabIndex = 36;
            this.lblForumID.Text = "FID";
            // 
            // cmdClearAllForum
            // 
            this.cmdClearAllForum.Location = new System.Drawing.Point(171, 61);
            this.cmdClearAllForum.Name = "cmdClearAllForum";
            this.cmdClearAllForum.Size = new System.Drawing.Size(75, 23);
            this.cmdClearAllForum.TabIndex = 35;
            this.cmdClearAllForum.Text = "Clear All";
            this.cmdClearAllForum.UseVisualStyleBackColor = true;
            this.cmdClearAllForum.Click += new System.EventHandler(this.cmdClearAllForum_Click);
            // 
            // cmdSelectAllForum
            // 
            this.cmdSelectAllForum.Location = new System.Drawing.Point(90, 61);
            this.cmdSelectAllForum.Name = "cmdSelectAllForum";
            this.cmdSelectAllForum.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectAllForum.TabIndex = 34;
            this.cmdSelectAllForum.Text = "Select All";
            this.cmdSelectAllForum.UseVisualStyleBackColor = true;
            this.cmdSelectAllForum.Click += new System.EventHandler(this.cmdSelectAllForum_Click);
            // 
            // cmdLoadForum
            // 
            this.cmdLoadForum.Location = new System.Drawing.Point(9, 61);
            this.cmdLoadForum.Name = "cmdLoadForum";
            this.cmdLoadForum.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadForum.TabIndex = 33;
            this.cmdLoadForum.Text = "Load";
            this.cmdLoadForum.UseVisualStyleBackColor = true;
            this.cmdLoadForum.Click += new System.EventHandler(this.cmdForumLoad_Click);
            // 
            // tbpSubForum
            // 
            this.tbpSubForum.Controls.Add(this.cmdAssignSubForum);
            this.tbpSubForum.Controls.Add(this.txtForumThreadNoOfRows);
            this.tbpSubForum.Controls.Add(this.lblForumThreadNoOfRows);
            this.tbpSubForum.Controls.Add(this.lblForumThreadOrderBy);
            this.tbpSubForum.Controls.Add(this.cmbForumThreadOrderBy);
            this.tbpSubForum.Controls.Add(this.txtSubForumID);
            this.tbpSubForum.Controls.Add(this.lblSubForumID);
            this.tbpSubForum.Controls.Add(this.txtSubForumFID);
            this.tbpSubForum.Controls.Add(this.lblSubForumFID);
            this.tbpSubForum.Controls.Add(this.cmdClearAllSubForum);
            this.tbpSubForum.Controls.Add(this.cmdSelectAllSubForum);
            this.tbpSubForum.Controls.Add(this.txtSubForumApiUrl);
            this.tbpSubForum.Controls.Add(this.lblSubForumApiUrl);
            this.tbpSubForum.Controls.Add(this.cmdLoadSubForum);
            this.tbpSubForum.Controls.Add(this.cmdUploadSubForum);
            this.tbpSubForum.Controls.Add(this.dgSubForum);
            this.tbpSubForum.Location = new System.Drawing.Point(4, 22);
            this.tbpSubForum.Name = "tbpSubForum";
            this.tbpSubForum.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSubForum.Size = new System.Drawing.Size(676, 170);
            this.tbpSubForum.TabIndex = 1;
            this.tbpSubForum.Text = "Sub Forum ";
            this.tbpSubForum.UseVisualStyleBackColor = true;
            // 
            // cmdAssignSubForum
            // 
            this.cmdAssignSubForum.Location = new System.Drawing.Point(342, 92);
            this.cmdAssignSubForum.Name = "cmdAssignSubForum";
            this.cmdAssignSubForum.Size = new System.Drawing.Size(146, 23);
            this.cmdAssignSubForum.TabIndex = 33;
            this.cmdAssignSubForum.Text = "Assign Parent Page";
            this.cmdAssignSubForum.UseVisualStyleBackColor = true;
            this.cmdAssignSubForum.Click += new System.EventHandler(this.cmdAssignSubForum_Click);
            // 
            // txtForumThreadNoOfRows
            // 
            this.txtForumThreadNoOfRows.Enabled = false;
            this.txtForumThreadNoOfRows.Location = new System.Drawing.Point(82, 35);
            this.txtForumThreadNoOfRows.Name = "txtForumThreadNoOfRows";
            this.txtForumThreadNoOfRows.Size = new System.Drawing.Size(63, 20);
            this.txtForumThreadNoOfRows.TabIndex = 32;
            // 
            // lblForumThreadNoOfRows
            // 
            this.lblForumThreadNoOfRows.AutoSize = true;
            this.lblForumThreadNoOfRows.Location = new System.Drawing.Point(14, 40);
            this.lblForumThreadNoOfRows.Name = "lblForumThreadNoOfRows";
            this.lblForumThreadNoOfRows.Size = new System.Drawing.Size(61, 13);
            this.lblForumThreadNoOfRows.TabIndex = 31;
            this.lblForumThreadNoOfRows.Text = "No of rows:";
            // 
            // lblForumThreadOrderBy
            // 
            this.lblForumThreadOrderBy.AutoSize = true;
            this.lblForumThreadOrderBy.Location = new System.Drawing.Point(293, 12);
            this.lblForumThreadOrderBy.Name = "lblForumThreadOrderBy";
            this.lblForumThreadOrderBy.Size = new System.Drawing.Size(48, 13);
            this.lblForumThreadOrderBy.TabIndex = 30;
            this.lblForumThreadOrderBy.Text = "Order By";
            // 
            // cmbForumThreadOrderBy
            // 
            this.cmbForumThreadOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForumThreadOrderBy.FormattingEnabled = true;
            this.cmbForumThreadOrderBy.Items.AddRange(new object[] {
            "TID",
            "FID",
            "Post Date",
            "Display Order"});
            this.cmbForumThreadOrderBy.Location = new System.Drawing.Point(347, 7);
            this.cmbForumThreadOrderBy.Name = "cmbForumThreadOrderBy";
            this.cmbForumThreadOrderBy.Size = new System.Drawing.Size(121, 21);
            this.cmbForumThreadOrderBy.TabIndex = 29;
            // 
            // txtSubForumID
            // 
            this.txtSubForumID.Location = new System.Drawing.Point(45, 9);
            this.txtSubForumID.Name = "txtSubForumID";
            this.txtSubForumID.Size = new System.Drawing.Size(100, 20);
            this.txtSubForumID.TabIndex = 28;
            // 
            // lblSubForumID
            // 
            this.lblSubForumID.AutoSize = true;
            this.lblSubForumID.Location = new System.Drawing.Point(14, 12);
            this.lblSubForumID.Name = "lblSubForumID";
            this.lblSubForumID.Size = new System.Drawing.Size(31, 13);
            this.lblSubForumID.TabIndex = 27;
            this.lblSubForumID.Text = "SFID";
            // 
            // txtSubForumFID
            // 
            this.txtSubForumFID.Location = new System.Drawing.Point(182, 9);
            this.txtSubForumFID.Name = "txtSubForumFID";
            this.txtSubForumFID.Size = new System.Drawing.Size(100, 20);
            this.txtSubForumFID.TabIndex = 26;
            // 
            // lblSubForumFID
            // 
            this.lblSubForumFID.AutoSize = true;
            this.lblSubForumFID.Location = new System.Drawing.Point(152, 12);
            this.lblSubForumFID.Name = "lblSubForumFID";
            this.lblSubForumFID.Size = new System.Drawing.Size(24, 13);
            this.lblSubForumFID.TabIndex = 25;
            this.lblSubForumFID.Text = "FID";
            // 
            // cmdClearAllSubForum
            // 
            this.cmdClearAllSubForum.Location = new System.Drawing.Point(171, 61);
            this.cmdClearAllSubForum.Name = "cmdClearAllSubForum";
            this.cmdClearAllSubForum.Size = new System.Drawing.Size(75, 23);
            this.cmdClearAllSubForum.TabIndex = 10;
            this.cmdClearAllSubForum.Text = "Clear All";
            this.cmdClearAllSubForum.UseVisualStyleBackColor = true;
            this.cmdClearAllSubForum.Click += new System.EventHandler(this.cmdClearAllForumThreads_Click);
            // 
            // cmdSelectAllSubForum
            // 
            this.cmdSelectAllSubForum.Location = new System.Drawing.Point(90, 61);
            this.cmdSelectAllSubForum.Name = "cmdSelectAllSubForum";
            this.cmdSelectAllSubForum.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectAllSubForum.TabIndex = 9;
            this.cmdSelectAllSubForum.Text = "Select All";
            this.cmdSelectAllSubForum.UseVisualStyleBackColor = true;
            this.cmdSelectAllSubForum.Click += new System.EventHandler(this.cmdSelectAllForumThreads_Click);
            // 
            // txtSubForumApiUrl
            // 
            this.txtSubForumApiUrl.Location = new System.Drawing.Point(61, 94);
            this.txtSubForumApiUrl.Name = "txtSubForumApiUrl";
            this.txtSubForumApiUrl.Size = new System.Drawing.Size(275, 20);
            this.txtSubForumApiUrl.TabIndex = 8;
            this.txtSubForumApiUrl.Text = "rest/api/content";
            // 
            // lblSubForumApiUrl
            // 
            this.lblSubForumApiUrl.AutoSize = true;
            this.lblSubForumApiUrl.Location = new System.Drawing.Point(11, 97);
            this.lblSubForumApiUrl.Name = "lblSubForumApiUrl";
            this.lblSubForumApiUrl.Size = new System.Drawing.Size(38, 13);
            this.lblSubForumApiUrl.TabIndex = 7;
            this.lblSubForumApiUrl.Text = "Api Url";
            // 
            // cmdLoadSubForum
            // 
            this.cmdLoadSubForum.Location = new System.Drawing.Point(9, 61);
            this.cmdLoadSubForum.Name = "cmdLoadSubForum";
            this.cmdLoadSubForum.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadSubForum.TabIndex = 6;
            this.cmdLoadSubForum.Text = "Load";
            this.cmdLoadSubForum.UseVisualStyleBackColor = true;
            this.cmdLoadSubForum.Click += new System.EventHandler(this.cmdLoadForumThread_Click);
            // 
            // cmdUploadSubForum
            // 
            this.cmdUploadSubForum.Location = new System.Drawing.Point(494, 92);
            this.cmdUploadSubForum.Name = "cmdUploadSubForum";
            this.cmdUploadSubForum.Size = new System.Drawing.Size(75, 23);
            this.cmdUploadSubForum.TabIndex = 5;
            this.cmdUploadSubForum.Text = "Upload";
            this.cmdUploadSubForum.UseVisualStyleBackColor = true;
            this.cmdUploadSubForum.Click += new System.EventHandler(this.cmdUploadSubForum_Click);
            // 
            // dgSubForum
            // 
            this.dgSubForum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSubForum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubForum.Location = new System.Drawing.Point(6, 126);
            this.dgSubForum.Name = "dgSubForum";
            this.dgSubForum.Size = new System.Drawing.Size(664, 64);
            this.dgSubForum.TabIndex = 4;
            // 
            // tbpForumThread
            // 
            this.tbpForumThread.Controls.Add(this.lblForumThreadProgressCount);
            this.tbpForumThread.Controls.Add(this.pbUploadForumThread);
            this.tbpForumThread.Controls.Add(this.cmdAssignForumThread);
            this.tbpForumThread.Controls.Add(this.txtForumPostNoOfRows);
            this.tbpForumThread.Controls.Add(this.lblForumPostNoOfRows);
            this.tbpForumThread.Controls.Add(this.lblForumPostOrderBy);
            this.tbpForumThread.Controls.Add(this.cmbForumPostOrderBy);
            this.tbpForumThread.Controls.Add(this.txtForumThreadSFID);
            this.tbpForumThread.Controls.Add(this.lblForumThreadSFID);
            this.tbpForumThread.Controls.Add(this.txtForumThreadFID);
            this.tbpForumThread.Controls.Add(this.lblForumThreadFID);
            this.tbpForumThread.Controls.Add(this.txtForumThreadID);
            this.tbpForumThread.Controls.Add(this.lblForumThreadID);
            this.tbpForumThread.Controls.Add(this.cmdClearAllForumThread);
            this.tbpForumThread.Controls.Add(this.cmdSelectAllForumThread);
            this.tbpForumThread.Controls.Add(this.txtForumThreadApiUrl);
            this.tbpForumThread.Controls.Add(this.lblForumThreadApiUrl);
            this.tbpForumThread.Controls.Add(this.cmdLoadForumThread);
            this.tbpForumThread.Controls.Add(this.cmdUploadForumThread);
            this.tbpForumThread.Controls.Add(this.dgForumThread);
            this.tbpForumThread.Location = new System.Drawing.Point(4, 22);
            this.tbpForumThread.Name = "tbpForumThread";
            this.tbpForumThread.Padding = new System.Windows.Forms.Padding(3);
            this.tbpForumThread.Size = new System.Drawing.Size(676, 170);
            this.tbpForumThread.TabIndex = 0;
            this.tbpForumThread.Text = "Forum Thread";
            this.tbpForumThread.UseVisualStyleBackColor = true;
            // 
            // cmdAssignForumThread
            // 
            this.cmdAssignForumThread.Location = new System.Drawing.Point(342, 92);
            this.cmdAssignForumThread.Name = "cmdAssignForumThread";
            this.cmdAssignForumThread.Size = new System.Drawing.Size(146, 23);
            this.cmdAssignForumThread.TabIndex = 23;
            this.cmdAssignForumThread.Text = "Assign Parent Page";
            this.cmdAssignForumThread.UseVisualStyleBackColor = true;
            this.cmdAssignForumThread.Click += new System.EventHandler(this.cmdAssignParentPage_Click);
            // 
            // txtForumPostNoOfRows
            // 
            this.txtForumPostNoOfRows.Enabled = false;
            this.txtForumPostNoOfRows.Location = new System.Drawing.Point(82, 35);
            this.txtForumPostNoOfRows.Name = "txtForumPostNoOfRows";
            this.txtForumPostNoOfRows.Size = new System.Drawing.Size(63, 20);
            this.txtForumPostNoOfRows.TabIndex = 22;
            // 
            // lblForumPostNoOfRows
            // 
            this.lblForumPostNoOfRows.AutoSize = true;
            this.lblForumPostNoOfRows.Location = new System.Drawing.Point(14, 40);
            this.lblForumPostNoOfRows.Name = "lblForumPostNoOfRows";
            this.lblForumPostNoOfRows.Size = new System.Drawing.Size(61, 13);
            this.lblForumPostNoOfRows.TabIndex = 21;
            this.lblForumPostNoOfRows.Text = "No of rows:";
            // 
            // lblForumPostOrderBy
            // 
            this.lblForumPostOrderBy.AutoSize = true;
            this.lblForumPostOrderBy.Location = new System.Drawing.Point(436, 12);
            this.lblForumPostOrderBy.Name = "lblForumPostOrderBy";
            this.lblForumPostOrderBy.Size = new System.Drawing.Size(48, 13);
            this.lblForumPostOrderBy.TabIndex = 20;
            this.lblForumPostOrderBy.Text = "Order By";
            // 
            // cmbForumPostOrderBy
            // 
            this.cmbForumPostOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForumPostOrderBy.FormattingEnabled = true;
            this.cmbForumPostOrderBy.Items.AddRange(new object[] {
            "PID",
            "FID",
            "TID",
            "Post Date"});
            this.cmbForumPostOrderBy.Location = new System.Drawing.Point(490, 7);
            this.cmbForumPostOrderBy.Name = "cmbForumPostOrderBy";
            this.cmbForumPostOrderBy.Size = new System.Drawing.Size(121, 21);
            this.cmbForumPostOrderBy.TabIndex = 19;
            // 
            // txtForumThreadSFID
            // 
            this.txtForumThreadSFID.Location = new System.Drawing.Point(319, 9);
            this.txtForumThreadSFID.Name = "txtForumThreadSFID";
            this.txtForumThreadSFID.Size = new System.Drawing.Size(100, 20);
            this.txtForumThreadSFID.TabIndex = 18;
            // 
            // lblForumThreadSFID
            // 
            this.lblForumThreadSFID.AutoSize = true;
            this.lblForumThreadSFID.Location = new System.Drawing.Point(288, 12);
            this.lblForumThreadSFID.Name = "lblForumThreadSFID";
            this.lblForumThreadSFID.Size = new System.Drawing.Size(31, 13);
            this.lblForumThreadSFID.TabIndex = 17;
            this.lblForumThreadSFID.Text = "SFID";
            // 
            // txtForumThreadFID
            // 
            this.txtForumThreadFID.Location = new System.Drawing.Point(182, 9);
            this.txtForumThreadFID.Name = "txtForumThreadFID";
            this.txtForumThreadFID.Size = new System.Drawing.Size(100, 20);
            this.txtForumThreadFID.TabIndex = 16;
            // 
            // lblForumThreadFID
            // 
            this.lblForumThreadFID.AutoSize = true;
            this.lblForumThreadFID.Location = new System.Drawing.Point(152, 12);
            this.lblForumThreadFID.Name = "lblForumThreadFID";
            this.lblForumThreadFID.Size = new System.Drawing.Size(24, 13);
            this.lblForumThreadFID.TabIndex = 15;
            this.lblForumThreadFID.Text = "FID";
            // 
            // txtForumThreadID
            // 
            this.txtForumThreadID.Location = new System.Drawing.Point(45, 9);
            this.txtForumThreadID.Name = "txtForumThreadID";
            this.txtForumThreadID.Size = new System.Drawing.Size(100, 20);
            this.txtForumThreadID.TabIndex = 14;
            // 
            // lblForumThreadID
            // 
            this.lblForumThreadID.AutoSize = true;
            this.lblForumThreadID.Location = new System.Drawing.Point(14, 12);
            this.lblForumThreadID.Name = "lblForumThreadID";
            this.lblForumThreadID.Size = new System.Drawing.Size(25, 13);
            this.lblForumThreadID.TabIndex = 13;
            this.lblForumThreadID.Text = "TID";
            // 
            // cmdClearAllForumThread
            // 
            this.cmdClearAllForumThread.Location = new System.Drawing.Point(171, 61);
            this.cmdClearAllForumThread.Name = "cmdClearAllForumThread";
            this.cmdClearAllForumThread.Size = new System.Drawing.Size(75, 23);
            this.cmdClearAllForumThread.TabIndex = 12;
            this.cmdClearAllForumThread.Text = "Clear All";
            this.cmdClearAllForumThread.UseVisualStyleBackColor = true;
            this.cmdClearAllForumThread.Click += new System.EventHandler(this.cmdClearAllForumTopics_Click);
            // 
            // cmdSelectAllForumThread
            // 
            this.cmdSelectAllForumThread.Location = new System.Drawing.Point(90, 61);
            this.cmdSelectAllForumThread.Name = "cmdSelectAllForumThread";
            this.cmdSelectAllForumThread.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectAllForumThread.TabIndex = 11;
            this.cmdSelectAllForumThread.Text = "Select All";
            this.cmdSelectAllForumThread.UseVisualStyleBackColor = true;
            this.cmdSelectAllForumThread.Click += new System.EventHandler(this.cmdSelectAllForumTopics_Click);
            // 
            // txtForumThreadApiUrl
            // 
            this.txtForumThreadApiUrl.Location = new System.Drawing.Point(61, 94);
            this.txtForumThreadApiUrl.Name = "txtForumThreadApiUrl";
            this.txtForumThreadApiUrl.Size = new System.Drawing.Size(275, 20);
            this.txtForumThreadApiUrl.TabIndex = 10;
            this.txtForumThreadApiUrl.Text = "rest/api/content";
            // 
            // lblForumThreadApiUrl
            // 
            this.lblForumThreadApiUrl.AutoSize = true;
            this.lblForumThreadApiUrl.Location = new System.Drawing.Point(11, 97);
            this.lblForumThreadApiUrl.Name = "lblForumThreadApiUrl";
            this.lblForumThreadApiUrl.Size = new System.Drawing.Size(38, 13);
            this.lblForumThreadApiUrl.TabIndex = 9;
            this.lblForumThreadApiUrl.Text = "Api Url";
            // 
            // cmdLoadForumThread
            // 
            this.cmdLoadForumThread.Location = new System.Drawing.Point(9, 61);
            this.cmdLoadForumThread.Name = "cmdLoadForumThread";
            this.cmdLoadForumThread.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadForumThread.TabIndex = 4;
            this.cmdLoadForumThread.Text = "Load";
            this.cmdLoadForumThread.UseVisualStyleBackColor = true;
            this.cmdLoadForumThread.Click += new System.EventHandler(this.cmdLoadForumTopics_Click);
            // 
            // tbpUsers
            // 
            this.tbpUsers.Controls.Add(this.txtApiUserUrl);
            this.tbpUsers.Controls.Add(this.label2);
            this.tbpUsers.Controls.Add(this.cmdGetUsers);
            this.tbpUsers.Controls.Add(this.txtUsersNoOfRows);
            this.tbpUsers.Controls.Add(this.lblUsersNoOfRows);
            this.tbpUsers.Controls.Add(this.cmdClearAllUsers);
            this.tbpUsers.Controls.Add(this.cmdSelectAllUsers);
            this.tbpUsers.Controls.Add(this.cmdLoadUsers);
            this.tbpUsers.Controls.Add(this.label1);
            this.tbpUsers.Controls.Add(this.comboBox1);
            this.tbpUsers.Controls.Add(this.txtEmail);
            this.tbpUsers.Controls.Add(this.lblEmail);
            this.tbpUsers.Controls.Add(this.txtUserID);
            this.tbpUsers.Controls.Add(this.lblUserID);
            this.tbpUsers.Controls.Add(this.txtUserName);
            this.tbpUsers.Controls.Add(this.lblUserName);
            this.tbpUsers.Controls.Add(this.dgUsers);
            this.tbpUsers.Location = new System.Drawing.Point(4, 22);
            this.tbpUsers.Name = "tbpUsers";
            this.tbpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsers.Size = new System.Drawing.Size(676, 170);
            this.tbpUsers.TabIndex = 4;
            this.tbpUsers.Text = "Users";
            this.tbpUsers.UseVisualStyleBackColor = true;
            // 
            // txtApiUserUrl
            // 
            this.txtApiUserUrl.Location = new System.Drawing.Point(62, 91);
            this.txtApiUserUrl.Name = "txtApiUserUrl";
            this.txtApiUserUrl.Size = new System.Drawing.Size(275, 20);
            this.txtApiUserUrl.TabIndex = 30;
            this.txtApiUserUrl.Text = "rest/api/user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Api Url";
            // 
            // cmdGetUsers
            // 
            this.cmdGetUsers.Location = new System.Drawing.Point(344, 89);
            this.cmdGetUsers.Name = "cmdGetUsers";
            this.cmdGetUsers.Size = new System.Drawing.Size(75, 23);
            this.cmdGetUsers.TabIndex = 28;
            this.cmdGetUsers.Text = "Get Users";
            this.cmdGetUsers.UseVisualStyleBackColor = true;
            this.cmdGetUsers.Click += new System.EventHandler(this.cmdGetUsers_Click);
            // 
            // txtUsersNoOfRows
            // 
            this.txtUsersNoOfRows.Enabled = false;
            this.txtUsersNoOfRows.Location = new System.Drawing.Point(78, 34);
            this.txtUsersNoOfRows.Name = "txtUsersNoOfRows";
            this.txtUsersNoOfRows.Size = new System.Drawing.Size(63, 20);
            this.txtUsersNoOfRows.TabIndex = 27;
            // 
            // lblUsersNoOfRows
            // 
            this.lblUsersNoOfRows.AutoSize = true;
            this.lblUsersNoOfRows.Location = new System.Drawing.Point(10, 39);
            this.lblUsersNoOfRows.Name = "lblUsersNoOfRows";
            this.lblUsersNoOfRows.Size = new System.Drawing.Size(61, 13);
            this.lblUsersNoOfRows.TabIndex = 26;
            this.lblUsersNoOfRows.Text = "No of rows:";
            // 
            // cmdClearAllUsers
            // 
            this.cmdClearAllUsers.Location = new System.Drawing.Point(173, 62);
            this.cmdClearAllUsers.Name = "cmdClearAllUsers";
            this.cmdClearAllUsers.Size = new System.Drawing.Size(75, 23);
            this.cmdClearAllUsers.TabIndex = 25;
            this.cmdClearAllUsers.Text = "Clear All";
            this.cmdClearAllUsers.UseVisualStyleBackColor = true;
            this.cmdClearAllUsers.Click += new System.EventHandler(this.cmdClearAllUsers_Click);
            // 
            // cmdSelectAllUsers
            // 
            this.cmdSelectAllUsers.Location = new System.Drawing.Point(92, 62);
            this.cmdSelectAllUsers.Name = "cmdSelectAllUsers";
            this.cmdSelectAllUsers.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectAllUsers.TabIndex = 24;
            this.cmdSelectAllUsers.Text = "Select All";
            this.cmdSelectAllUsers.UseVisualStyleBackColor = true;
            this.cmdSelectAllUsers.Click += new System.EventHandler(this.cmdSelectAllUsers_Click);
            // 
            // cmdLoadUsers
            // 
            this.cmdLoadUsers.Location = new System.Drawing.Point(11, 62);
            this.cmdLoadUsers.Name = "cmdLoadUsers";
            this.cmdLoadUsers.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadUsers.TabIndex = 23;
            this.cmdLoadUsers.Text = "Load";
            this.cmdLoadUsers.UseVisualStyleBackColor = true;
            this.cmdLoadUsers.Click += new System.EventHandler(this.cmdLoadUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Order By";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PID",
            "FID",
            "TID",
            "Post Date"});
            this.comboBox1.Location = new System.Drawing.Point(549, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(221, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(182, 11);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(385, 7);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 4;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(328, 10);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "User ID";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(78, 8);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // dgUsers
            // 
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(3, 118);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.Size = new System.Drawing.Size(670, 72);
            this.dgUsers.TabIndex = 0;
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colErrorMessage,
            this.colDetails});
            this.lvEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new System.Drawing.Point(0, 330);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(684, 131);
            this.lvEvents.TabIndex = 0;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // colErrorMessage
            // 
            this.colErrorMessage.Text = "Event Message";
            this.colErrorMessage.Width = 163;
            // 
            // colDetails
            // 
            this.colDetails.Text = "Details";
            this.colDetails.Width = 504;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(149, 16);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(392, 20);
            this.txtConnectionString.TabIndex = 5;
            this.txtConnectionString.Text = "server=localhost;database=cmsforum;uid=root;pwd=M@h@dev10rd;";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(149, 44);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(102, 23);
            this.cmdConnect.TabIndex = 6;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(14, 19);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(129, 13);
            this.lblConnectionString.TabIndex = 7;
            this.lblConnectionString.Text = "MySQL Connection String";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(105, 79);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 8;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(149, 76);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(204, 20);
            this.txtServer.TabIndex = 9;
            this.txtServer.Text = "http://localhost:8090";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(360, 79);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(38, 13);
            this.lblSpace.TabIndex = 10;
            this.lblSpace.Text = "Space";
            // 
            // txtSpace
            // 
            this.txtSpace.Location = new System.Drawing.Point(401, 76);
            this.txtSpace.Name = "txtSpace";
            this.txtSpace.Size = new System.Drawing.Size(100, 20);
            this.txtSpace.TabIndex = 11;
            this.txtSpace.Text = "DEMO";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(401, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 15;
            this.txtPass.Text = "LImbu1979";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(360, 105);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(30, 13);
            this.lblPass.TabIndex = 14;
            this.lblPass.Text = "Pass";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(149, 102);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(204, 20);
            this.txtAdmin.TabIndex = 13;
            this.txtAdmin.Text = "admin";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(105, 105);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "Admin";
            // 
            // pbUploadForumThread
            // 
            this.pbUploadForumThread.Location = new System.Drawing.Point(342, 61);
            this.pbUploadForumThread.Name = "pbUploadForumThread";
            this.pbUploadForumThread.Size = new System.Drawing.Size(227, 23);
            this.pbUploadForumThread.TabIndex = 24;
            // 
            // lblForumThreadProgressCount
            // 
            this.lblForumThreadProgressCount.AutoSize = true;
            this.lblForumThreadProgressCount.Location = new System.Drawing.Point(576, 67);
            this.lblForumThreadProgressCount.Name = "lblForumThreadProgressCount";
            this.lblForumThreadProgressCount.Size = new System.Drawing.Size(0, 13);
            this.lblForumThreadProgressCount.TabIndex = 25;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.txtSpace);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.tbcForum);
            this.Name = "frmMain";
            this.Text = "Forum Data Migration";
            ((System.ComponentModel.ISupportInitialize)(this.dgForumThread)).EndInit();
            this.tbcForum.ResumeLayout(false);
            this.tbpForum.ResumeLayout(false);
            this.tbpForum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgForum)).EndInit();
            this.tbpSubForum.ResumeLayout(false);
            this.tbpSubForum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubForum)).EndInit();
            this.tbpForumThread.ResumeLayout(false);
            this.tbpForumThread.PerformLayout();
            this.tbpUsers.ResumeLayout(false);
            this.tbpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgForumThread;
        private System.Windows.Forms.Button cmdUploadForumThread;
        private System.Windows.Forms.TabControl tbcForum;
        private System.Windows.Forms.TabPage tbpForumThread;
        private System.Windows.Forms.TabPage tbpSubForum;
        private System.Windows.Forms.Button cmdUploadSubForum;
        private System.Windows.Forms.DataGridView dgSubForum;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdLoadForumThread;
        private System.Windows.Forms.Button cmdLoadSubForum;
        private System.Windows.Forms.TextBox txtForumThreadApiUrl;
        private System.Windows.Forms.Label lblForumThreadApiUrl;
        private System.Windows.Forms.TextBox txtSubForumApiUrl;
        private System.Windows.Forms.Label lblSubForumApiUrl;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.Button cmdClearAllForumThread;
        private System.Windows.Forms.Button cmdSelectAllForumThread;
        private System.Windows.Forms.Button cmdClearAllSubForum;
        private System.Windows.Forms.Button cmdSelectAllSubForum;
        private System.Windows.Forms.TextBox txtForumThreadSFID;
        private System.Windows.Forms.Label lblForumThreadSFID;
        private System.Windows.Forms.TextBox txtForumThreadFID;
        private System.Windows.Forms.Label lblForumThreadFID;
        private System.Windows.Forms.TextBox txtForumThreadID;
        private System.Windows.Forms.Label lblForumThreadID;
        private System.Windows.Forms.Label lblForumPostOrderBy;
        private System.Windows.Forms.ComboBox cmbForumPostOrderBy;
        private System.Windows.Forms.TextBox txtForumPostNoOfRows;
        private System.Windows.Forms.Label lblForumPostNoOfRows;
        private System.Windows.Forms.TextBox txtForumThreadNoOfRows;
        private System.Windows.Forms.Label lblForumThreadNoOfRows;
        private System.Windows.Forms.Label lblForumThreadOrderBy;
        private System.Windows.Forms.ComboBox cmbForumThreadOrderBy;
        private System.Windows.Forms.TextBox txtSubForumID;
        private System.Windows.Forms.Label lblSubForumID;
        private System.Windows.Forms.TextBox txtSubForumFID;
        private System.Windows.Forms.Label lblSubForumFID;
        private System.Windows.Forms.TabPage tbpForum;
        private System.Windows.Forms.DataGridView dgForum;
        private System.Windows.Forms.TextBox txtForumApiUrl;
        private System.Windows.Forms.Label lblForumApiUrl;
        private System.Windows.Forms.Button cmdForumUpload;
        private System.Windows.Forms.TextBox txtForumNoOfRows;
        private System.Windows.Forms.Label lblForumNoOfRows;
        private System.Windows.Forms.Label lblForumOrderBy;
        private System.Windows.Forms.ComboBox cmbForumOrderBy;
        private System.Windows.Forms.TextBox txtForumID;
        private System.Windows.Forms.Label lblForumID;
        private System.Windows.Forms.Button cmdClearAllForum;
        private System.Windows.Forms.Button cmdSelectAllForum;
        private System.Windows.Forms.Button cmdLoadForum;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader colErrorMessage;
        private System.Windows.Forms.ColumnHeader colDetails;
        private System.Windows.Forms.Button cmdAssignForumThread;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.TextBox txtSpace;
        private System.Windows.Forms.Button cmdAssignSubForum;
        private System.Windows.Forms.TabPage tbpUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.TextBox txtUsersNoOfRows;
        private System.Windows.Forms.Label lblUsersNoOfRows;
        private System.Windows.Forms.Button cmdClearAllUsers;
        private System.Windows.Forms.Button cmdSelectAllUsers;
        private System.Windows.Forms.Button cmdLoadUsers;
        private System.Windows.Forms.TextBox txtApiUserUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGetUsers;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ProgressBar pbUploadForumThread;
        private System.Windows.Forms.Label lblForumThreadProgressCount;
    }
}

