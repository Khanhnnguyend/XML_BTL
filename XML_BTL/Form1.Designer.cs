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
            this.QLSPdgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLSPgroupBox2 = new System.Windows.Forms.GroupBox();
            this.QLSPbtnTimKiem = new System.Windows.Forms.Button();
            this.QLSPedtTimKiem = new System.Windows.Forms.TextBox();
            this.QLSPgroupBox1 = new System.Windows.Forms.GroupBox();
            this.QLSPbtnXoa = new System.Windows.Forms.Button();
            this.QLSPbtnSua = new System.Windows.Forms.Button();
            this.QLSPbtnThem = new System.Windows.Forms.Button();
            this.QLSPedtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QLSPedtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QLSPedtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QLSPedtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLSPdgv)).BeginInit();
            this.QLSPgroupBox2.SuspendLayout();
            this.QLSPgroupBox1.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.QLSPdgv);
            this.tabPage2.Controls.Add(this.QLSPgroupBox2);
            this.tabPage2.Controls.Add(this.QLSPgroupBox1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý sản phẩm";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // QLSPdgv
            // 
            this.QLSPdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QLSPdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLSPdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.QLSPdgv.Location = new System.Drawing.Point(34, 177);
            this.QLSPdgv.Name = "QLSPdgv";
            this.QLSPdgv.RowHeadersWidth = 51;
            this.QLSPdgv.RowTemplate.Height = 24;
            this.QLSPdgv.Size = new System.Drawing.Size(761, 224);
            this.QLSPdgv.TabIndex = 2;
            this.QLSPdgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.QLSPdgv_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // QLSPgroupBox2
            // 
            this.QLSPgroupBox2.Controls.Add(this.QLSPbtnTimKiem);
            this.QLSPgroupBox2.Controls.Add(this.QLSPedtTimKiem);
            this.QLSPgroupBox2.Location = new System.Drawing.Point(468, 23);
            this.QLSPgroupBox2.Name = "QLSPgroupBox2";
            this.QLSPgroupBox2.Size = new System.Drawing.Size(327, 90);
            this.QLSPgroupBox2.TabIndex = 1;
            this.QLSPgroupBox2.TabStop = false;
            this.QLSPgroupBox2.Text = "Tìm kiếm sản phẩm";
            // 
            // QLSPbtnTimKiem
            // 
            this.QLSPbtnTimKiem.Location = new System.Drawing.Point(121, 61);
            this.QLSPbtnTimKiem.Name = "QLSPbtnTimKiem";
            this.QLSPbtnTimKiem.Size = new System.Drawing.Size(88, 23);
            this.QLSPbtnTimKiem.TabIndex = 1;
            this.QLSPbtnTimKiem.Text = "Tìm kiếm";
            this.QLSPbtnTimKiem.UseVisualStyleBackColor = true;
            this.QLSPbtnTimKiem.Click += new System.EventHandler(this.QLSPbtnTimKiem_Click);
            // 
            // QLSPedtTimKiem
            // 
            this.QLSPedtTimKiem.Location = new System.Drawing.Point(40, 29);
            this.QLSPedtTimKiem.Name = "QLSPedtTimKiem";
            this.QLSPedtTimKiem.Size = new System.Drawing.Size(249, 22);
            this.QLSPedtTimKiem.TabIndex = 0;
            // 
            // QLSPgroupBox1
            // 
            this.QLSPgroupBox1.Controls.Add(this.QLSPbtnXoa);
            this.QLSPgroupBox1.Controls.Add(this.QLSPbtnSua);
            this.QLSPgroupBox1.Controls.Add(this.QLSPbtnThem);
            this.QLSPgroupBox1.Controls.Add(this.QLSPedtDonGia);
            this.QLSPgroupBox1.Controls.Add(this.label4);
            this.QLSPgroupBox1.Controls.Add(this.QLSPedtSoLuong);
            this.QLSPgroupBox1.Controls.Add(this.label3);
            this.QLSPgroupBox1.Controls.Add(this.QLSPedtTenHang);
            this.QLSPgroupBox1.Controls.Add(this.label2);
            this.QLSPgroupBox1.Controls.Add(this.QLSPedtMaHang);
            this.QLSPgroupBox1.Controls.Add(this.label1);
            this.QLSPgroupBox1.Location = new System.Drawing.Point(34, 23);
            this.QLSPgroupBox1.Name = "QLSPgroupBox1";
            this.QLSPgroupBox1.Size = new System.Drawing.Size(384, 148);
            this.QLSPgroupBox1.TabIndex = 0;
            this.QLSPgroupBox1.TabStop = false;
            this.QLSPgroupBox1.Text = "Thông tin sản phẩm";
            // 
            // QLSPbtnXoa
            // 
            this.QLSPbtnXoa.Location = new System.Drawing.Point(291, 113);
            this.QLSPbtnXoa.Name = "QLSPbtnXoa";
            this.QLSPbtnXoa.Size = new System.Drawing.Size(75, 23);
            this.QLSPbtnXoa.TabIndex = 10;
            this.QLSPbtnXoa.Text = "Xoá";
            this.QLSPbtnXoa.UseVisualStyleBackColor = true;
            this.QLSPbtnXoa.Click += new System.EventHandler(this.QLSPbtnXoa_Click);
            // 
            // QLSPbtnSua
            // 
            this.QLSPbtnSua.Location = new System.Drawing.Point(291, 71);
            this.QLSPbtnSua.Name = "QLSPbtnSua";
            this.QLSPbtnSua.Size = new System.Drawing.Size(75, 23);
            this.QLSPbtnSua.TabIndex = 9;
            this.QLSPbtnSua.Text = "Sửa";
            this.QLSPbtnSua.UseVisualStyleBackColor = true;
            this.QLSPbtnSua.Click += new System.EventHandler(this.QLSPbtnSua_Click);
            // 
            // QLSPbtnThem
            // 
            this.QLSPbtnThem.Location = new System.Drawing.Point(291, 29);
            this.QLSPbtnThem.Name = "QLSPbtnThem";
            this.QLSPbtnThem.Size = new System.Drawing.Size(75, 23);
            this.QLSPbtnThem.TabIndex = 8;
            this.QLSPbtnThem.Text = "Thêm";
            this.QLSPbtnThem.UseVisualStyleBackColor = true;
            this.QLSPbtnThem.Click += new System.EventHandler(this.QLSPbtnThem_Click);
            // 
            // QLSPedtDonGia
            // 
            this.QLSPedtDonGia.Location = new System.Drawing.Point(107, 114);
            this.QLSPedtDonGia.Name = "QLSPedtDonGia";
            this.QLSPedtDonGia.Size = new System.Drawing.Size(165, 22);
            this.QLSPedtDonGia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // QLSPedtSoLuong
            // 
            this.QLSPedtSoLuong.Location = new System.Drawing.Point(107, 86);
            this.QLSPedtSoLuong.Name = "QLSPedtSoLuong";
            this.QLSPedtSoLuong.Size = new System.Drawing.Size(165, 22);
            this.QLSPedtSoLuong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            // 
            // QLSPedtTenHang
            // 
            this.QLSPedtTenHang.Location = new System.Drawing.Point(107, 58);
            this.QLSPedtTenHang.Name = "QLSPedtTenHang";
            this.QLSPedtTenHang.Size = new System.Drawing.Size(165, 22);
            this.QLSPedtTenHang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng:";
            // 
            // QLSPedtMaHang
            // 
            this.QLSPedtMaHang.Location = new System.Drawing.Point(107, 30);
            this.QLSPedtMaHang.Name = "QLSPedtMaHang";
            this.QLSPedtMaHang.Size = new System.Drawing.Size(165, 22);
            this.QLSPedtMaHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng:";
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
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(829, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quản lý khách hàng";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLSPdgv)).EndInit();
            this.QLSPgroupBox2.ResumeLayout(false);
            this.QLSPgroupBox2.PerformLayout();
            this.QLSPgroupBox1.ResumeLayout(false);
            this.QLSPgroupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox QLSPgroupBox1;
        private System.Windows.Forms.DataGridView QLSPdgv;
        private System.Windows.Forms.GroupBox QLSPgroupBox2;
        private System.Windows.Forms.Button QLSPbtnXoa;
        private System.Windows.Forms.Button QLSPbtnSua;
        private System.Windows.Forms.Button QLSPbtnThem;
        private System.Windows.Forms.TextBox QLSPedtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QLSPedtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QLSPedtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QLSPedtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button QLSPbtnTimKiem;
        private System.Windows.Forms.TextBox QLSPedtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}