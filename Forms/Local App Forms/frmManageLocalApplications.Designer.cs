namespace DVLD.Forms
{
    partial class frmManageLocalApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalApplications));
            this.Filterdtb = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lRecNumber = new System.Windows.Forms.Label();
            this.lRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.PMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Canceled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Test = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lMange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.PMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Filterdtb
            // 
            this.Filterdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterdtb.Location = new System.Drawing.Point(335, 234);
            this.Filterdtb.Name = "Filterdtb";
            this.Filterdtb.Size = new System.Drawing.Size(188, 27);
            this.Filterdtb.TabIndex = 20;
            this.Filterdtb.Visible = false;
            this.Filterdtb.TextChanged += new System.EventHandler(this.Filterdtb_TextChanged);
            // 
            // cb1
            // 
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "None",
            "LDLApp",
            "NationalNo",
            "FullName"});
            this.cb1.Location = new System.Drawing.Point(141, 233);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(188, 28);
            this.cb1.TabIndex = 19;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fiterd By  : ";
            // 
            // lRecNumber
            // 
            this.lRecNumber.AutoSize = true;
            this.lRecNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecNumber.Location = new System.Drawing.Point(112, 662);
            this.lRecNumber.Name = "lRecNumber";
            this.lRecNumber.Size = new System.Drawing.Size(17, 18);
            this.lRecNumber.TabIndex = 17;
            this.lRecNumber.Text = "0";
            // 
            // lRecords
            // 
            this.lRecords.AutoSize = true;
            this.lRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecords.Location = new System.Drawing.Point(8, 661);
            this.lRecords.Name = "lRecords";
            this.lRecords.Size = new System.Drawing.Size(107, 20);
            this.lRecords.TabIndex = 16;
            this.lRecords.Text = "# Records: ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1414, 646);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1474, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Dgv1
            // 
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.ContextMenuStrip = this.PMenu;
            this.Dgv1.Location = new System.Drawing.Point(12, 279);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersWidth = 51;
            this.Dgv1.RowTemplate.Height = 24;
            this.Dgv1.Size = new System.Drawing.Size(1535, 361);
            this.Dgv1.TabIndex = 13;
            // 
            // PMenu
            // 
            this.PMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editApplicatToolStripMenuItem,
            this.toolStripSeparator5,
            this.Canceled,
            this.toolStripSeparator1,
            this.Test,
            this.toolStripSeparator2,
            this.IssueLicense,
            this.toolStripSeparator3,
            this.showLicenses,
            this.toolStripSeparator4,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(309, 344);
            this.PMenu.Opening += new System.ComponentModel.CancelEventHandler(this.PMenu_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(305, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editApplicatToolStripMenuItem
            // 
            this.editApplicatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicatToolStripMenuItem.Image")));
            this.editApplicatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicatToolStripMenuItem.Name = "editApplicatToolStripMenuItem";
            this.editApplicatToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.editApplicatToolStripMenuItem.Text = "Edit Application";
            this.editApplicatToolStripMenuItem.Click += new System.EventHandler(this.editApplicatToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(305, 6);
            // 
            // Canceled
            // 
            this.Canceled.Image = ((System.Drawing.Image)(resources.GetObject("Canceled.Image")));
            this.Canceled.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Canceled.Name = "Canceled";
            this.Canceled.Size = new System.Drawing.Size(308, 38);
            this.Canceled.Text = "Canceled";
            this.Canceled.Click += new System.EventHandler(this.canceledToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(305, 6);
            // 
            // Test
            // 
            this.Test.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schduleVisionTest,
            this.schduleWrittenTest,
            this.schduleStreetTest});
            this.Test.Image = ((System.Drawing.Image)(resources.GetObject("Test.Image")));
            this.Test.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(308, 38);
            this.Test.Text = "Schdule Test";
            // 
            // schduleVisionTest
            // 
            this.schduleVisionTest.Image = ((System.Drawing.Image)(resources.GetObject("schduleVisionTest.Image")));
            this.schduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schduleVisionTest.Name = "schduleVisionTest";
            this.schduleVisionTest.Size = new System.Drawing.Size(239, 38);
            this.schduleVisionTest.Text = "Schdule Vision Test";
            this.schduleVisionTest.Click += new System.EventHandler(this.schduleVisionTest_Click);
            // 
            // schduleWrittenTest
            // 
            this.schduleWrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("schduleWrittenTest.Image")));
            this.schduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schduleWrittenTest.Name = "schduleWrittenTest";
            this.schduleWrittenTest.Size = new System.Drawing.Size(239, 38);
            this.schduleWrittenTest.Text = "Schdule Written Test";
            this.schduleWrittenTest.Click += new System.EventHandler(this.schduleWrittenTest_Click);
            // 
            // schduleStreetTest
            // 
            this.schduleStreetTest.Image = ((System.Drawing.Image)(resources.GetObject("schduleStreetTest.Image")));
            this.schduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schduleStreetTest.Name = "schduleStreetTest";
            this.schduleStreetTest.Size = new System.Drawing.Size(239, 38);
            this.schduleStreetTest.Text = "Schdule Street Test";
            this.schduleStreetTest.Click += new System.EventHandler(this.schduleStreetTest_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(305, 6);
            // 
            // IssueLicense
            // 
            this.IssueLicense.Image = ((System.Drawing.Image)(resources.GetObject("IssueLicense.Image")));
            this.IssueLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueLicense.Name = "IssueLicense";
            this.IssueLicense.Size = new System.Drawing.Size(308, 38);
            this.IssueLicense.Text = "Issue Driving License (First Time)";
            this.IssueLicense.Click += new System.EventHandler(this.IssueLicense_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // showLicenses
            // 
            this.showLicenses.Image = ((System.Drawing.Image)(resources.GetObject("showLicenses.Image")));
            this.showLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenses.Name = "showLicenses";
            this.showLicenses.Size = new System.Drawing.Size(308, 38);
            this.showLicenses.Text = "Show License";
            this.showLicenses.Click += new System.EventHandler(this.showLicensesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(305, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(691, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lMange
            // 
            this.lMange.AutoSize = true;
            this.lMange.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMange.ForeColor = System.Drawing.Color.Red;
            this.lMange.Location = new System.Drawing.Point(498, 170);
            this.lMange.Name = "lMange";
            this.lMange.Size = new System.Drawing.Size(539, 38);
            this.lMange.TabIndex = 11;
            this.lMange.Text = "Local Driving License  Application";
            // 
            // frmManageLocalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 711);
            this.Controls.Add(this.Filterdtb);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRecNumber);
            this.Controls.Add(this.lRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lMange);
            this.Name = "frmManageLocalApplications";
            this.Text = "frmManageLocalApplications";
            this.Load += new System.EventHandler(this.frmManageLocalApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.PMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Filterdtb;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lRecNumber;
        private System.Windows.Forms.Label lRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.ContextMenuStrip PMenu;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Test;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lMange;
        private System.Windows.Forms.ToolStripMenuItem Canceled;
        private System.Windows.Forms.ToolStripMenuItem IssueLicense;
        private System.Windows.Forms.ToolStripMenuItem showLicenses;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editApplicatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem schduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem schduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem schduleStreetTest;
    }
}