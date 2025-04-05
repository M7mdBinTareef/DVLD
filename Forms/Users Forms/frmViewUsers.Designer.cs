namespace DVLD.Forms
{
    partial class frmViewUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUsers));
            this.btnClose = new System.Windows.Forms.Button();
            this.viewUser1 = new DVLD.ViewUser();
            this.viewDetails1 = new DVLD.ViewDetails();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(853, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // viewUser1
            // 
            this.viewUser1.Location = new System.Drawing.Point(12, 366);
            this.viewUser1.Name = "viewUser1";
            this.viewUser1.Size = new System.Drawing.Size(1043, 154);
            this.viewUser1.TabIndex = 1;
            // 
            // viewDetails1
            // 
            this.viewDetails1.Location = new System.Drawing.Point(12, 12);
            this.viewDetails1.Name = "viewDetails1";
            this.viewDetails1.Size = new System.Drawing.Size(1018, 363);
            this.viewDetails1.TabIndex = 0;
            // 
            // frmViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 588);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.viewUser1);
            this.Controls.Add(this.viewDetails1);
            this.Name = "frmViewUsers";
            this.Text = "frmViewUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private ViewDetails viewDetails1;
        private ViewUser viewUser1;
        private System.Windows.Forms.Button btnClose;
    }
}