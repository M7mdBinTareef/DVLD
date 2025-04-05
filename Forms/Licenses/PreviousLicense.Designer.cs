namespace DVLD.Forms.Licenses
{
    partial class PreviousLicense
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
            System.Windows.Forms.TabPage Local;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviousLicense));
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilterd = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FilterdBox = new System.Windows.Forms.TextBox();
            this.cbFilterd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InterNational = new System.Windows.Forms.TabPage();
            this.Dgv2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lRecNumber = new System.Windows.Forms.Label();
            this.lRecords = new System.Windows.Forms.Label();
            this.viewDetails1 = new DVLD.ViewDetails();
            Local = new System.Windows.Forms.TabPage();
            Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFilterd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.InterNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // Local
            // 
            Local.Controls.Add(this.Dgv1);
            Local.Controls.Add(this.label3);
            Local.Location = new System.Drawing.Point(4, 25);
            Local.Name = "Local";
            Local.Padding = new System.Windows.Forms.Padding(3);
            Local.Size = new System.Drawing.Size(1183, 293);
            Local.TabIndex = 0;
            Local.Text = "Local License Info";
            Local.UseVisualStyleBackColor = true;
            // 
            // Dgv1
            // 
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.ContextMenuStrip = this.contextMenuStrip1;
            this.Dgv1.Location = new System.Drawing.Point(19, 43);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersWidth = 51;
            this.Dgv1.RowTemplate.Height = 24;
            this.Dgv1.Size = new System.Drawing.Size(1149, 233);
            this.Dgv1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseInfoToolStripMenuItem.Image")));
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Local License History:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(581, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "License History";
            // 
            // gbFilterd
            // 
            this.gbFilterd.Controls.Add(this.button2);
            this.gbFilterd.Controls.Add(this.button1);
            this.gbFilterd.Controls.Add(this.FilterdBox);
            this.gbFilterd.Controls.Add(this.cbFilterd);
            this.gbFilterd.Controls.Add(this.label2);
            this.gbFilterd.Location = new System.Drawing.Point(286, 78);
            this.gbFilterd.Name = "gbFilterd";
            this.gbFilterd.Size = new System.Drawing.Size(953, 80);
            this.gbFilterd.TabIndex = 3;
            this.gbFilterd.TabStop = false;
            this.gbFilterd.Text = "Filter";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(702, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(745, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FilterdBox
            // 
            this.FilterdBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterdBox.Location = new System.Drawing.Point(421, 32);
            this.FilterdBox.Name = "FilterdBox";
            this.FilterdBox.Size = new System.Drawing.Size(247, 30);
            this.FilterdBox.TabIndex = 2;
            // 
            // cbFilterd
            // 
            this.cbFilterd.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterd.FormattingEnabled = true;
            this.cbFilterd.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFilterd.Location = new System.Drawing.Point(213, 32);
            this.cbFilterd.Name = "cbFilterd";
            this.cbFilterd.Size = new System.Drawing.Size(202, 30);
            this.cbFilterd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter By:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1227, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(Local);
            this.tabControl1.Controls.Add(this.InterNational);
            this.tabControl1.Location = new System.Drawing.Point(6, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 322);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // InterNational
            // 
            this.InterNational.Controls.Add(this.Dgv2);
            this.InterNational.Controls.Add(this.label4);
            this.InterNational.Location = new System.Drawing.Point(4, 25);
            this.InterNational.Name = "InterNational";
            this.InterNational.Padding = new System.Windows.Forms.Padding(3);
            this.InterNational.Size = new System.Drawing.Size(1183, 293);
            this.InterNational.TabIndex = 1;
            this.InterNational.Text = "InterNational License Info";
            this.InterNational.UseVisualStyleBackColor = true;
            // 
            // Dgv2
            // 
            this.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv2.Location = new System.Drawing.Point(19, 42);
            this.Dgv2.Name = "Dgv2";
            this.Dgv2.RowHeadersWidth = 51;
            this.Dgv2.RowTemplate.Height = 24;
            this.Dgv2.Size = new System.Drawing.Size(1149, 233);
            this.Dgv2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "international License History:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1106, 829);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lRecNumber
            // 
            this.lRecNumber.AutoSize = true;
            this.lRecNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecNumber.Location = new System.Drawing.Point(126, 845);
            this.lRecNumber.Name = "lRecNumber";
            this.lRecNumber.Size = new System.Drawing.Size(17, 18);
            this.lRecNumber.TabIndex = 17;
            this.lRecNumber.Text = "0";
            // 
            // lRecords
            // 
            this.lRecords.AutoSize = true;
            this.lRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecords.Location = new System.Drawing.Point(22, 844);
            this.lRecords.Name = "lRecords";
            this.lRecords.Size = new System.Drawing.Size(107, 20);
            this.lRecords.TabIndex = 16;
            this.lRecords.Text = "# Records: ";
            // 
            // viewDetails1
            // 
            this.viewDetails1.Location = new System.Drawing.Point(273, 173);
            this.viewDetails1.Name = "viewDetails1";
            this.viewDetails1.Size = new System.Drawing.Size(980, 297);
            this.viewDetails1.TabIndex = 2;
            // 
            // PreviousLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 884);
            this.Controls.Add(this.lRecNumber);
            this.Controls.Add(this.lRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFilterd);
            this.Controls.Add(this.viewDetails1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PreviousLicense";
            this.Text = "PreviousLicense";
            this.Load += new System.EventHandler(this.PreviousLicense_Load);
            Local.ResumeLayout(false);
            Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFilterd.ResumeLayout(false);
            this.gbFilterd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.InterNational.ResumeLayout(false);
            this.InterNational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ViewDetails viewDetails1;
        private System.Windows.Forms.GroupBox gbFilterd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FilterdBox;
        private System.Windows.Forms.ComboBox cbFilterd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage InterNational;
        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lRecNumber;
        private System.Windows.Forms.Label lRecords;
        private System.Windows.Forms.DataGridView Dgv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}