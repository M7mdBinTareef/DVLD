namespace DVLD.Forms.Licenses
{
    partial class frmManageInterNationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInterNationalLicense));
            this.lMange = new System.Windows.Forms.Label();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Filterdtb = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lRecNumber = new System.Windows.Forms.Label();
            this.lRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lMange
            // 
            this.lMange.AutoSize = true;
            this.lMange.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMange.ForeColor = System.Drawing.Color.Red;
            this.lMange.Location = new System.Drawing.Point(450, 145);
            this.lMange.Name = "lMange";
            this.lMange.Size = new System.Drawing.Size(646, 38);
            this.lMange.TabIndex = 21;
            this.lMange.Text = "International Driving License  Application";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // showLicenses
            // 
            this.showLicenses.Image = ((System.Drawing.Image)(resources.GetObject("showLicenses.Image")));
            this.showLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenses.Name = "showLicenses";
            this.showLicenses.Size = new System.Drawing.Size(280, 38);
            this.showLicenses.Text = "Show License";
            this.showLicenses.Click += new System.EventHandler(this.showLicenses_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // PMenu
            // 
            this.PMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.showLicenses,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(281, 118);
            // 
            // Filterdtb
            // 
            this.Filterdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterdtb.Location = new System.Drawing.Point(334, 186);
            this.Filterdtb.Name = "Filterdtb";
            this.Filterdtb.Size = new System.Drawing.Size(188, 27);
            this.Filterdtb.TabIndex = 30;
            this.Filterdtb.Visible = false;
            this.Filterdtb.TextChanged += new System.EventHandler(this.Filterdtb_TextChanged);
            // 
            // cb1
            // 
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "None",
            "InternationalLicenseID",
            "ApplicationID",
            "DriverID",
            "IsActive"});
            this.cb1.Location = new System.Drawing.Point(140, 185);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(188, 28);
            this.cb1.TabIndex = 29;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fiterd By  : ";
            // 
            // lRecNumber
            // 
            this.lRecNumber.AutoSize = true;
            this.lRecNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecNumber.Location = new System.Drawing.Point(125, 623);
            this.lRecNumber.Name = "lRecNumber";
            this.lRecNumber.Size = new System.Drawing.Size(17, 18);
            this.lRecNumber.TabIndex = 27;
            this.lRecNumber.Text = "0";
            // 
            // lRecords
            // 
            this.lRecords.AutoSize = true;
            this.lRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecords.Location = new System.Drawing.Point(12, 621);
            this.lRecords.Name = "lRecords";
            this.lRecords.Size = new System.Drawing.Size(107, 20);
            this.lRecords.TabIndex = 26;
            this.lRecords.Text = "# Records: ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1411, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1471, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Dgv1
            // 
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.ContextMenuStrip = this.PMenu;
            this.Dgv1.Location = new System.Drawing.Point(9, 227);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersWidth = 51;
            this.Dgv1.RowTemplate.Height = 24;
            this.Dgv1.Size = new System.Drawing.Size(1535, 361);
            this.Dgv1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageInterNationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 668);
            this.Controls.Add(this.lMange);
            this.Controls.Add(this.Filterdtb);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRecNumber);
            this.Controls.Add(this.lRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmManageInterNationalLicense";
            this.Text = "frmManageInterNationalLicense";
            this.Load += new System.EventHandler(this.frmManageInterNationalLicense_Load);
            this.PMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMange;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenses;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip PMenu;
        private System.Windows.Forms.TextBox Filterdtb;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lRecNumber;
        private System.Windows.Forms.Label lRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}