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
                XmlNodeList nodeFind = hd_root.SelectNodes("hoadon[khachhang[@makh='"+txt_hd_timkiem+"']]");

                int sd = 0;
                foreach (XmlNode node in nodeFind)
                {
                    hd_grid_dshd.Rows.Add();
                    hd_grid_dshd.Rows[sd].Cells[0].Value = node.SelectSingleNode("@mahd").Value;
                    hd_grid_dshd.Rows[sd].Cells[1].Value = node.SelectSingleNode("khachhang").SelectSingleNode("@makh").Value;
                    hd_grid_dshd.Rows[sd].Cells[2].Value = node.SelectSingleNode("ngaytao").InnerText;
                    hd_grid_dshd.Rows[sd].Cells[3].Value = node.SelectSingleNode("tongtien").InnerText;
                    sd++;
                }
            }
        }
    }
}
