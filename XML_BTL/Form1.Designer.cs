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
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.txtTK3 = new System.Windows.Forms.TextBox();
            this.btTK3 = new System.Windows.Forms.Button();
            this.rdoTH3 = new System.Windows.Forms.RadioButton();
            this.rdoMH3 = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lbc31 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
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
            this.clMSP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTSP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHTK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox23.SuspendLayout();
            this.groupBox13.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.groupBox23);
            this.tabPage3.Controls.Add(this.groupBox13);
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
            this.clMSP3,
            this.clTSP3,
            this.clHTK3,
            this.clGia3});
            this.dgv.Location = new System.Drawing.Point(156, 368);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(842, 286);
            this.dgv.TabIndex = 2;
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox23.Controls.Add(this.txtTK3);
            this.groupBox23.Controls.Add(this.btTK3);
            this.groupBox23.Controls.Add(this.rdoTH3);
            this.groupBox23.Controls.Add(this.rdoMH3);
            this.groupBox23.Location = new System.Drawing.Point(664, 31);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(371, 255);
            this.groupBox23.TabIndex = 1;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "tìm kiếm ";
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
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox13.Controls.Add(this.lbc31);
            this.groupBox13.Controls.Add(this.label53);
            this.groupBox13.Controls.Add(this.label43);
            this.groupBox13.Controls.Add(this.label33);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.txtSLT3);
            this.groupBox13.Controls.Add(this.txtDonGia);
            this.groupBox13.Controls.Add(this.txtSL3);
            this.groupBox13.Controls.Add(this.txtTenSP3);
            this.groupBox13.Controls.Add(this.txtMaSP3);
            this.groupBox13.Controls.Add(this.btXong3);
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Location = new System.Drawing.Point(29, 31);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(532, 255);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "thêm sản phẩm vào kho ";
            // 
            // lbc31
            // 
            this.lbc31.AutoSize = true;
            this.lbc31.Location = new System.Drawing.Point(6, 216);
            this.lbc31.Name = "lbc31";
            this.lbc31.Size = new System.Drawing.Size(174, 16);
            this.lbc31.TabIndex = 11;
            this.lbc31.Text = "số lượng sản phẩm thêm";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(263, 170);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(63, 16);
            this.label53.TabIndex = 10;
            this.label53.Text = "đơn giá ";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 170);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(72, 16);
            this.label43.TabIndex = 9;
            this.label43.Text = "Số lượng ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 100);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 16);
            this.label33.TabIndex = 8;
            this.label33.Text = "tên SP";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 16);
            this.label23.TabIndex = 7;
            this.label23.Text = "mã SP";
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
            // clMSP3
            // 
            this.clMSP3.HeaderText = "mã sản phẩm ";
            this.clMSP3.MinimumWidth = 6;
            this.clMSP3.Name = "clMSP3";
            this.clMSP3.Width = 160;
            // 
            // clTSP3
            // 
            this.clTSP3.HeaderText = "tên sản phẩm";
            this.clTSP3.MinimumWidth = 6;
            this.clTSP3.Name = "clTSP3";
            this.clTSP3.Width = 160;
            // 
            // clHTK3
            // 
            this.clHTK3.HeaderText = "Hàng trong kho ";
            this.clHTK3.MinimumWidth = 6;
            this.clHTK3.Name = "clHTK3";
            this.clHTK3.Width = 160;
            // 
            // clGia3
            // 
            this.clGia3.HeaderText = "Giá nhập ";
            this.clGia3.MinimumWidth = 6;
            this.clGia3.Name = "clGia3";
            this.clGia3.Width = 160;
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
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.GroupBox groupBox13;
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
        private System.Windows.Forms.Label lbc31;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTSP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHTK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia3;
    }
}