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
    public partial class Form_sinhvien : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_sinhvien()
        {
            InitializeComponent();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void Form_sinhvien_Load(object sender, EventArgs e)
        {
            metroSetTabControl1.Font = new Font("Segoe UI", 11);

            String command = "select * from sinh_vien";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;

            string command2 = "select * from phong";
            DataTable dt2 = kn.LayDuLieu(command2);
            metroSetComboBox1.DataSource = dt2;
            metroSetComboBox1.DisplayMember = "id_phong";
            metroSetComboBox2.DataSource = dt2;
            metroSetComboBox2.DisplayMember = "id_phong";

            metroSetRadioButton5.Checked = true;

        }

        public static implicit operator Form_sinhvien(Form_canbo v)
        {
            throw new NotImplementedException();
        }

        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            String id, ten, gioitinh, ngaysinh, sdt, cccd, id_phong;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox2.Text;
            if (metroSetRadioButton1.Checked == true)
            {
                gioitinh = "nam";
            }
            else { gioitinh = "nu"; }
            DateTime date = metroDateTime1.Value;
            ngaysinh = date.Year + "-" + date.Month + "-" + date.Day;
            sdt = metroSetTextBox3.Text;
            cccd = metroSetTextBox4.Text;
            id_phong = metroSetComboBox1.Text;
            String command = "insert into sinh_vien values('" + id + "','" + ten + "','" + gioitinh + "','" + ngaysinh + "','" + sdt + "','" + cccd + "','" + id_phong + "')";
            if (id.Equals("") || ten.Equals("") || sdt.Equals("") || cccd.Equals(""))
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
                Form_sinhvien_Load(sender, e);
            }


        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, ten, gioitinh, ngaysinh, sdt, cccd, id_phong;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox2.Text;
            if (metroSetRadioButton1.Checked == true)
            {
                gioitinh = "nam";
            }
            else { gioitinh = "nu"; }
            DateTime date = metroDateTime1.Value;
            ngaysinh = date.Year + "-" + date.Month + "-" + date.Day;
            sdt = metroSetTextBox3.Text;
            cccd = metroSetTextBox4.Text;
            id_phong = metroSetComboBox1.Text;
            String command = "update sinh_vien set ho_va_ten='" + ten + "',gioi_tinh='" + gioitinh + "' ,ngay_sinh='" + ngaysinh + "' ,sdt ='" + sdt + "',cccd='" + cccd + "' ,id_phong='" + id_phong + "' where ma_sinh_vien='" + id + "'";
            
            String command2 = "select count(ma_sinh_vien) from sinh_vien where ma_sinh_vien='"+id+"'";
            DataTable dt2 = kn.LayDuLieu(command2);

            if (id.Equals("") || ten.Equals("") || sdt.Equals("") || cccd.Equals("")|| dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
            {
                MetroMessageBox.Show(Owner, "Không thể sửa thông tin, kiểm tra lại thông tin");
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
                Form_sinhvien_Load(sender, e);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from sinh_vien where ma_sinh_vien='" + id + "'";

            String command2 = "select count(ma_sinh_vien) from sinh_vien where ma_sinh_vien='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);

            if (id.Equals("")|| dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
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
                Form_sinhvien_Load(sender, e);
            }
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_main form_Main = new Form_main();
            form_Main.Show();
            this.Close();
        }

        private void metroSetRadioButton4_CheckedChanged(object sender)
        {
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            String id, ten, id_phong;
            id = metroSetTextBox5.Text;
            ten = metroSetTextBox6.Text;
            id_phong = metroSetComboBox2.Text;
            string command;
            if (metroSetRadioButton3.Checked == true)
            {
                command = "select * from sinh_vien where ma_sinh_vien='" + id + "'";
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
            if (metroSetRadioButton4.Checked == true)
            {
                command = "select * from sinh_vien where ho_va_ten LIKE '%" + ten + "%'";
                if (ten.Equals(""))
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
                command = "select * from sinh_vien where id_phong='" + id_phong + "'";
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

        private void metroSetRadioButton3_CheckedChanged(object sender)
        {
        }

        private void metroSetRadioButton5_CheckedChanged(object sender)
        {
        }

        private void metroSetSetTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
