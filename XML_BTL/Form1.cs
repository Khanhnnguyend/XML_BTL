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

        XmlDocument hd_doc = new XmlDocument();
        XmlElement hd_root;
        string hd_fileName = @"C:\Users\kindl\source\repos\XML_BTL\XML_BTL\XML\HoaDon\hoadon.xml";

        private void hd_them_Click(object sender, EventArgs e)
        {
            int row = hd_grid.RowCount;
            hd_grid.Rows.Add();


            hd_grid.Rows[row].Cells[0].Value = txt_hd_masp.Text;
            hd_grid.Rows[row].Cells[1].Value = txt_hd_tensp.Text;
            hd_grid.Rows[row].Cells[2].Value = txt_hd_sl.Text;
            hd_grid.Rows[row].Cells[3].Value = txt_hd_dg.Text;
            hd_grid.Rows[row].Cells[4].Value = Double.Parse(txt_hd_sl.Text) * Double.Parse(txt_hd_dg.Text);

            Double tong = 0;
            for (int i = 0; i <= row; i++)
            {
                tong += double.Parse(hd_grid.Rows[i].Cells[4].Value.ToString());

            }

            txt_hd_tongtien.Text = tong.ToString();
        }

        private void hd_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = hd_grid.CurrentCell.RowIndex;
            txt_hd_masp.Text = hd_grid.Rows[i].Cells[0].Value.ToString();
            txt_hd_tensp.Text = hd_grid.Rows[i].Cells[1].Value.ToString();
            txt_hd_sl.Text = hd_grid.Rows[i].Cells[2].Value.ToString();
            txt_hd_dg.Text = hd_grid.Rows[i].Cells[3].Value.ToString();
        }

        private void hd_sua_Click(object sender, EventArgs e)
        {
            int i = hd_grid.CurrentCell.RowIndex;
            hd_grid.Rows[i].Cells[0].Value = txt_hd_masp.Text;
            hd_grid.Rows[i].Cells[1].Value = txt_hd_tensp.Text;
            hd_grid.Rows[i].Cells[2].Value = txt_hd_sl.Text;
            hd_grid.Rows[i].Cells[3].Value = txt_hd_dg.Text;
            hd_grid.Rows[i].Cells[4].Value = Double.Parse(txt_hd_sl.Text) * Double.Parse(txt_hd_dg.Text);
        }

        private void hd_xoa_Click(object sender, EventArgs e)
        {
            int i = hd_grid.CurrentCell.RowIndex;
            hd_grid.Rows.RemoveAt(i);
        }

        private void hd_in_Click(object sender, EventArgs e)
        {
            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;

            string hoadon_next ="hd"+ (hd_root.SelectNodes("hoadon").Count+1).ToString();

            XmlNode hoadon = hd_doc.CreateElement("hoadon");

            XmlAttribute mahd = hd_doc.CreateAttribute("mahd");
            mahd.Value = hoadon_next;
            hoadon.Attributes.Append(mahd);

            XmlNode khachhang = hd_doc.CreateElement("khachhang");
            XmlAttribute makh = hd_doc.CreateAttribute("makh");
            makh.Value = txt_hd_kh.Text;
            khachhang.Attributes.Append(makh);

            hoadon.AppendChild(khachhang);

            int i = hd_grid.RowCount;
            for (int j=0;j<i;j++)
            {
                XmlNode sanpham = hd_doc.CreateElement("sanpham");

                XmlAttribute masp = hd_doc.CreateAttribute("masp");
                masp.Value = hd_grid.Rows[j].Cells[0].Value.ToString();
                sanpham.Attributes.Append(masp);

                XmlElement tensp = hd_doc.CreateElement("tensp");
                tensp.InnerText = hd_grid.Rows[j].Cells[1].Value.ToString();
                sanpham.AppendChild(tensp);

                XmlElement soluong = hd_doc.CreateElement("soluong");
                soluong.InnerText = hd_grid.Rows[j].Cells[2].Value.ToString();
                sanpham.AppendChild(soluong);

                XmlElement dongia = hd_doc.CreateElement("dongia");
                dongia.InnerText = hd_grid.Rows[j].Cells[3].Value.ToString();
                sanpham.AppendChild(dongia);
    
                hoadon.AppendChild(sanpham);


            }


            XmlElement ngaytao = hd_doc.CreateElement("ngaytao");
            ngaytao.InnerText = DateTime.Now.ToString();
            hoadon.AppendChild(ngaytao);

            XmlElement tongtien = hd_doc.CreateElement("tongtien");
            tongtien.InnerText = txt_hd_tongtien.Text;
            hoadon.AppendChild(tongtien);

            hd_root.AppendChild(hoadon);
            hd_doc.Save(hd_fileName);
            hd_grid.Rows.Clear();

        }

        private void hienthidshoadon()
        {
            hd_grid_dshd.Rows.Clear();
            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;

            XmlNodeList ds = hd_root.SelectNodes("hoadon");


            int sd = 0;

            foreach (XmlNode item in ds)
            {


                hd_grid_dshd.Rows.Add();
                hd_grid_dshd.Rows[sd].Cells[0].Value = item.SelectSingleNode("@mahd").Value;
                hd_grid_dshd.Rows[sd].Cells[1].Value = item.SelectSingleNode("khachhang").SelectSingleNode("@makh").Value;
                hd_grid_dshd.Rows[sd].Cells[2].Value = item.SelectSingleNode("ngaytao").InnerText;
                hd_grid_dshd.Rows[sd].Cells[3].Value = item.SelectSingleNode("tongtien").InnerText;
                sd++;
            }
        }

       

       

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
            hienthidshoadon();
        }

        private void hd_grid_dshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = hd_grid_dshd.CurrentCell.RowIndex;
            
            string mahd = hd_grid_dshd.Rows[i].Cells[0].Value.ToString();
            
            hienthichitethoadon(mahd);
        }

        private void hienthichitethoadon(string mahd)
        {
            hd_grid_chitiet.Rows.Clear();
            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;
            XmlNode hoadonnode ;
            
            hoadonnode = hd_root.SelectSingleNode("hoadon[@mahd='" + mahd + "']");
            XmlNodeList dssp;

             dssp = hoadonnode.SelectNodes("sanpham");


            
            int sd = 0;

            foreach (XmlNode item in dssp)
            {


                hd_grid_chitiet.Rows.Add();

                hd_grid_chitiet.Rows[sd].Cells[0].Value = item.SelectSingleNode("@masp").Value;
                hd_grid_chitiet.Rows[sd].Cells[1].Value = item.SelectSingleNode("tensp").InnerText;
                hd_grid_chitiet.Rows[sd].Cells[2].Value = item.SelectSingleNode("soluong").InnerText;
                hd_grid_chitiet.Rows[sd].Cells[3].Value = item.SelectSingleNode("dongia").InnerText;
                hd_grid_chitiet.Rows[sd].Cells[4].Value = (Double.Parse(item.SelectSingleNode("soluong").InnerText) + Double.Parse(item.SelectSingleNode("dongia").InnerText)).ToString();
                sd++;
            }
        }

        private void hd_grid_chitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = hd_grid_chitiet.CurrentCell.RowIndex;
            hd_masplb_label.Text = "Mã SP: " + hd_grid_chitiet.Rows[i].Cells[0].Value.ToString();
            hd_tensplb_label.Text = "Tên SP: " + hd_grid_chitiet.Rows[i].Cells[1].Value.ToString();
            txt_hd_soluongql.Text = hd_grid_chitiet.Rows[i].Cells[3].Value.ToString();
            txt_hd_dongiaql.Text = hd_grid_chitiet.Rows[i].Cells[3].Value.ToString();
        }

        private void hd_xoaspbtn_Click(object sender, EventArgs e)
        {
            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;

            int i = hd_grid_dshd.CurrentCell.RowIndex;
            int j = hd_grid_chitiet.CurrentCell.RowIndex;

            XmlNode nodeDel = hd_root.SelectSingleNode("hoadon[@mahd='" + hd_grid_dshd.Rows[i].Cells[0].Value + "']").
                SelectSingleNode("sanpham[@masp='" + hd_grid_chitiet.Rows[j].Cells[0].Value + "']");
            if(nodeDel != null)
            {
                hd_root.SelectSingleNode("hoadon[@mahd='" + hd_grid_dshd.Rows[i].Cells[0].Value + "']").RemoveChild(nodeDel);
                hd_doc.Save(hd_fileName);
            }

            hd_grid_chitiet.Rows.Clear();
            hienthichitethoadon(hd_grid_dshd.Rows[i].Cells[0].Value.ToString());

        }

        private void hd_timkiembtn_Click(object sender, EventArgs e)
        {
            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;
            hd_grid_dshd.Rows.Clear();
            if (hd_rbhoadon.Checked)
            {
                XmlNode nodeFind = hd_root.SelectSingleNode("hoadon[@mahd='" + txt_hd_timkiem.Text + "']");

                hd_grid_dshd.Rows.Add();
                hd_grid_dshd.Rows[0].Cells[0].Value = nodeFind.SelectSingleNode("@mahd").Value;
                hd_grid_dshd.Rows[0].Cells[1].Value = nodeFind.SelectSingleNode("khachhang").SelectSingleNode("@makh").Value;
                hd_grid_dshd.Rows[0].Cells[2].Value = nodeFind.SelectSingleNode("ngaytao").InnerText;
                hd_grid_dshd.Rows[0].Cells[3].Value = nodeFind.SelectSingleNode("tongtien").InnerText;
            }
            else if (hd_rbkh.Checked)
            {
                XmlNodeList nodeHoaDon = hd_root.SelectNodes("hoadon");
                int sd = 0;

                foreach (XmlNode xmlNode in nodeHoaDon)
                {
                    XmlNode node = xmlNode.SelectSingleNode("khachhang[@makh='" + txt_hd_timkiem.Text + "']");
                    if (node != null)
                    {
                        hd_grid_dshd.Rows.Add();
                        hd_grid_dshd.Rows[sd].Cells[0].Value = xmlNode.SelectSingleNode("@mahd").Value;
                        hd_grid_dshd.Rows[sd].Cells[1].Value = xmlNode.SelectSingleNode("khachhang").SelectSingleNode("@makh").Value;
                        hd_grid_dshd.Rows[sd].Cells[2].Value = xmlNode.SelectSingleNode("ngaytao").InnerText;
                        hd_grid_dshd.Rows[sd].Cells[3].Value = xmlNode.SelectSingleNode("tongtien").InnerText;
                        sd++;
                    }
                }
            }
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
