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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTK3 = new System.Windows.Forms.TextBox();
            this.btTK3 = new System.Windows.Forms.Button();
            this.rdoTH3 = new System.Windows.Forms.RadioButton();
            this.rdoMH3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLT3 = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL3 = new System.Windows.Forms.TextBox();
            this.txtTenSP3 = new System.Windows.Forms.TextBox();
            this.txtMaSP3 = new System.Windows.Forms.TextBox();
            this.btXong3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1177, 720);
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
            this.tabPage1.Size = new System.Drawing.Size(1169, 688);
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
            this.tabPage2.Size = new System.Drawing.Size(1169, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý sản phẩm";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.dgv);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1169, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý nhập hàng";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cl2,
            this.Column2,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(156, 368);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(842, 286);
            this.dgv.TabIndex = 2;
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "maSP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // cl2
            // 
            this.cl2.HeaderText = "tên SP";
            this.cl2.MinimumWidth = 6;
            this.cl2.Name = "cl2";
            this.cl2.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "đơn giá ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtTK3);
            this.groupBox2.Controls.Add(this.btTK3);
            this.groupBox2.Controls.Add(this.rdoTH3);
            this.groupBox2.Controls.Add(this.rdoMH3);
            this.groupBox2.Location = new System.Drawing.Point(664, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tìm kiếm ";
            // 
            // txtTK3
            // 
            this.txtTK3.Location = new System.Drawing.Point(54, 82);
            this.txtTK3.Name = "txtTK3";
            this.txtTK3.Size = new System.Drawing.Size(280, 22);
            this.txtTK3.TabIndex = 3;
            // 
            // btTK3
            // 
            this.btTK3.Location = new System.Drawing.Point(148, 189);
            this.btTK3.Name = "btTK3";
            this.btTK3.Size = new System.Drawing.Size(97, 39);
            this.btTK3.TabIndex = 2;
            this.btTK3.Text = "tìm kiếm ";
            this.btTK3.UseVisualStyleBackColor = true;
            this.btTK3.Click += new System.EventHandler(this.btTK3_Click);
            // 
            // rdoTH3
            // 
            this.rdoTH3.AutoSize = true;
            this.rdoTH3.Location = new System.Drawing.Point(247, 145);
            this.rdoTH3.Name = "rdoTH3";
            this.rdoTH3.Size = new System.Drawing.Size(87, 20);
            this.rdoTH3.TabIndex = 1;
            this.rdoTH3.TabStop = true;
            this.rdoTH3.Text = "tên hàng";
            this.rdoTH3.UseVisualStyleBackColor = true;
            // 
            // rdoMH3
            // 
            this.rdoMH3.AutoSize = true;
            this.rdoMH3.Location = new System.Drawing.Point(67, 145);
            this.rdoMH3.Name = "rdoMH3";
            this.rdoMH3.Size = new System.Drawing.Size(87, 20);
            this.rdoMH3.TabIndex = 0;
            this.rdoMH3.TabStop = true;
            this.rdoMH3.Text = "Mã hàng";
            this.rdoMH3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSLT3);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSL3);
            this.groupBox1.Controls.Add(this.txtTenSP3);
            this.groupBox1.Controls.Add(this.txtMaSP3);
            this.groupBox1.Controls.Add(this.btXong3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thêm sản phẩm vào kho ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "số lượng sản phẩm thêm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "đơn giá ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "mã SP";
            // 
            // txtSLT3
            // 
            this.txtSLT3.Location = new System.Drawing.Point(205, 210);
            this.txtSLT3.Name = "txtSLT3";
            this.txtSLT3.Size = new System.Drawing.Size(90, 22);
            this.txtSLT3.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(338, 164);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(99, 22);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtSL3
            // 
            this.txtSL3.Location = new System.Drawing.Point(127, 164);
            this.txtSL3.Name = "txtSL3";
            this.txtSL3.Size = new System.Drawing.Size(102, 22);
            this.txtSL3.TabIndex = 4;
            // 
            // txtTenSP3
            // 
            this.txtTenSP3.Location = new System.Drawing.Point(127, 94);
            this.txtTenSP3.Name = "txtTenSP3";
            this.txtTenSP3.Size = new System.Drawing.Size(310, 22);
            this.txtTenSP3.TabIndex = 3;
            // 
            // txtMaSP3
            // 
            this.txtMaSP3.Location = new System.Drawing.Point(127, 35);
            this.txtMaSP3.Name = "txtMaSP3";
            this.txtMaSP3.Size = new System.Drawing.Size(310, 22);
            this.txtMaSP3.TabIndex = 2;
            // 
            // btXong3
            // 
            this.btXong3.Location = new System.Drawing.Point(412, 199);
            this.btXong3.Name = "btXong3";
            this.btXong3.Size = new System.Drawing.Size(97, 39);
            this.btXong3.TabIndex = 1;
            this.btXong3.Text = "xong ";
            this.btXong3.UseVisualStyleBackColor = true;
            this.btXong3.Click += new System.EventHandler(this.btXong3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1169, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quản lý khách hàng";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1169, 688);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Quản lý hóa đơn";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1169, 688);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Báo cáo thống kê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 720);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTK3;
        private System.Windows.Forms.Button btTK3;
        private System.Windows.Forms.RadioButton rdoTH3;
        private System.Windows.Forms.RadioButton rdoMH3;
        private System.Windows.Forms.TextBox txtSLT3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL3;
        private System.Windows.Forms.TextBox txtTenSP3;
        private System.Windows.Forms.TextBox txtMaSP3;
        private System.Windows.Forms.Button btXong3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}