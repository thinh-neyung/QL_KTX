using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Qly_KTX
{
    public partial class Form_canbo : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();

        public Form_canbo()
        {
            InitializeComponent();
        }
        private void unableall_timkiem()
        {
            metroSetTextBox5.Enabled = false;
            metroSetTextBox6.Enabled = false;
            metroSetComboBox2.Enabled = false;
        }
        private void Form_canbo_Load(object sender, EventArgs e)
        {
            String command = "select * from can_bo";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;

            metroSetTabControl1.Font = new Font("Segoe UI", 11);

            string command2 = "select * from khu_nha";
            DataTable dt2 = kn.LayDuLieu(command2);
            metroSetComboBox1.DataSource = dt2;
            metroSetComboBox1.DisplayMember = "id_khu";
            metroSetComboBox2.DataSource = dt2;
            metroSetComboBox2.DisplayMember = "id_khu";


            metroSetRadioButton5.Checked = true;

        }


        private void metroSetRadioButton3_CheckedChanged(object sender)
        {
        }

        private void metroSetRadioButton4_CheckedChanged(object sender)
        {
        }

        private void metroSetButton1_Click_1(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from can_bo where id_can_bo='" + id + "'";

            String command2 = "select count(ma_sinh_vien) from sinh_vien where ma_sinh_vien='" + id + "'";
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
                Form_canbo_Load(sender, e);
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            String id, ten, gioitinh, ngaysinh, sdt, cccd, id_khu;
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
            id_khu = metroSetComboBox1.Text;
            String command = "insert into can_bo values('" + id + "','" + ten + "','" + gioitinh + "','" + ngaysinh + "','" + sdt + "','" + cccd + "','" + id_khu + "')";
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
                Form_canbo_Load(sender, e);
            }


        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, ten, gioitinh, ngaysinh, sdt, cccd, id_khu;
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
            id_khu = metroSetComboBox1.Text;
            String command = "update can_bo set ho_va_ten='" + ten + "',gioi_tinh='" + gioitinh + "' ,ngay_sinh='" + ngaysinh + "' ,sdt ='" + sdt + "',cccd='" + cccd + "' ,id_khu='" + id_khu + "' where id_can_bo='" + id + "'";
            String command2 = "select count(ma_sinh_vien) from sinh_vien where ma_sinh_vien='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || ten.Equals("") || sdt.Equals("") || cccd.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
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
                Form_canbo_Load(sender, e);
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            String id, ten, id_khu;
            id = metroSetTextBox5.Text;
            ten = metroSetTextBox6.Text;
            id_khu = metroSetComboBox2.Text;
            string command;
            if (metroSetRadioButton3.Checked == true)
            {
                command = "select * from can_bo where id_can_bo='" + id + "'";
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
                command = "select * from can_bo where ho_va_ten LIKE '%" + ten + "%'";
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
                command = "select * from can_bo where id_khu='" + id_khu + "'";
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

        private void metroSetRadioButton5_CheckedChanged(object sender)
        {
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_main form_Main = new Form_main();
            form_Main.Show();
            this.Close();
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
