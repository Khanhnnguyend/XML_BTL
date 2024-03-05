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
        

        public void QLSPHienThi(DataGridView QLSPdgv)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            string QLSPFileName = @"D:\XML\XML_BTL\XML_BTL\XML\SanPham\QLSP.xml";

            doc.Load(QLSPFileName);
            root = doc.DocumentElement;

            XmlNodeList sp = root.SelectNodes("SanPham");
            int sd = 0; 

            foreach (XmlNode item in sp)
            {
                QLSPdgv.Rows.Add();
                QLSPdgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("@MaHang").Value;
                QLSPdgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("TenHang").InnerText;
                QLSPdgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("SoLuong").InnerText;
                QLSPdgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("DonGia").InnerText;
                sd++;
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            QLSPHienThi(QLSPdgv);
        }

        private void QLSPbtnThem_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            string QLSPFileName = @"D:\XML\XML_BTL\XML_BTL\XML\SanPham\QLSP.xml";

            doc.Load(QLSPFileName);
            root = doc.DocumentElement;

            XmlNode sanpham = doc.CreateElement("SanPham");

            XmlAttribute mahang = doc.CreateAttribute("MaHang");
            mahang.Value = QLSPedtMaHang.Text;
            sanpham.Attributes.Append(mahang);

            XmlElement tenhang = doc.CreateElement("TenHang");
            tenhang.InnerText = QLSPedtTenHang.Text;
            sanpham.AppendChild(tenhang);

            XmlElement soluong = doc.CreateElement("SoLuong");
            soluong.InnerText = QLSPedtSoLuong.Text;
            sanpham.AppendChild(soluong);

            XmlElement dongia = doc.CreateElement("DonGia");
            dongia.InnerText = QLSPedtDonGia.Text;
            sanpham.AppendChild(dongia);

            root.AppendChild(sanpham);
            doc.Save(QLSPFileName);
            QLSPHienThi(QLSPdgv);
        }

        private void QLSPbtnSua_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            string QLSPFileName = @"D:\XML\XML_BTL\XML_BTL\XML\SanPham\QLSP.xml";

            doc.Load(QLSPFileName);
            root = doc.DocumentElement;
            XmlNode sanPhamCu = root.SelectSingleNode("SanPham[@MaHang ='" + QLSPedtMaHang.Text + "']");

            if (sanPhamCu != null)
            {
                XmlNode sanPhamSuaMoi = doc.CreateElement("SanPham");

                XmlAttribute mahang = doc.CreateAttribute("MaHang");
                mahang.Value = QLSPedtMaHang.Text;
                sanPhamSuaMoi.Attributes.Append(mahang);

                XmlElement tenhang = doc.CreateElement("TenHang");
                tenhang.InnerText = QLSPedtTenHang.Text;
                sanPhamSuaMoi.AppendChild(tenhang);

                XmlElement soluong = doc.CreateElement("SoLuong");
                soluong.InnerText = QLSPedtSoLuong.Text;
                sanPhamSuaMoi.AppendChild(soluong);

                XmlElement dongia = doc.CreateElement("DonGia");
                dongia.InnerText = QLSPedtDonGia.Text;
                sanPhamSuaMoi.AppendChild(dongia);

                root.ReplaceChild(sanPhamSuaMoi, sanPhamCu);
                doc.Save(QLSPFileName);
                QLSPHienThi(QLSPdgv);
            }
        }

        private void QLSPbtnXoa_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            string QLSPFileName = @"D:\XML\XML_BTL\XML_BTL\XML\SanPham\QLSP.xml";

            doc.Load(QLSPFileName);
            root = doc.DocumentElement;

            XmlNode sanPhamCanXoa = root.SelectSingleNode("SanPham[@MaHang ='" + QLSPedtMaHang.Text + "']");
            if (sanPhamCanXoa != null)
            {
                root.RemoveChild(sanPhamCanXoa);
                doc.Save(QLSPFileName);
            }
            QLSPdgv.Rows.Clear();
            QLSPHienThi(QLSPdgv);
        }

        private void QLSPdgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int t = QLSPdgv.CurrentRow.Index;
            QLSPedtMaHang.Text = QLSPdgv.Rows[t].Cells[0].Value.ToString();
            QLSPedtTenHang.Text = QLSPdgv.Rows[t].Cells[1].Value.ToString();
            QLSPedtSoLuong.Text = QLSPdgv.Rows[t].Cells[2].Value.ToString();
            QLSPedtDonGia.Text = QLSPdgv.Rows[t].Cells[3].Value.ToString();
        }

        private void QLSPbtnTimKiem_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            string QLSPFileName = @"D:\XML\XML_BTL\XML_BTL\XML\SanPham\QLSP.xml";

            doc.Load(QLSPFileName);
            root = doc.DocumentElement;

            QLSPdgv.Rows.Clear();
            XmlNode sanPhamCanTim = root.SelectSingleNode("SanPham[@MaHang ='" + QLSPedtTimKiem.Text.Trim() + "']");
            if (sanPhamCanTim != null)
            {
                QLSPdgv.Rows.Add();
                QLSPdgv.Rows[0].Cells[0].Value = sanPhamCanTim.SelectSingleNode("@MaHang").Value;
                QLSPdgv.Rows[0].Cells[1].Value = sanPhamCanTim.SelectSingleNode("TenHang").InnerText;
                QLSPdgv.Rows[0].Cells[2].Value = sanPhamCanTim.SelectSingleNode("SoLuong").InnerText;
                QLSPdgv.Rows[0].Cells[3].Value = sanPhamCanTim.SelectSingleNode("DonGia").InnerText;
            }
        }
    }
}
