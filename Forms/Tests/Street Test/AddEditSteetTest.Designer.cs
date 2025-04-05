namespace DVLD.Forms.Tests.Street_Test
{
    partial class AddEditSteetTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSteetTest));
            this.btnClose = new System.Windows.Forms.Button();
            this.addEditTest1 = new DVLD.UserControls.AddEditTest();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lMange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(219, 773);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 49);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // addEditTest1
            // 
            this.addEditTest1.Location = new System.Drawing.Point(2, 2);
            this.addEditTest1.Name = "addEditTest1";
            this.addEditTest1.Size = new System.Drawing.Size(584, 765);
            this.addEditTest1.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // lMange
            // 
            this.lMange.AutoSize = true;
            this.lMange.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMange.ForeColor = System.Drawing.Color.Red;
            this.lMange.Location = new System.Drawing.Point(97, 153);
            this.lMange.Name = "lMange";
            this.lMange.Size = new System.Drawing.Size(340, 38);
            this.lMange.TabIndex = 68;
            this.lMange.Text = "Schdule Written Test";
            // 
            // AddEditSteetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 830);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lMange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.addEditTest1);
            this.Name = "AddEditSteetTest";
            this.Text = "AddEditSteetTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private UserControls.AddEditTest addEditTest1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lMange;
    }
}