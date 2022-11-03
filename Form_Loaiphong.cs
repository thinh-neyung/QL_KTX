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
    public partial class Form_Loaiphong : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_Loaiphong()
        {
            InitializeComponent();
        }

        private void Form_Loaiphong_Load(object sender, EventArgs e)
        {
            String command = "select * from loai_phong";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;

            metroSetTabControl1.Font = new Font("Segoe UI", 11);
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_Phong form = new Form_Phong();
            form.Show();
            this.Close();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            String id, tien;
            id = metroSetTextBox1.Text;
            tien = metroSetTextBox10.Text;
            String command = "insert into loai_phong values('" + id + "'," + tien + ")";
            if (id.Equals("") || tien.Equals(""))
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
                Form_Loaiphong_Load(sender, e);
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, tien;
            id = metroSetTextBox1.Text;
            tien = metroSetTextBox10.Text;
            String command = "update loai_phong set tien_phong="+ tien  +" where id_loai_phong='" + id + "'";
            String command2 = "select count(id_loai_phong) from loai_phong where id_loai_phong='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || tien.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
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
                Form_Loaiphong_Load(sender, e);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from loai_phong where id_loai_phong='" + id + "'";

            String command2 = "select count(id_loai_phong) from loai_phong where id_loai_phong='" + id + "'";
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
                Form_Loaiphong_Load(sender, e);
            }
        }
    }
}
