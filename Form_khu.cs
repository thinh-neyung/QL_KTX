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
    public partial class Form_khu : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_khu()
        {
            InitializeComponent();
        }
        
        private void Form_khu_Load(object sender, EventArgs e)
        {
            String command = "select * from khu_nha";
            DataTable dt = kn.LayDuLieu(command);
            metroGrid1.DataSource = dt;

            metroSetTabControl1.Font = new Font("Segoe UI", 11);

            
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_main form_Main = new Form_main();
            form_Main.Show();
            this.Close();
        }

        private void metroSetSetTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            String id, ten, so_tang;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox2.Text;
            so_tang = metroSetTextBox3.Text;
            String command = "insert into khu_nha values('" + id + "','" + ten + "'," + so_tang + ")";
            if (id.Equals("") || ten.Equals("") ||so_tang.Equals(""))
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
                Form_khu_Load(sender, e);
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            String id, ten, so_tang;
            id = metroSetTextBox1.Text;
            ten = metroSetTextBox2.Text;
            so_tang = metroSetTextBox3.Text;
            String command = "update khu_nha set ten_khu='" + ten + "',so_tang=" + so_tang + " where id_khu='" + id + "'";
            String command2 = "select count(id_khu) from khu_nha where id_khu='" + id + "'";
            DataTable dt2 = kn.LayDuLieu(command2);
            if (id.Equals("") || ten.Equals("") || so_tang.Equals("") || dt2.Rows[0].ItemArray.GetValue(0).ToString().Equals("0"))
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
                Form_khu_Load(sender, e);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            String id = metroSetTextBox1.Text;
            String command = "delete from khu_nha where id_khu='" + id + "'";

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
                Form_khu_Load(sender, e);
            }
        }
    }
}
