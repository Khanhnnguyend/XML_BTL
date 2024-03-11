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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace XML_BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement root_nv;
        String fileName = @"C:\Học Tập\XML\XML_BTL\XML_BTL\QLnhanvien.xml";


        public void Hienthi(DataGridView dgv)
        {
            doc.Load(fileName);
            root_nv = doc.DocumentElement;
            XmlNodeList dsnv = root_nv.SelectNodes("Nhanvien");
            int index = 0;
            foreach (XmlNode xn in dsnv)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = xn.SelectSingleNode("@MaNV").Value;
                dgv.Rows[index].Cells[1].Value = xn.SelectSingleNode("Hoten").InnerText;
                dgv.Rows[index].Cells[2].Value = xn.SelectSingleNode("Diachi").InnerText;
                dgv.Rows[index].Cells[3].Value = xn.SelectSingleNode("Gioitinh").InnerText;
                dgv.Rows[index].Cells[4].Value = xn.SelectSingleNode("Namsinh").InnerText;
                dgv.Rows[index].Cells[5].Value = xn.SelectSingleNode("Sdt").InnerText;
                dgv.Rows[index].Cells[6].Value = xn.SelectSingleNode("Password").InnerText;
                index++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi(nv_dataGridView1);
        }
        private void btn_themnv_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            root_nv = doc.DocumentElement;
            XmlNode nhanvien = doc.CreateElement("Nhanvien");

            XmlAttribute Manv = doc.CreateAttribute("MaNV");
            Manv.Value = txtManv.Text;
            nhanvien.Attributes.Append(Manv);

            XmlElement hoten = doc.CreateElement("Hoten");
            hoten.InnerText = txtHotennv.Text;
            nhanvien.AppendChild(hoten);

            XmlElement diachi = doc.CreateElement("Diachi");
            diachi.InnerText = txtDiachinv.Text;
            nhanvien.AppendChild(diachi);

            XmlElement gioitinh = doc.CreateElement("Gioitinh");
            gioitinh.InnerText = txtGioitinhnv.Text;
            nhanvien.AppendChild(gioitinh);

            XmlElement namsinh = doc.CreateElement("Namsinh");
            namsinh.InnerText = txtNamsinhnv.Text;
            nhanvien.AppendChild(namsinh);

            XmlElement sdt = doc.CreateElement("Sdt");
            sdt.InnerText = txtSdtnv.Text;
            nhanvien.AppendChild(sdt);

            XmlElement password = doc.CreateElement("Password");
            password.InnerText = txtPw.Text;
            nhanvien.AppendChild(password);

            root_nv.AppendChild(nhanvien);
            doc.Save(fileName);
            nv_dataGridView1.Rows.Clear();
            Hienthi(nv_dataGridView1);
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            Hienthi(nv_dataGridView1);
        }

        private void nv_dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int id = nv_dataGridView1.CurrentRow.Index;
            txtManv.Text = nv_dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtHotennv.Text = nv_dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtDiachinv.Text = nv_dataGridView1.Rows[id].Cells[2].Value.ToString();
            txtGioitinhnv.Text = nv_dataGridView1.Rows[id].Cells[3].Value.ToString();
            txtNamsinhnv.Text = nv_dataGridView1.Rows[id].Cells[4].Value.ToString();
            txtSdtnv.Text = nv_dataGridView1.Rows[id].Cells[5].Value.ToString();
            txtPw.Text = nv_dataGridView1.Rows[id].Cells[6].Value.ToString();
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            root_nv = doc.DocumentElement;
            XmlNode nhanviencu = root_nv.SelectSingleNode("Nhanvien[@MaNV='" + txtManv.Text + "']");
            if (nhanviencu != null)
            {

                XmlNode nhanvienmoi = doc.CreateElement("Nhanvien");
                XmlAttribute Manv = doc.CreateAttribute("MaNV");
                Manv.Value = txtManv.Text;
                nhanvienmoi.Attributes.Append(Manv);

                XmlElement hoten = doc.CreateElement("Hoten");
                hoten.InnerText = txtHotennv.Text;
                nhanvienmoi.AppendChild(hoten);

                XmlElement diachi = doc.CreateElement("Diachi");
                diachi.InnerText = txtDiachinv.Text;
                nhanvienmoi.AppendChild(diachi);

                XmlElement gioitinh = doc.CreateElement("Gioitinh");
                gioitinh.InnerText = txtGioitinhnv.Text;
                nhanvienmoi.AppendChild(gioitinh);

                XmlElement namsinh = doc.CreateElement("Namsinh");
                namsinh.InnerText = txtNamsinhnv.Text;
                nhanvienmoi.AppendChild(namsinh);

                XmlElement sdt = doc.CreateElement("Sdt");
                sdt.InnerText = txtSdtnv.Text;
                nhanvienmoi.AppendChild(sdt);

                XmlElement password = doc.CreateElement("Password");
                password.InnerText = txtPw.Text;
                nhanvienmoi.AppendChild(password);

                root_nv.ReplaceChild(nhanvienmoi, nhanviencu);
                doc.Save(fileName);
                nv_dataGridView1.Rows.Clear();
                Hienthi(nv_dataGridView1);
            }
            else MessageBox.Show("ko co");

        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            root_nv = doc.DocumentElement;
            XmlNode nhanvien = root_nv.SelectSingleNode("Nhanvien[@MaNV='" + txtManv.Text + "']");
            if (nhanvien != null)
            {
                root_nv.RemoveChild(nhanvien);
                doc.Save(fileName); nv_dataGridView1.Rows.Clear(); Hienthi(nv_dataGridView1);
                MessageBox.Show("Xoa thanh cong");
                
            }
            else{
                MessageBox.Show("Khong tim thay");
            }
        }
    }
}
