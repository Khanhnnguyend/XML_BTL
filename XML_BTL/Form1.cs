using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hd_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = hd_grid.CurrentCell.RowIndex;
            txt_hd_masp.Text = hd_grid.Rows[i].Cells[0].ToString();
            txt_hd_tensp.Text = hd_grid.Rows[i].Cells[1].ToString();
            txt_hd_sl.Text = hd_grid.Rows[i].Cells[2].ToString();
            txt_hd_dg.Text = hd_grid.Rows[i].Cells[3].ToString();



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

            //Double tong = 0;
            //for(int i=1; i < row; i++)
            //{
            //    //tong += double.Parse(hd_grid.Rows[i].Cells[0].Value.ToString());

            //}
            //txt_hd_tongtien.Text = tong.ToString();
        }
    }
}
