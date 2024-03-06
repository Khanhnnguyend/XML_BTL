namespace XML_BTL
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_sodienthoai = new System.Windows.Forms.Label();
            this.lb_tenkhachhang = new System.Windows.Forms.Label();
            this.lb_makhachhang = new System.Windows.Forms.Label();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.clMaK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(829, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập hóa đơn";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý sản phẩm";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(829, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý nhập hàng";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage4.Controls.Add(this.txtDiaChi);
            this.tabPage4.Controls.Add(this.txtSDT);
            this.tabPage4.Controls.Add(this.txtTenKH);
            this.tabPage4.Controls.Add(this.txtMaKhach);
            this.tabPage4.Controls.Add(this.lb_diachi);
            this.tabPage4.Controls.Add(this.lb_sodienthoai);
            this.tabPage4.Controls.Add(this.lb_tenkhachhang);
            this.tabPage4.Controls.Add(this.lb_makhachhang);
            this.tabPage4.Controls.Add(this.dataGridViewKH);
            this.tabPage4.Controls.Add(this.btnTimKiemKH);
            this.tabPage4.Controls.Add(this.btnXoaKH);
            this.tabPage4.Controls.Add(this.btnSuaKH);
            this.tabPage4.Controls.Add(this.btnThemKH);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(829, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quản lý khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(306, 370);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 22);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(306, 338);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(172, 22);
            this.txtSDT.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(306, 304);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(172, 22);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(306, 269);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(172, 22);
            this.txtMaKhach.TabIndex = 9;
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(169, 370);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(54, 16);
            this.lb_diachi.TabIndex = 8;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_sodienthoai
            // 
            this.lb_sodienthoai.AutoSize = true;
            this.lb_sodienthoai.Location = new System.Drawing.Point(169, 338);
            this.lb_sodienthoai.Name = "lb_sodienthoai";
            this.lb_sodienthoai.Size = new System.Drawing.Size(98, 16);
            this.lb_sodienthoai.TabIndex = 7;
            this.lb_sodienthoai.Text = "Số điện thoại";
            // 
            // lb_tenkhachhang
            // 
            this.lb_tenkhachhang.AutoSize = true;
            this.lb_tenkhachhang.Location = new System.Drawing.Point(169, 304);
            this.lb_tenkhachhang.Name = "lb_tenkhachhang";
            this.lb_tenkhachhang.Size = new System.Drawing.Size(117, 16);
            this.lb_tenkhachhang.TabIndex = 6;
            this.lb_tenkhachhang.Text = "Tên khách hàng";
            // 
            // lb_makhachhang
            // 
            this.lb_makhachhang.AutoSize = true;
            this.lb_makhachhang.Location = new System.Drawing.Point(169, 269);
            this.lb_makhachhang.Name = "lb_makhachhang";
            this.lb_makhachhang.Size = new System.Drawing.Size(111, 16);
            this.lb_makhachhang.TabIndex = 5;
            this.lb_makhachhang.Text = "Mã khách hàng";
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaK,
            this.clTenK,
            this.clSDT,
            this.clDiaChi});
            this.dataGridViewKH.Location = new System.Drawing.Point(172, 29);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.RowTemplate.Height = 24;
            this.dataGridViewKH.Size = new System.Drawing.Size(632, 201);
            this.dataGridViewKH.TabIndex = 4;
            this.dataGridViewKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellContentClick);
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(42, 198);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(95, 32);
            this.btnTimKiemKH.TabIndex = 3;
            this.btnTimKiemKH.Text = "Tìm kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(42, 142);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(95, 33);
            this.btnXoaKH.TabIndex = 2;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(42, 86);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(95, 32);
            this.btnSuaKH.TabIndex = 1;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(42, 29);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(95, 36);
            this.btnThemKH.TabIndex = 0;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(829, 418);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Quản lý hóa đơn";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(829, 418);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Báo cáo thống kê";
            // 
            // clMaK
            // 
            this.clMaK.HeaderText = "Mã Khách Hàng";
            this.clMaK.MinimumWidth = 6;
            this.clMaK.Name = "clMaK";
            this.clMaK.Width = 125;
            // 
            // clTenK
            // 
            this.clTenK.HeaderText = "Tên Khách Hàng";
            this.clTenK.MinimumWidth = 6;
            this.clTenK.Name = "clTenK";
            this.clTenK.Width = 125;
            // 
            // clSDT
            // 
            this.clSDT.HeaderText = "Số Điện Thoại";
            this.clSDT.MinimumWidth = 6;
            this.clSDT.Name = "clSDT";
            this.clSDT.Width = 125;
            // 
            // clDiaChi
            // 
            this.clDiaChi.HeaderText = "Địa Chỉ";
            this.clDiaChi.MinimumWidth = 6;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_sodienthoai;
        private System.Windows.Forms.Label lb_tenkhachhang;
        private System.Windows.Forms.Label lb_makhachhang;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
    }
}