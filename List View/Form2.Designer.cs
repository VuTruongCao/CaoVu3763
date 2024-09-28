namespace List_View
{
    partial class NhanVienForm
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
            this.lblMSNV = new System.Windows.Forms.Label();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblLuongcoban = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSNV
            // 
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(29, 30);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(49, 16);
            this.lblMSNV.TabIndex = 0;
            this.lblMSNV.Text = "MSNV:";
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.Location = new System.Drawing.Point(29, 71);
            this.lblTennhanvien.Name = "lblTennhanvien";
            this.lblTennhanvien.Size = new System.Drawing.Size(94, 16);
            this.lblTennhanvien.TabIndex = 0;
            this.lblTennhanvien.Text = "Tên nhân viên:";
            // 
            // lblLuongcoban
            // 
            this.lblLuongcoban.AutoSize = true;
            this.lblLuongcoban.Location = new System.Drawing.Point(29, 119);
            this.lblLuongcoban.Name = "lblLuongcoban";
            this.lblLuongcoban.Size = new System.Drawing.Size(91, 16);
            this.lblLuongcoban.TabIndex = 0;
            this.lblLuongcoban.Text = "Lương cơ bản:";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(142, 23);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(100, 22);
            this.txtMSNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(142, 65);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(275, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(142, 113);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(100, 22);
            this.txtLuongCB.TabIndex = 1;
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(131, 146);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 2;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(258, 146);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 181);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lblLuongcoban);
            this.Controls.Add(this.lblTennhanvien);
            this.Controls.Add(this.lblMSNV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSNV;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblLuongcoban;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnDong;
    }
}