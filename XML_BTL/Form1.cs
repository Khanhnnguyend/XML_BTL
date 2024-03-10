using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_BTL
{
    public partial class Form1 : Form
    {

        XmlDocument hd_doc = new XmlDocument(), kh_doc = new XmlDocument() , sp_doc = new XmlDocument();
        XmlElement hd_root, kh_root, sp_root;
        string hd_fileName = @"D:\Git local reponsitory\XML_BTL\XML_BTL\XML\HoaDon\hoadon.xml"
        , kh_fileName = @"D:\Git local reponsitory\XML_BTL\XML_BTL\XML\KhachHang\KhachHang.xml"
        , sp_fileName = @"D:\Git local reponsitory\XML_BTL\XML_BTL\XML\SanPham\QLSP.xml";

        public Form1()
        {
            InitializeComponent();
        }
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

        private void hd_dsbtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthidshoadon();
        }

        private void hd_grid_dshd_MouseClick(object sender, MouseEventArgs e)
        {
            int i = hd_grid_dshd.CurrentCell.RowIndex;
            if(i < hd_grid_dshd.Rows.Count-1)
            {
                string mahd = hd_grid_dshd.Rows[i].Cells[0].Value.ToString();
                hienthichitethoadon(mahd);
            }
            else
                hd_grid_chitiet.Rows.Clear();
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
            } else if (hd_rbkh.Checked)
            {
                XmlNodeList nodeHoaDon = hd_root.SelectNodes("hoadon");
                int sd = 0;

                foreach (XmlNode xmlNode in nodeHoaDon)
                {
                    XmlNode node = xmlNode.SelectSingleNode("khachhang[@makh='" + txt_hd_timkiem.Text + "']");
                    if(node!= null)
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

        private void btnTK_DoanhThu_Click(object sender, EventArgs e)
        {
            lbTK_content.Text = "Doanh thu theo ngày";
            List<(DateTime, int)> DoanhThu = new List<(DateTime, int)>();

            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;
            XmlNodeList DSHoaDon = hd_root.SelectNodes("hoadon");

            int n = DSHoaDon.Count;
            int j = 0;
            DoanhThu.Add((DateTime.Parse(DSHoaDon[0].SelectSingleNode("ngaytao").InnerText).Date, 0));

            for (int i = 0; i < n; i++ )
            {
                DateTime currentDate = DateTime.Parse(DSHoaDon[i].SelectSingleNode("ngaytao").InnerText);
                int tongtien = int.Parse(DSHoaDon[i].SelectSingleNode("tongtien").InnerText);
                if (DoanhThu[j].Item1 != currentDate.Date)
                {
                    j++;
                    DoanhThu.Add((currentDate.Date, 0));
                }
                DoanhThu[j] = (currentDate.Date, tongtien + DoanhThu[j].Item2);
            }

            DataTable tb = new DataTable();
            tb.Columns.Add("Ngày");
            tb.Columns.Add("Doanh thu");

            for (int i = 0;i <= j;i++)
            {
                DataRow row = tb.NewRow();
                row["Ngày"] = DoanhThu[i].Item1;
                row["Doanh thu"] = DoanhThu[i].Item2;
                tb.Rows.Add(row);
            }
            dgvTK.DataSource = tb;
        }
        private void btnTK_KhachMuaNhieu_Click(object sender, EventArgs e)
        {
            lbTK_content.Text = "Khách hàng mua nhiều trong tháng "+ DateTime.Now.Month;
            Dictionary<String, int> KhachPaid = new Dictionary<string, int>();

            kh_doc.Load(kh_fileName);
            kh_root = kh_doc.DocumentElement;
            XmlNodeList DSKH = kh_root.SelectNodes("KhachHang");

            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;
            XmlNodeList DSHoaDon = hd_root.SelectNodes("hoadon");

            int n = DSHoaDon.Count;
            int j = 0;
            for(int i = 0;i<n; i++)
            {
                if (DateTime.Parse(DSHoaDon[i].SelectSingleNode("ngaytao").InnerText).Month == DateTime.Now.Month)
                {
                    String maK = DSHoaDon[i].SelectSingleNode("khachhang").SelectSingleNode("@makh").Value;
                    int tongtien = int.Parse(DSHoaDon[i].SelectSingleNode("tongtien").InnerText);
                    if (KhachPaid.ContainsKey(maK))
                    {
                        KhachPaid[maK] += tongtien;
                    }
                    else
                    {
                        KhachPaid.Add(maK, tongtien);
                    }
                }
                
            }

            DataTable tb = new DataTable();
            tb.Columns.Add("Mã khách");
            tb.Columns.Add("Tên khách");
            tb.Columns.Add("Địa chỉ");
            tb.Columns.Add("SDT");
            tb.Columns.Add("Tổng tiền");
            foreach (var item in KhachPaid.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value))
            {
                DataRow row = tb.NewRow();
                row["Mã khách"] = item.Key;
                row["Tổng tiền"] = item.Value;
                foreach(XmlNode KH in DSKH)
                {
                    if(KH.SelectSingleNode("@MaK").Value.ToLower() == item.Key.ToLower())
                    {
                        row["Tên khách"] = KH.SelectSingleNode("tenKhach").InnerText;
                        row["Địa chỉ"] = KH.SelectSingleNode("diaChi").InnerText;
                        row["SDT"] = KH.SelectSingleNode("SDT").InnerText;
                    }
                }
                tb.Rows.Add(row);
            }

            dgvTK.DataSource = tb;
        }

        private void btnTK_HangBanCHay_Click(object sender, EventArgs e)
        {
            lbTK_content.Text = "Hàng bán chạy";
            Dictionary<String, int> SLHangBan = new Dictionary<string, int>();

            sp_doc.Load(sp_fileName);
            sp_root = sp_doc.DocumentElement;
            XmlNodeList DSSP = sp_root.SelectNodes("SanPham");

            hd_doc.Load(hd_fileName);
            hd_root = hd_doc.DocumentElement;
            XmlNodeList DSHoaDon = hd_root.SelectNodes("hoadon");

            foreach(XmlNode HoaDon in DSHoaDon)
            {
                if(DateTime.Parse(HoaDon.SelectSingleNode("ngaytao").InnerText).Month == DateTime.Now.Month)
                {
                    XmlNodeList SPs = HoaDon.SelectNodes("sanpham");
                    foreach (XmlNode SP in SPs)
                    {
                        String maSP= SP.SelectSingleNode("@masp").Value;
                        int SLsp = int.Parse(SP.SelectSingleNode("soluong").InnerText);
                        if (SLHangBan.ContainsKey(maSP))
                        {
                            SLHangBan[maSP] += SLsp;
                        }
                        else SLHangBan.Add(maSP, SLsp);
                    }
                }
            }
            

            DataTable tb = new DataTable();
            tb.Columns.Add("Mã SP");
            tb.Columns.Add("Tên SP");
            tb.Columns.Add("Giá");
            tb.Columns.Add("SL đã bán");

            foreach (var item in SLHangBan.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value))
            {
                DataRow row = tb.NewRow();
                row["Mã SP"] = item.Key;
                row["SL đã bán"] = item.Value;
                foreach (XmlNode sp in DSSP)
                {
                    if(sp.SelectSingleNode("@MaHang").Value == item.Key)
                    {
                        row["Tên SP"] = sp.SelectSingleNode("TenHang").InnerText;
                        row["Giá"] = sp.SelectSingleNode("DonGia");
                    }
                }
                tb.Rows.Add(row);
            }
            dgvTK.DataSource = tb;

        }
    }
}
