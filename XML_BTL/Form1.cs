using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XML_BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement QLSP3;
        string fileName = @"C:\Users\HACOM\source\repos\XML_BTL\XML_BTL\QLSP3.xml";

        private void tabPage3_Click(object sender, EventArgs e)
        {
            HienThi3(dgv);
        }
        public void HienThi3(DataGridView dgv) {
            doc.Load(fileName);
            QLSP3 = doc.DocumentElement;
            XmlNodeList ds = QLSP3.SelectNodes("SP3");
            int sd = 0;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = node.SelectSingleNode("maSP3").InnerText;
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("tenSP3").InnerText;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("SL3").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("DG3").InnerText;
                sd++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi3(dgv);
        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
           int i = dgv.CurrentCell.RowIndex;
            txtMaSP3.Text = dgv.Rows[i].Cells[0].Value?.ToString() ?? "";
            txtTenSP3.Text = dgv.Rows[i].Cells[1].Value?.ToString() ?? "";
            txtSL3.Text = dgv.Rows[i].Cells[2].Value?.ToString() ?? "";
            txtDonGia.Text = dgv.Rows[i].Cells[3].Value?.ToString() ?? "";
        }

        private void btTK3_Click(object sender, EventArgs e)
        {
            if (txtTK3.Text == "") MessageBox.Show("Vui lòng nhập thứ bạn muốn tìm");
             else if(rdoMH3.Checked)
            {
                dgv.Rows.Clear();
                XmlNode TK3 = QLSP3.SelectSingleNode("SP3[maSP3 ='" + txtTK3.Text.Trim().ToLower() + "']");
                if (TK3 != null)
                {
                    // dgv.Rows.Add();//thêm một dòng mới
                    //đưa dữ liệu vào dòng vừa tạo
                    dgv.Rows[0].Cells[0].Value = TK3.SelectSingleNode("maSP3").InnerText;
                    dgv.Rows[0].Cells[1].Value = TK3.SelectSingleNode("tenSP3").InnerText;
                    dgv.Rows[0].Cells[2].Value = TK3.SelectSingleNode("SL3").InnerText;
                    dgv.Rows[0].Cells[3].Value = TK3.SelectSingleNode("DG3").InnerText;
                }
                else { MessageBox.Show("không có thứ bạn muốn tìm "); }

            }
            else if (rdoTH3.Checked)
            {
                dgv.Rows.Clear();
                string searchText = txtTK3.Text.Trim().ToLower(); // Chuyển về chữ thường

                // Sử dụng XPath chính xác để tìm kiếm
                XmlNode TK31 = QLSP3.SelectSingleNode($"SP3[translate(tenSP3, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz') = '{searchText}']");

                if (TK31 != null)
                {
                    dgv.Rows.Add();
                    dgv.Rows[0].Cells[0].Value = TK31.SelectSingleNode("maSP3").InnerText;
                    dgv.Rows[0].Cells[1].Value = TK31.SelectSingleNode("tenSP3").InnerText;
                    dgv.Rows[0].Cells[2].Value = TK31.SelectSingleNode("SL3").InnerText;
                    dgv.Rows[0].Cells[3].Value = TK31.SelectSingleNode("DG3").InnerText;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm bạn muốn tìm.");
                }
            }

            else
            {
                MessageBox.Show("Vui lòng chọn Mã hàng hoặc Tên Hàng");
            }
        }

        private void btXong3_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);// load tệp xml
            QLSP3 = doc.DocumentElement;

            string maSP = txtMaSP3.Text.Trim();
            string soLuongThem = txtSLT3.Text.Trim();
            XmlNode SPNode = QLSP3.SelectSingleNode($"//SP3[maSP3='{maSP}']");
            if (SPNode != null)
            {
                // Nếu mã sản phẩm đã tồn tại, cộng số lượng mới vào số lượng hiện có
                int soLuongHienCo = int.Parse(SPNode.SelectSingleNode("SL3").InnerText);
                int soLuongMoi = int.Parse(soLuongThem);
                int tongSoLuong = soLuongHienCo + soLuongMoi;
                SPNode.SelectSingleNode("SL3").InnerText = tongSoLuong.ToString();
                doc.Save(fileName);//lưu dữ liệu
                HienThi3(dgv);
            }
            else
            {
                // Nếu mã sản phẩm chưa tồn tại, thêm sản phẩm mới vào tập tin XML
                XmlNode SP3 = doc.CreateElement("SP3");
                XmlElement maSP3 = doc.CreateElement("maSP3");
                maSP3.InnerText = txtMaSP3.Text;//gán giá trị trên ô textbox txtMS cho node mã sách
                SP3.AppendChild(maSP3);// gán node masach là node con của node sach

                XmlElement tenSP3 = doc.CreateElement("tenSP3");// tạo 1 element node ten sach
                tenSP3.InnerText = txtTenSP3.Text;// gán giá trị trên ô textbox txttenS cho node tensach
                SP3.AppendChild(tenSP3);//gán node ténach là node con của node sach

                XmlElement SL3 = doc.CreateElement("SL3");
                SL3.InnerText = txtSL3.Text;
                SP3.AppendChild(SL3);

                XmlElement DG3 = doc.CreateElement("DG3");
                DG3.InnerText = txtDonGia.Text;
                SP3.AppendChild(DG3);

                //sau khi tạo xong node sach, thì thêm sach vào gốc root
                QLSP3.AppendChild(SP3);
                doc.Save(fileName);//lưu dữ liệu
                HienThi3(dgv);


            }
        }
    }
}
