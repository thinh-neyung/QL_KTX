using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_KTX
{
    public partial class Form_Hoadon : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_Hoadon()
        {
            InitializeComponent();
        }

        private void metroSetTextBox11_Click(object sender, EventArgs e)
        {

        }

        private void vbButton8_Click(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            string id = metroSetTextBox5.Text;
            string id_cb = metroSetTextBox6.Text;
            string id_sv = metroSetTextBox13.Text;
            string command;
            if (metroSetRadioButton3.Checked == true)
            {
                
                command = "select * from hoa_don_dich_vu where id_hoa_don='" + id + "'";
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
            if (metroSetRadioButton1.Checked == true)
            {
                command = "select * from hoa_don_dich_vu where ma_sinh_vien='" + id_sv + "'";
                if (id_sv.Equals(""))
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
            if (metroSetRadioButton4.Checked == true)
            {
                command = "select * from hoa_don_dich_vu where id_can_bo='" + id_cb + "'";
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

        private void Form_Hoadon_Load(object sender, EventArgs e)
        {
            String command = "select * from hoa_don_dich_vu";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;

            metroSetTabControl1.Font = new Font("Segoe UI", 11);

            string command2 = "select * from loai_dich_vu";
            DataTable dt2 = kn.LayDuLieu(command2);
            metroSetComboBox1.DataSource = dt2;
            metroSetComboBox1.DisplayMember = "id_loai_dich_vu";

        }

        private void metroSetSetTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_LoaiDichvu form_Main = new Form_LoaiDichvu();
            form_Main.Show();
            this.Close();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            String id, id_dv,ngaytao,ngaytt,id_cb,id_sv,nd,sothang,tt;
            id = metroSetTextBox1.Text;
            id_cb = metroSetTextBox10.Text;
            id_sv = metroSetTextBox11.Text;
            nd = metroSetTextBox9.Text;
            sothang = numericUpDown1.Text;
            id_dv = metroSetComboBox1.Text;
            DateTime date = metroDateTime1.Value;
            DateTime date2 = metroDateTime2.Value;
            ngaytao = date.Year + "-" + date.Month + "-" + date.Day;
            ngaytt = date2.Year + "-" + date2.Month + "-" + date2.Day;
            tt= metroSetTextBox7.Text;

            String command = "insert into hoa_don_dich_vu values('" + id + "','" + id_dv + "','" + ngaytao + "','" + ngaytt + "','" + id_cb + "','" + id_sv + "','" + nd + "'," +sothang + "," +tt + ")";
            if (id.Equals("") ||id_cb.Equals("") ||id_sv.Equals("") ||nd.Equals("") ||sothang.Equals("") ||id_dv.Equals("") ||ngaytao.Equals("") ||ngaytt.Equals("") ||tt.Equals(""))
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
                Form_Hoadon_Load(sender, e);
            }
        }

        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            int gia1thang, sothang;
            sothang = int.Parse(numericUpDown1.Text);
            string sql = "select gia_1thang from loai_dich_vu where id_loai_dich_vu ='" + metroSetComboBox1.Text + "'";
            gia1thang = int.Parse(kn.LayDuLieu(sql).Rows[0].ItemArray.GetValue(0).ToString());
            metroSetTextBox7.Text = (gia1thang * sothang).ToString();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, id_dv, ngaytao, ngaytt, id_cb, id_sv, nd, sothang, tt;
            id = metroSetTextBox1.Text;
            id_cb = metroSetTextBox10.Text;
            id_sv = metroSetTextBox11.Text;
            nd = metroSetTextBox9.Text;
            sothang = numericUpDown1.Text;
            id_dv = metroSetComboBox1.Text;
            DateTime date = metroDateTime1.Value;
            DateTime date2 = metroDateTime2.Value;
            ngaytao = date.Year + "-" + date.Month + "-" + date.Day;
            ngaytt = date2.Year + "-" + date2.Month + "-" + date2.Day;
            tt = metroSetTextBox7.Text;

            String command = "update hoa_don_dich_vu set id_loai_dich_vu='" + id_dv + "',ngay_tao='" + ngaytao + "' ,ngay_thanh_toan='" +ngaytt + "' ,id_can_bo ='" + id_cb + "',ma_sinh_vien='" + id_sv + "' ,noi_dung='" + nd + "' ,so_thang='"+sothang+ "' ,tong_tien='"+tt+ "' where id_hoa_don='" + id + "'";
            String command2 = "select count(ma_sinh_vien) from hoa_don_dich_vu where ma_sinh_vien='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || id_cb.Equals("") || id_sv.Equals("") || nd.Equals("") || sothang.Equals("") || id_dv.Equals("") || tt.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
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
                Form_Hoadon_Load(sender, e);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from hoa_don_dich_vu where id_hoa_don='" + id + "'";

            String command2 = "select count(id_hoa_don) from hoa_don_dich_vu where id_hoa_don='" + id + "'";
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
                Form_Hoadon_Load(sender, e);
            }
        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
