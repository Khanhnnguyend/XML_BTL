using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataGridViewKH.CurrentCell.RowIndex;
            txtMaKhach.Text = dataGridViewKH.Rows[t].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridViewKH.Rows[t].Cells[1].Value.ToString();
            txtSDT.Text = dataGridViewKH.Rows[t].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridViewKH.Rows[t].Cells[3].Value.ToString();
        }


        XmlDocument xmlDoc = new XmlDocument();
        XmlElement root;
        String fileName = @"C:\Users\FPT\source\repos\XML_BTL\XML_BTL\XML\KhachHang\KhachHang.xml";
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi(dataGridViewKH);
        }
        public void HienThi(DataGridView dataGridViewKH)
        {
            xmlDoc.Load(fileName);//load tep xml
            root = xmlDoc.DocumentElement;//xac dinh node goc
            XmlNodeList ds = root.SelectNodes("KhachHang");
            int sd = 0;
            foreach (XmlNode item in ds)
            {
                dataGridViewKH.Rows.Add();
                dataGridViewKH.Rows[sd].Cells[0].Value = item.SelectSingleNode("@MaK").Value;
                dataGridViewKH.Rows[sd].Cells[1].Value = item.SelectSingleNode("tenKhach").InnerText;
                dataGridViewKH.Rows[sd].Cells[2].Value = item.SelectSingleNode("SDT").InnerText;
                dataGridViewKH.Rows[sd].Cells[3].Value = item.SelectSingleNode("diaChi").InnerText;
                sd++;
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(fileName);//load tep xml
            root = xmlDoc.DocumentElement;//xac dinh node goc
            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || !char.IsUpper(txtTenKH.Text[0]))
            {
                MessageBox.Show("Thêm không thành công. Tên khách hàng không được rỗng và phải bắt đầu bằng chữ hoa.");
                return;
            }

            // Kiểm tra số điện thoại
            if (txtSDT.Text.Length != 10 || txtSDT.Text[0] != '0' || !txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Thêm không thành công. Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.");
                return;
            }

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || !char.IsUpper(txtDiaChi.Text[0]))
            {
                MessageBox.Show("Thêm không thành công. Địa chỉ không được rỗng và phải bắt đầu bằng chữ hoa.");
                return;
            }
            XmlNode khachhang = xmlDoc.CreateElement("KhachHang");

            XmlAttribute masach = xmlDoc.CreateAttribute("MaK");
            masach.Value = txtMaKhach.Text;
            khachhang.Attributes.Append(masach);

            XmlElement tenKhach = xmlDoc.CreateElement("tenKhach");
            tenKhach.InnerText = txtTenKH.Text;
            khachhang.AppendChild(tenKhach);

            XmlElement sdt = xmlDoc.CreateElement("SDT");
            sdt.InnerText = txtSDT.Text;
            khachhang.AppendChild(sdt);

            XmlElement diachi = xmlDoc.CreateElement("diaChi");
            diachi.InnerText = txtDiaChi.Text;
            khachhang.AppendChild(diachi);

            root.AppendChild(khachhang);
            xmlDoc.Save(fileName);
            HienThi(dataGridViewKH);
        }
        private void View_MouseClick(object sender, MouseEventArgs e)
        {
            int t = dataGridViewKH.CurrentCell.RowIndex;
            txtMaKhach.Text = dataGridViewKH.Rows[t].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridViewKH.Rows[t].Cells[1].Value.ToString();
            txtSDT.Text = dataGridViewKH.Rows[t].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridViewKH.Rows[t].Cells[3].Value.ToString();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(fileName);// load tệp xml
            root = xmlDoc.DocumentElement;// xác định node gốc
            //láy vị trí cần sửa theo mã sách cũ đưa vào

            XmlNode khachCu = root.SelectSingleNode("KhachHang[@MaK ='" + txtMaKhach.Text + "']");

            if (khachCu != null)
            {
                
                XmlNode khachSuaMoi = xmlDoc.CreateElement("KhachHang");
                
                XmlAttribute makhach = xmlDoc.CreateAttribute("MaK");
                makhach.InnerText = txtMaKhach.Text;//gán giá trị cho mã sách
                khachSuaMoi.Attributes.Append(makhach);

                XmlElement tensach = xmlDoc.CreateElement("tenKhach");
                tensach.InnerText = txtTenKH.Text;
                khachSuaMoi.AppendChild(tensach);

                XmlElement soluong = xmlDoc.CreateElement("SDT");
                soluong.InnerText = txtSDT.Text;
                khachSuaMoi.AppendChild(soluong);

                XmlElement dongia = xmlDoc.CreateElement("diaChi");
                dongia.InnerText = txtDiaChi.Text;
                khachSuaMoi.AppendChild(dongia);

                
                root.ReplaceChild(khachSuaMoi, khachCu);
                xmlDoc.Save(fileName);//lưu lại
                HienThi(dataGridViewKH);

            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(fileName);// load tệp xml

            root = xmlDoc.DocumentElement;// xác định node gốc

            XmlNode khachCanXoa = root.SelectSingleNode("KhachHang[@MaK ='" + txtMaKhach.Text + "']");
            if (khachCanXoa != null)
            {
                root.RemoveChild(khachCanXoa);
                xmlDoc.Save(fileName);
            }
            dataGridViewKH.Rows.Clear();
            HienThi(dataGridViewKH);
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            dataGridViewKH.Rows.Clear();
            XmlNode khachCanTim = root.SelectSingleNode("KhachHang[@MaK ='" + txtMaKhach.Text.Trim() + "']");
            XmlNode tenKCanTim = root.SelectSingleNode("KhachHang[tenKhach ='" + txtTenKH.Text.Trim() + "']");
            if (khachCanTim != null)
            {
                dataGridViewKH.Rows[0].Cells[0].Value = khachCanTim.SelectSingleNode("@MaK").InnerText;
                dataGridViewKH.Rows[0].Cells[1].Value = khachCanTim.SelectSingleNode("tenKhach").InnerText;
                dataGridViewKH.Rows[0].Cells[2].Value = khachCanTim.SelectSingleNode("SDT").InnerText;
                dataGridViewKH.Rows[0].Cells[3].Value = khachCanTim.SelectSingleNode("diaChi").InnerText;
            }
            if (tenKCanTim != null)
            {
                dataGridViewKH.Rows[0].Cells[0].Value = tenKCanTim.SelectSingleNode("@MaK").InnerText;
                dataGridViewKH.Rows[0].Cells[1].Value = tenKCanTim.SelectSingleNode("tenKhach").InnerText;
                dataGridViewKH.Rows[0].Cells[2].Value = tenKCanTim.SelectSingleNode("SDT").InnerText;
                dataGridViewKH.Rows[0].Cells[3].Value = tenKCanTim.SelectSingleNode("diaChi").InnerText;
            }
        }
    }
}
