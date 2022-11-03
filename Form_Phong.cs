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
    public partial class Form_Phong : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_Phong()
        {
            InitializeComponent();
        }

        private void metroSetRadioButton5_CheckedChanged(object sender)
        {

        }

        private void Form_Phong_Load(object sender, EventArgs e)
        {
            String command = "select * from phong";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;

            metroSetTabControl1.Font = new Font("Segoe UI", 11);

            string command2 = "select * from khu_nha";
            DataTable dt2 = kn.LayDuLieu(command2);
            metroSetComboBox3.DataSource = dt2;
            metroSetComboBox3.DisplayMember = "id_khu";
            metroSetComboBox4.DataSource = dt2;
            metroSetComboBox4.DisplayMember = "id_khu";

            string command3 = "select * from loai_phong";
            DataTable dt3 = kn.LayDuLieu(command3);
            metroSetComboBox1.DataSource = dt3;
            metroSetComboBox1.DisplayMember = "id_loai_phong";
            metroSetComboBox2.DataSource = dt3;
            metroSetComboBox2.DisplayMember = "id_loai_phong";

            metroSetRadioButton3.Checked = true;

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_main form_Main = new Form_main();
            form_Main.Show();
            this.Close();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            String id, ten, sv_toida, id_khu, loai_phong;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox2.Text;
            id_khu = metroSetComboBox3.Text;
            loai_phong = metroSetComboBox1.Text;
            sv_toida = metroSetTextBox3.Text;
            String command = "insert into phong values('" + id + "','" + ten + "'," + sv_toida + ",'" + loai_phong + "','" + id_khu + "')";
            if (id.Equals("") || ten.Equals("") ||sv_toida.Equals(""))
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
                Form_Phong_Load(sender, e);
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, ten, sv_toida, id_khu, loai_phong;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox2.Text;
            id_khu = metroSetComboBox3.Text;
            loai_phong = metroSetComboBox1.Text;
            sv_toida = metroSetTextBox3.Text;
            String command = "update phong set ten_phong='" + ten + "',sv_toi_da='" + sv_toida + "' ,id_loai_phong='" + loai_phong + "' ,id_khu ='" + id_khu  + "' where id_phong='" + id + "'";
            String command2 = "select count(id_phong) from phong where id_phong='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || ten.Equals("") || sv_toida.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
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
                Form_Phong_Load(sender, e);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from phong where id_phong='" + id + "'";

            String command2 = "select count(id_phong) from phong where id_phong='" + id + "'";
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
                Form_Phong_Load(sender, e);
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            String id, id_khu, loaiphong;
            id = metroSetTextBox4.Text;
            loaiphong = metroSetComboBox2.Text;
            id_khu = metroSetComboBox4.Text;
            string command;
            if (metroSetRadioButton3.Checked == true)
            {
                command = "select * from phong where id_khu='" + id_khu + "'";
                
                    try
                    {
                        metroGrid2.DataSource = kn.LayDuLieu(command);
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(Owner, "Không thể tìm kiếm thông tin, kiểm tra lại thông tin");

                    }
                
            }
            if (metroSetRadioButton1.Checked == true)
            {
                command = "select * from phong where id_loai_phong='" + loaiphong + "'";
                
                
                    try
                    {
                        metroGrid2.DataSource = kn.LayDuLieu(command);
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(Owner, "Không thể tìm kiếm thông tin, kiểm tra lại thông tin");

                    }
                
            }
            if (metroSetRadioButton2.Checked == true)
            {
                command = "select * from phong where id_phong='" + id + "'";
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

        private void vbButton5_Click(object sender, EventArgs e)
        {
            Form_Loaiphong form = new Form_Loaiphong();
            form.Show();
            this.Close();
        }
    }
}
