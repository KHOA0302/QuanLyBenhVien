namespace QLBV
{
    partial class frmSaoLuuPhucHoi
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSL = new System.Windows.Forms.Button();
            this.btnPH = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 38);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(268, 25);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "D:/TTCS/QLBV.bak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(180, 89);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(75, 34);
            this.btnSL.TabIndex = 3;
            this.btnSL.Text = "Sao Lưu";
            this.btnSL.UseVisualStyleBackColor = true;
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // btnPH
            // 
            this.btnPH.Location = new System.Drawing.Point(286, 89);
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(75, 34);
            this.btnPH.TabIndex = 4;
            this.btnPH.Text = "Phục Hồi";
            this.btnPH.UseVisualStyleBackColor = true;
            this.btnPH.Click += new System.EventHandler(this.btnPH_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(403, 38);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 25);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Browser";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // frmSaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 147);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnPH);
            this.Controls.Add(this.btnSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSaoLuuPhucHoi";
            this.Text = "Sao Lưu - Phục Hồi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSL;
        private System.Windows.Forms.Button btnPH;
        private System.Windows.Forms.Button btnChon;
    }
}