using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Qly_KTX
{
    public partial class Form_LoaiDichvu : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_LoaiDichvu()
        {
            InitializeComponent();
        }

        private void Form_LoaiDichvu_Load(object sender, EventArgs e)
        {
            String command = "select * from loai_dich_vu";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;


            numericUpDown1.Controls[0].Visible = false;
            numericUpDown2.Controls[0].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            String id, gia;
            id = metroSetTextBox5.Text;
            gia = numericUpDown2.Value.ToString();
            string command;
            if (metroSetRadioButton3.Checked == true)
            {
                command = "select * from loai_dich_vu where id_loai_dich_vu='" + id + "'";
                if (id.Equals(""))
                {
                    MetroMessageBox.Show(Owner, "Không thể tìm kiếm thông tin, kiểm tra lại thông tin");
                }
                else
                {
                    try
                    {
                        metroGrid2.DataSource = kn.LayDuLieu(command);
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(Owner, "Không thể tìm kiếm thông tin, kiểm tra lại thông tin");

                    }
                }
            }
            if (metroSetRadioButton5.Checked == true)
            {
                command = "select * from loai_dich_vu where gia_1thang = " + gia;
                if (gia.Equals(""))
                {
                    MetroMessageBox.Show(Owner, "Không thể tìm kiếm thông tin, kiểm tra lại thông tin");
                }
                else
                {
                    try
                    {
                        metroGrid2.DataSource = kn.LayDuLieu(command);
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(Owner, "Không thể tìm kiếm thông tin, kiểm tra lại thông tin");

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            String id, ten, gia;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox3.Text;
            gia = numericUpDown1.Value.ToString();
            String command = "insert into loai_dich_vu values('" + id + "','" + ten + "'," + gia + ")";
            if (id.Equals("") || ten.Equals("") || gia.Equals("") )
            {
                MetroMessageBox.Show(Owner, "Không thể thêm, kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    kn.ThucThi(command);
                    MetroMessageBox.Show(Owner, "Thêm thành công");
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(Owner, "Không thể thêm, kiểm tra lại thông tin");

                }
                Form_LoaiDichvu_Load(sender, e);
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, ten, gia;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox3.Text;
            gia = numericUpDown1.Value.ToString();
            String command = "update loai_dich_vu set ten_loai='" + ten + "',gia_1thang=" + gia + " where id_loai_dich_vu='" + id + "'";
            String command2 = "select count(id_loai_dich_vu) from loai_dich_vu where id_loai_dich_vu='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || ten.Equals("") || gia.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
            {
                MetroMessageBox.Show(Owner, "Không thể sửa , kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    kn.ThucThi(command);
                    MetroMessageBox.Show(Owner, "Sửa thành công");
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(Owner, "Không thể sửa, kiểm tra lại thông tin");

                }
                Form_LoaiDichvu_Load(sender, e);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from loai_dich_vu where id_loai_dich_vu='" + id + "'";

            String command2 = "select count(id_loai_dich_vu) from loai_dich_vu where id_loai_dich_vu='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
            {
                MetroMessageBox.Show(Owner, "Không thể xóa, kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    kn.ThucThi(command);
                    MetroMessageBox.Show(Owner, "Xóa thành công");
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(Owner, "Không thể xóa, kiểm tra lại thông tin");

                }
                Form_LoaiDichvu_Load(sender, e);
            }
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_main f = new Form_main();
            f.Show();
            this.Close();
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            Form_Hoadon f = new Form_Hoadon();
            f.Show();
            this.Hide();
        }
    }
}
