namespace DVLD.Forms
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.ss = new System.Windows.Forms.Label();
            this.sa = new System.Windows.Forms.Label();
            this.lConfirmss = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.viewUser1 = new DVLD.ViewUser();
            this.viewDetails1 = new DVLD.ViewDetails();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.Location = new System.Drawing.Point(63, 595);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(166, 20);
            this.ss.TabIndex = 2;
            this.ss.Text = "Current Password:";
            // 
            // sa
            // 
            this.sa.AutoSize = true;
            this.sa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa.Location = new System.Drawing.Point(63, 644);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(139, 20);
            this.sa.TabIndex = 3;
            this.sa.Text = "New Password:";
            // 
            // lConfirmss
            // 
            this.lConfirmss.AutoSize = true;
            this.lConfirmss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirmss.Location = new System.Drawing.Point(62, 697);
            this.lConfirmss.Name = "lConfirmss";
            this.lConfirmss.Size = new System.Drawing.Size(169, 20);
            this.lConfirmss.TabIndex = 4;
            this.lConfirmss.Text = "Confirm Password:";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrent.Location = new System.Drawing.Point(245, 595);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.PasswordChar = '*';
            this.tbCurrent.Size = new System.Drawing.Size(169, 27);
            this.tbCurrent.TabIndex = 5;
            // 
            // tbNew
            // 
            this.tbNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNew.Location = new System.Drawing.Point(245, 644);
            this.tbNew.Name = "tbNew";
            this.tbNew.PasswordChar = '*';
            this.tbNew.Size = new System.Drawing.Size(169, 27);
            this.tbNew.TabIndex = 6;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.Location = new System.Drawing.Point(245, 697);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '*';
            this.tbConfirm.Size = new System.Drawing.Size(169, 27);
            this.tbConfirm.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(927, 743);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 48);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(772, 743);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 48);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // viewUser1
            // 
            this.viewUser1.Location = new System.Drawing.Point(55, 326);
            this.viewUser1.Name = "viewUser1";
            this.viewUser1.Size = new System.Drawing.Size(1029, 154);
            this.viewUser1.TabIndex = 1;
            // 
            // viewDetails1
            // 
            this.viewDetails1.Location = new System.Drawing.Point(66, 12);
            this.viewDetails1.Name = "viewDetails1";
            this.viewDetails1.Size = new System.Drawing.Size(994, 308);
            this.viewDetails1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 803);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lConfirmss);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.viewUser1);
            this.Controls.Add(this.viewDetails1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViewDetails viewDetails1;
        private ViewUser viewUser1;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label sa;
        private System.Windows.Forms.Label lConfirmss;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}