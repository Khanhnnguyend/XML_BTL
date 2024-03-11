using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace XML_BTL
{
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
        }
       


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string Username = txtName.Text;
            string Password = txtPass.Text;

            if (ktra(Username, Password))
            {
                Form1 form1 = new Form1();
                form1.Show();


            }
            
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
            }
        }


        static bool ktra(string username, string password)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root_nv;

            string fileName = @"C:\Học Tập\XML\XML_BTL\XML_BTL\QLnhanvien.xml";
            doc.Load(fileName);
            root_nv = doc.DocumentElement;

            foreach (XmlNode nhanVien in root_nv.SelectNodes("//Nhanvien"))
            {
                string storedUsername = nhanVien.SelectSingleNode("@MaNV").InnerText;
                string storedPassword = nhanVien.SelectSingleNode("Password").InnerText;

                // Kiểm tra xem username và password có khớp hay không
                if (username == storedUsername && password == storedPassword)
                {
                    return true;
                }
            }

            return false;
        }

        static string getmanv(string Username)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root_nv;

            string fileName = @"C:\Học Tập\XML\XML_BTL\XML_BTL\QLnhanvien.xml";
            doc.Load(fileName);
            root_nv = doc.DocumentElement;

            // Tìm employeeNode chứa username tương ứng
            XmlNode employeeNode = root_nv.SelectSingleNode($"//Nhanvien[MaNV='{Username}']");
            return employeeNode.SelectSingleNode("@MaNV").InnerText;
        }
    }

}



      

