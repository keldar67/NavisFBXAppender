namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtFileNames = new System.Windows.Forms.TextBox();
            this.btnGetFBXFiles = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileNames
            // 
            this.txtFileNames.Location = new System.Drawing.Point(291, 10);
            this.txtFileNames.Multiline = true;
            this.txtFileNames.Name = "txtFileNames";
            this.txtFileNames.Size = new System.Drawing.Size(329, 376);
            this.txtFileNames.TabIndex = 0;
            // 
            // btnGetFBXFiles
            // 
            this.btnGetFBXFiles.Location = new System.Drawing.Point(14, 18);
            this.btnGetFBXFiles.Name = "btnGetFBXFiles";
            this.btnGetFBXFiles.Size = new System.Drawing.Size(260, 36);
            this.btnGetFBXFiles.TabIndex = 1;
            this.btnGetFBXFiles.Text = "Get FBX Files";
            this.btnGetFBXFiles.UseVisualStyleBackColor = true;
            this.btnGetFBXFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGetFBXFiles_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(14, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(259, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnClose_MouseUp);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(185, 76);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(31, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0000";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(222, 76);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(51, 13);
            this.lblFiles.TabIndex = 4;
            this.lblFiles.Text = "FBX Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 398);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGetFBXFiles);
            this.Controls.Add(this.txtFileNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileNames;
        private System.Windows.Forms.Button btnGetFBXFiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFiles;
    }
}

