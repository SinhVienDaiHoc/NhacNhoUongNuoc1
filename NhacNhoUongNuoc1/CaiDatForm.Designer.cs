namespace NhacNhoUongNuoc1
{
    partial class CaiDatForm
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
            this.chkTuDong = new System.Windows.Forms.CheckBox();
            this.chkThuCong = new System.Windows.Forms.CheckBox();
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTuDong
            // 
            this.chkTuDong.AutoSize = true;
            this.chkTuDong.Location = new System.Drawing.Point(81, 125);
            this.chkTuDong.Name = "chkTuDong";
            this.chkTuDong.Size = new System.Drawing.Size(143, 20);
            this.chkTuDong.TabIndex = 0;
            this.chkTuDong.Text = "Nhắc Nhớ Tự Động";
            this.chkTuDong.UseVisualStyleBackColor = true;
            this.chkTuDong.Click += new System.EventHandler(this.chkTuDong_CheckedChanged);
            // 
            // chkThuCong
            // 
            this.chkThuCong.AutoSize = true;
            this.chkThuCong.Location = new System.Drawing.Point(81, 171);
            this.chkThuCong.Name = "chkThuCong";
            this.chkThuCong.Size = new System.Drawing.Size(150, 20);
            this.chkThuCong.TabIndex = 1;
            this.chkThuCong.Text = "Nhắc Nhở Thủ Công";
            this.chkThuCong.UseVisualStyleBackColor = true;
            this.chkThuCong.Click += new System.EventHandler(this.chkThuCong_CheckedChanged);
            // 
            // numThoiGian
            // 
            this.numThoiGian.Location = new System.Drawing.Point(250, 169);
            this.numThoiGian.Name = "numThoiGian";
            this.numThoiGian.Size = new System.Drawing.Size(79, 22);
            this.numThoiGian.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÀI ĐẶT NHẮC NHỞ";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(81, 222);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(116, 23);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // CaiDatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 256);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numThoiGian);
            this.Controls.Add(this.chkThuCong);
            this.Controls.Add(this.chkTuDong);
            this.Name = "CaiDatForm";
            this.Text = "Z";
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTuDong;
        private System.Windows.Forms.CheckBox chkThuCong;
        private System.Windows.Forms.NumericUpDown numThoiGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
    }
}