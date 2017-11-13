namespace reportCard
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroToolTip3 = new MetroFramework.Components.MetroToolTip();
            this.metroToolTip2 = new MetroFramework.Components.MetroToolTip();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.UserType = new MetroFramework.Controls.MetroComboBox();
            this.lblPortno = new MetroFramework.Controls.MetroLabel();
            this.txtPortNo = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.lblDatabaseName = new MetroFramework.Controls.MetroLabel();
            this.txtDB = new MetroFramework.Controls.MetroTextBox();
            this.lblServerName = new MetroFramework.Controls.MetroLabel();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtcSettings.SuspendLayout();
            this.mtpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip3
            // 
            this.metroToolTip3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip3.StyleManager = null;
            this.metroToolTip3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroToolTip2
            // 
            this.metroToolTip2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip2.StyleManager = null;
            this.metroToolTip2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(17, 242);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(188, 26);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "&Test connection";
            this.metroToolTip2.SetToolTip(this.btnTest, "Test Server Connection");
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // UserType
            // 
            this.UserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserType.FormattingEnabled = true;
            this.UserType.ItemHeight = 23;
            this.UserType.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.UserType.Location = new System.Drawing.Point(41, 265);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(277, 29);
            this.UserType.TabIndex = 37;
            this.metroToolTip2.SetToolTip(this.UserType, "Select User Role ");
            this.UserType.UseSelectable = true;
            // 
            // lblPortno
            // 
            this.lblPortno.AutoSize = true;
            this.lblPortno.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPortno.Location = new System.Drawing.Point(14, 59);
            this.lblPortno.Name = "lblPortno";
            this.lblPortno.Size = new System.Drawing.Size(49, 15);
            this.lblPortno.TabIndex = 64;
            this.lblPortno.Text = "port no.";
            // 
            // txtPortNo
            // 
            // 
            // 
            // 
            this.txtPortNo.CustomButton.Image = null;
            this.txtPortNo.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtPortNo.CustomButton.Name = "";
            this.txtPortNo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPortNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPortNo.CustomButton.TabIndex = 1;
            this.txtPortNo.CustomButton.Text = "...";
            this.txtPortNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPortNo.CustomButton.UseSelectable = true;
            this.txtPortNo.CustomButton.Visible = false;
            this.txtPortNo.Lines = new string[] {
        "3306"};
            this.txtPortNo.Location = new System.Drawing.Point(17, 78);
            this.txtPortNo.MaxLength = 32767;
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.PasswordChar = '\0';
            this.txtPortNo.PromptText = "port no.";
            this.txtPortNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPortNo.SelectedText = "";
            this.txtPortNo.SelectionLength = 0;
            this.txtPortNo.SelectionStart = 0;
            this.txtPortNo.ShortcutsEnabled = true;
            this.txtPortNo.Size = new System.Drawing.Size(188, 22);
            this.txtPortNo.TabIndex = 6;
            this.txtPortNo.Text = "3306";
            this.txtPortNo.UseSelectable = true;
            this.txtPortNo.WaterMark = "port no.";
            this.txtPortNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPortNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPassword.Location = new System.Drawing.Point(14, 194);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 15);
            this.lblPassword.TabIndex = 63;
            this.lblPassword.Text = "password :";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Text = "...";
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(17, 213);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PromptText = "database password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(188, 22);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMark = "database password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUserName.Location = new System.Drawing.Point(14, 149);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 15);
            this.lblUserName.TabIndex = 62;
            this.lblUserName.Text = "username :";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Text = "...";
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[] {
        "root"};
            this.txtUser.Location = new System.Drawing.Point(17, 168);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PromptText = "database user";
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(188, 22);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "root";
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMark = "database user";
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mtcSettings
            // 
            this.mtcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Location = new System.Drawing.Point(410, 70);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 0;
            this.mtcSettings.Size = new System.Drawing.Size(236, 311);
            this.mtcSettings.TabIndex = 41;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.Controls.Add(this.lblPortno);
            this.mtpConnection.Controls.Add(this.txtPortNo);
            this.mtpConnection.Controls.Add(this.btnTest);
            this.mtpConnection.Controls.Add(this.lblPassword);
            this.mtpConnection.Controls.Add(this.txtPass);
            this.mtpConnection.Controls.Add(this.lblUserName);
            this.mtpConnection.Controls.Add(this.txtUser);
            this.mtpConnection.Controls.Add(this.lblDatabaseName);
            this.mtpConnection.Controls.Add(this.txtDB);
            this.mtpConnection.Controls.Add(this.lblServerName);
            this.mtpConnection.Controls.Add(this.txtServer);
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 38);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(228, 269);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&connection";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDatabaseName.Location = new System.Drawing.Point(14, 104);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(91, 15);
            this.lblDatabaseName.TabIndex = 61;
            this.lblDatabaseName.Text = "database name :";
            // 
            // txtDB
            // 
            // 
            // 
            // 
            this.txtDB.CustomButton.Image = null;
            this.txtDB.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtDB.CustomButton.Name = "";
            this.txtDB.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDB.CustomButton.TabIndex = 1;
            this.txtDB.CustomButton.Text = "...";
            this.txtDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDB.CustomButton.UseSelectable = true;
            this.txtDB.CustomButton.Visible = false;
            this.txtDB.Lines = new string[] {
        "reportcard"};
            this.txtDB.Location = new System.Drawing.Point(17, 123);
            this.txtDB.MaxLength = 32767;
            this.txtDB.Name = "txtDB";
            this.txtDB.PasswordChar = '\0';
            this.txtDB.PromptText = "database name";
            this.txtDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDB.SelectedText = "";
            this.txtDB.SelectionLength = 0;
            this.txtDB.SelectionStart = 0;
            this.txtDB.ShortcutsEnabled = true;
            this.txtDB.Size = new System.Drawing.Size(188, 22);
            this.txtDB.TabIndex = 7;
            this.txtDB.Text = "reportcard";
            this.txtDB.UseSelectable = true;
            this.txtDB.WaterMark = "database name";
            this.txtDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblServerName.Location = new System.Drawing.Point(14, 14);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(75, 15);
            this.lblServerName.TabIndex = 60;
            this.lblServerName.Text = "server name :";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Text = "...";
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.Lines = new string[] {
        "localhost"};
            this.txtServer.Location = new System.Drawing.Point(17, 33);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.PromptText = "server name";
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(188, 22);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "localhost";
            this.txtServer.UseSelectable = true;
            this.txtServer.WaterMark = "server name";
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(74, 240);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(214, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "Enter Correct User Credentilas ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(142, 368);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(122, 23);
            this.metroLink2.TabIndex = 46;
            this.metroLink2.Text = "Change Password";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.Location = new System.Drawing.Point(270, 368);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(75, 23);
            this.metroLink3.TabIndex = 47;
            this.metroLink3.Text = "Login";
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(218, 429);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(239, 19);
            this.metroLabel5.TabIndex = 48;
            this.metroLabel5.Text = "All Rights Reserved: LUANN TECH ";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(41, 92);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(309, 125);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 44;
            this.picture.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 34;
            this.metroLink1.Location = new System.Drawing.Point(571, 24);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 40);
            this.metroLink1.TabIndex = 43;
            this.metroToolTip3.SetToolTip(this.metroLink1, "Close Application");
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(40, 298);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(278, 28);
            this.txtUsername.TabIndex = 38;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(40, 332);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(278, 28);
            this.txtPassword.TabIndex = 39;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 468);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.mtcSettings);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Login";
            this.mtcSettings.ResumeLayout(false);
            this.mtpConnection.ResumeLayout(false);
            this.mtpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Components.MetroToolTip metroToolTip2;
        private MetroFramework.Controls.MetroButton btnTest;
        public MetroFramework.Controls.MetroComboBox UserType;
        private MetroFramework.Controls.MetroLabel lblPortno;
        private MetroFramework.Controls.MetroTextBox txtPortNo;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroLabel lblDatabaseName;
        private MetroFramework.Controls.MetroTextBox txtDB;
        private MetroFramework.Controls.MetroLabel lblServerName;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.PictureBox picture;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}