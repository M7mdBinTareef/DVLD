namespace DVLD
{
    partial class AddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateUser));
            this.lMain = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.TabControl();
            this.Personal = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.viewDetails1 = new DVLD.ViewDetails();
            this.gbFilterd = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FilterdBox = new System.Windows.Forms.TextBox();
            this.cbFilterd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lConfirmss = new System.Windows.Forms.Label();
            this.sa = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.UserInfo.SuspendLayout();
            this.Personal.SuspendLayout();
            this.gbFilterd.SuspendLayout();
            this.tLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lMain
            // 
            this.lMain.AutoSize = true;
            this.lMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lMain.Location = new System.Drawing.Point(496, 43);
            this.lMain.Name = "lMain";
            this.lMain.Size = new System.Drawing.Size(181, 29);
            this.lMain.TabIndex = 6;
            this.lMain.Text = "Add New User";
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.Personal);
            this.UserInfo.Controls.Add(this.tLogin);
            this.UserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfo.Location = new System.Drawing.Point(12, 88);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.SelectedIndex = 0;
            this.UserInfo.Size = new System.Drawing.Size(1230, 584);
            this.UserInfo.TabIndex = 7;
            this.UserInfo.SelectedIndexChanged += new System.EventHandler(this.UserInfo_SelectedIndexChanged);
            // 
            // Personal
            // 
            this.Personal.CausesValidation = false;
            this.Personal.Controls.Add(this.button3);
            this.Personal.Controls.Add(this.viewDetails1);
            this.Personal.Controls.Add(this.gbFilterd);
            this.Personal.Location = new System.Drawing.Point(4, 29);
            this.Personal.Name = "Personal";
            this.Personal.Padding = new System.Windows.Forms.Padding(3);
            this.Personal.Size = new System.Drawing.Size(1222, 551);
            this.Personal.TabIndex = 0;
            this.Personal.Text = "Personal Info";
            this.Personal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1075, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 48);
            this.button3.TabIndex = 59;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewDetails1
            // 
            this.viewDetails1.Location = new System.Drawing.Point(0, 113);
            this.viewDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.viewDetails1.Name = "viewDetails1";
            this.viewDetails1.Size = new System.Drawing.Size(1211, 375);
            this.viewDetails1.TabIndex = 1;
            // 
            // gbFilterd
            // 
            this.gbFilterd.Controls.Add(this.button2);
            this.gbFilterd.Controls.Add(this.button1);
            this.gbFilterd.Controls.Add(this.FilterdBox);
            this.gbFilterd.Controls.Add(this.cbFilterd);
            this.gbFilterd.Controls.Add(this.label1);
            this.gbFilterd.Location = new System.Drawing.Point(15, 28);
            this.gbFilterd.Name = "gbFilterd";
            this.gbFilterd.Size = new System.Drawing.Size(1193, 80);
            this.gbFilterd.TabIndex = 0;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(745, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // tLogin
            // 
            this.tLogin.Controls.Add(this.cbIsActive);
            this.tLogin.Controls.Add(this.pictureBox5);
            this.tLogin.Controls.Add(this.pictureBox4);
            this.tLogin.Controls.Add(this.pictureBox2);
            this.tLogin.Controls.Add(this.pictureBox1);
            this.tLogin.Controls.Add(this.lUserID);
            this.tLogin.Controls.Add(this.label3);
            this.tLogin.Controls.Add(this.lUserName);
            this.tLogin.Controls.Add(this.label2);
            this.tLogin.Controls.Add(this.tbConfirm);
            this.tLogin.Controls.Add(this.tbPassword);
            this.tLogin.Controls.Add(this.lConfirmss);
            this.tLogin.Controls.Add(this.sa);
            this.tLogin.Location = new System.Drawing.Point(4, 29);
            this.tLogin.Name = "tLogin";
            this.tLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tLogin.Size = new System.Drawing.Size(1222, 551);
            this.tLogin.TabIndex = 1;
            this.tLogin.Text = "Login Info";
            this.tLogin.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(308, 354);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(100, 26);
            this.cbIsActive.TabIndex = 21;
            this.cbIsActive.Text = "Is  Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(265, 302);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(265, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(265, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lUserID
            // 
            this.lUserID.AutoSize = true;
            this.lUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserID.Location = new System.Drawing.Point(304, 153);
            this.lUserID.Name = "lUserID";
            this.lUserID.Size = new System.Drawing.Size(19, 20);
            this.lUserID.TabIndex = 15;
            this.lUserID.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "UserID:";
            // 
            // lUserName
            // 
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(308, 194);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(169, 27);
            this.lUserName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "UserName:";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.Location = new System.Drawing.Point(308, 302);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '*';
            this.tbConfirm.Size = new System.Drawing.Size(169, 27);
            this.tbConfirm.TabIndex = 11;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(308, 249);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(169, 27);
            this.tbPassword.TabIndex = 10;
            // 
            // lConfirmss
            // 
            this.lConfirmss.AutoSize = true;
            this.lConfirmss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirmss.Location = new System.Drawing.Point(54, 302);
            this.lConfirmss.Name = "lConfirmss";
            this.lConfirmss.Size = new System.Drawing.Size(169, 20);
            this.lConfirmss.TabIndex = 9;
            this.lConfirmss.Text = "Confirm Password:";
            // 
            // sa
            // 
            this.sa.AutoSize = true;
            this.sa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa.Location = new System.Drawing.Point(126, 249);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(97, 20);
            this.sa.TabIndex = 8;
            this.sa.Text = "Password:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(943, 695);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 48);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1091, 695);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 48);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 751);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.UserInfo);
            this.Controls.Add(this.lMain);
            this.Name = "AddUpdateUser";
            this.Text = "AddUpdateUser";
            this.UserInfo.ResumeLayout(false);
            this.Personal.ResumeLayout(false);
            this.gbFilterd.ResumeLayout(false);
            this.gbFilterd.PerformLayout();
            this.tLogin.ResumeLayout(false);
            this.tLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMain;
        private System.Windows.Forms.TabControl UserInfo;
        private System.Windows.Forms.TabPage Personal;
        private System.Windows.Forms.TabPage tLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbFilterd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterd;
        private System.Windows.Forms.TextBox FilterdBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lConfirmss;
        private System.Windows.Forms.Label sa;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ViewDetails viewDetails1;
    }
}