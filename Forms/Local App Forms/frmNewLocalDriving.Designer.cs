namespace DVLD.Forms
{
    partial class frmNewLocalDriving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewLocalDriving));
            this.LDLapp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FilterdBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFilterd = new System.Windows.Forms.ComboBox();
            this.viewDetails1 = new DVLD.ViewDetails();
            this.ApplicationInfo = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lMain = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.LDLapp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDLapp
            // 
            this.LDLapp.Controls.Add(this.tabPage1);
            this.LDLapp.Controls.Add(this.ApplicationInfo);
            this.LDLapp.Location = new System.Drawing.Point(1, 54);
            this.LDLapp.Name = "LDLapp";
            this.LDLapp.SelectedIndex = 0;
            this.LDLapp.Size = new System.Drawing.Size(979, 499);
            this.LDLapp.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.viewDetails1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(828, 416);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 48);
            this.btnNext.TabIndex = 60;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.FilterdBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbFilterd);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(611, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilterdBox
            // 
            this.FilterdBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterdBox.Location = new System.Drawing.Point(349, 36);
            this.FilterdBox.Name = "FilterdBox";
            this.FilterdBox.Size = new System.Drawing.Size(247, 30);
            this.FilterdBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(664, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFilterd
            // 
            this.cbFilterd.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterd.FormattingEnabled = true;
            this.cbFilterd.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFilterd.Location = new System.Drawing.Point(141, 36);
            this.cbFilterd.Name = "cbFilterd";
            this.cbFilterd.Size = new System.Drawing.Size(202, 30);
            this.cbFilterd.TabIndex = 1;
            // 
            // viewDetails1
            // 
            this.viewDetails1.Location = new System.Drawing.Point(-4, 118);
            this.viewDetails1.Name = "viewDetails1";
            this.viewDetails1.Size = new System.Drawing.Size(980, 292);
            this.viewDetails1.TabIndex = 0;
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.Controls.Add(this.pictureBox5);
            this.ApplicationInfo.Controls.Add(this.pictureBox4);
            this.ApplicationInfo.Controls.Add(this.pictureBox3);
            this.ApplicationInfo.Controls.Add(this.pictureBox2);
            this.ApplicationInfo.Controls.Add(this.pictureBox1);
            this.ApplicationInfo.Controls.Add(this.lUser);
            this.ApplicationInfo.Controls.Add(this.label6);
            this.ApplicationInfo.Controls.Add(this.Fees);
            this.ApplicationInfo.Controls.Add(this.label4);
            this.ApplicationInfo.Controls.Add(this.cbLC);
            this.ApplicationInfo.Controls.Add(this.label5);
            this.ApplicationInfo.Controls.Add(this.Date);
            this.ApplicationInfo.Controls.Add(this.label3);
            this.ApplicationInfo.Controls.Add(this.dlID);
            this.ApplicationInfo.Controls.Add(this.label2);
            this.ApplicationInfo.Location = new System.Drawing.Point(4, 25);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfo.Size = new System.Drawing.Size(971, 470);
            this.ApplicationInfo.TabIndex = 1;
            this.ApplicationInfo.Text = "Application Info";
            this.ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(269, 293);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(269, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(269, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(269, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.Location = new System.Drawing.Point(297, 293);
            this.lUser.Name = "lUser";
            this.lUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lUser.Size = new System.Drawing.Size(29, 20);
            this.lUser.TabIndex = 9;
            this.lUser.Text = "??";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Created By:";
            // 
            // Fees
            // 
            this.Fees.AutoSize = true;
            this.Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees.Location = new System.Drawing.Point(297, 234);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(29, 20);
            this.Fees.TabIndex = 7;
            this.Fees.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Applicaion Fees:";
            // 
            // cbLC
            // 
            this.cbLC.FormattingEnabled = true;
            this.cbLC.Location = new System.Drawing.Point(301, 172);
            this.cbLC.Name = "cbLC";
            this.cbLC.Size = new System.Drawing.Size(265, 24);
            this.cbLC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "License Class:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(297, 120);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(51, 20);
            this.Date.TabIndex = 3;
            this.Date.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "D.L Applicaion Date:";
            // 
            // dlID
            // 
            this.dlID.AutoSize = true;
            this.dlID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlID.Location = new System.Drawing.Point(297, 66);
            this.dlID.Name = "dlID";
            this.dlID.Size = new System.Drawing.Size(51, 20);
            this.dlID.TabIndex = 1;
            this.dlID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L Applicaion ID:";
            // 
            // lMain
            // 
            this.lMain.AutoSize = true;
            this.lMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lMain.Location = new System.Drawing.Point(239, 22);
            this.lMain.Name = "lMain";
            this.lMain.Size = new System.Drawing.Size(460, 29);
            this.lMain.TabIndex = 7;
            this.lMain.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(694, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 49);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(833, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 48);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewLocalDriving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 611);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lMain);
            this.Controls.Add(this.LDLapp);
            this.Name = "frmNewLocalDriving";
            this.Text = "frmNewLocalDriving";
            this.Load += new System.EventHandler(this.frmNewLocalDriving_Load);
            this.LDLapp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl LDLapp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ApplicationInfo;
        private System.Windows.Forms.Label lMain;
        private ViewDetails viewDetails1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FilterdBox;
        private System.Windows.Forms.ComboBox cbFilterd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbLC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dlID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label label6;
    }
}