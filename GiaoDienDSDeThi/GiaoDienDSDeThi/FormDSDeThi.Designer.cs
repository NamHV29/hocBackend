namespace GiaoDienDSDeThi
{
    partial class FormDSDeThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongCau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamBai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDanhSachDeThi = new System.Windows.Forms.DataGridView();
            this.TenDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianLamBai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDeThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐỀ THI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongCau
            // 
            this.txtSoLuongCau.Location = new System.Drawing.Point(136, 156);
            this.txtSoLuongCau.Name = "txtSoLuongCau";
            this.txtSoLuongCau.ReadOnly = true;
            this.txtSoLuongCau.Size = new System.Drawing.Size(67, 30);
            this.txtSoLuongCau.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng câu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "phút";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(355, 105);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.ReadOnly = true;
            this.txtThoiGian.Size = new System.Drawing.Size(70, 30);
            this.txtThoiGian.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thời gian:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.Enabled = false;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(109, 102);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(127, 33);
            this.cbMonHoc.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Môn học:";
            // 
            // txtTenDe
            // 
            this.txtTenDe.Location = new System.Drawing.Point(109, 61);
            this.txtTenDe.Name = "txtTenDe";
            this.txtTenDe.ReadOnly = true;
            this.txtTenDe.Size = new System.Drawing.Size(377, 30);
            this.txtTenDe.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đề thi:";
            // 
            // btnLamBai
            // 
            this.btnLamBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamBai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLamBai.Location = new System.Drawing.Point(365, 156);
            this.btnLamBai.Name = "btnLamBai";
            this.btnLamBai.Size = new System.Drawing.Size(121, 35);
            this.btnLamBai.TabIndex = 18;
            this.btnLamBai.Text = "Làm bài";
            this.btnLamBai.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(109, 209);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(332, 30);
            this.txtTimKiem.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tìm kiếm: ";
            // 
            // dgvDanhSachDeThi
            // 
            this.dgvDanhSachDeThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDeThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDe,
            this.MaMon,
            this.ThoiGianLamBai,
            this.SoLuongCau});
            this.dgvDanhSachDeThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDeThi.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachDeThi.Name = "dgvDanhSachDeThi";
            this.dgvDanhSachDeThi.RowHeadersWidth = 62;
            this.dgvDanhSachDeThi.RowTemplate.Height = 28;
            this.dgvDanhSachDeThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDeThi.Size = new System.Drawing.Size(468, 138);
            this.dgvDanhSachDeThi.TabIndex = 21;
            // 
            // TenDe
            // 
            this.TenDe.HeaderText = "Tên đề";
            this.TenDe.MinimumWidth = 8;
            this.TenDe.Name = "TenDe";
            // 
            // MaMon
            // 
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MinimumWidth = 8;
            this.MaMon.Name = "MaMon";
            // 
            // ThoiGianLamBai
            // 
            this.ThoiGianLamBai.HeaderText = "Thời gian làm bài";
            this.ThoiGianLamBai.MinimumWidth = 8;
            this.ThoiGianLamBai.Name = "ThoiGianLamBai";
            // 
            // SoLuongCau
            // 
            this.SoLuongCau.HeaderText = "Số lượng câu";
            this.SoLuongCau.MinimumWidth = 8;
            this.SoLuongCau.Name = "SoLuongCau";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 55);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDanhSachDeThi);
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 167);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đề thi";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi.Location = new System.Drawing.Point(227, 156);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(121, 35);
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // FormDSDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(496, 437);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLamBai);
            this.Controls.Add(this.txtSoLuongCau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDe);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDSDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đề thi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDeThi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongCau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLamBai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDanhSachDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianLamBai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
    }
}