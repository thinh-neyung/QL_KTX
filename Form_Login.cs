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
    public partial class Form_Login : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string id, pass;
            id = textBox1.Text;
            pass = textBox2.Text;
            string sql = "select mat_khau from tai_khoan where ten_dang_nhap='" + id + "'";
            try
            {
                string a = kn.LayDuLieu(sql).Rows[0].ItemArray.GetValue(0).ToString();
                if (pass.Equals(a))
                {
                    Form_main f = new Form_main();
                    f.Show();
                    this.Hide();
                }
            }
            catch(Exception)
            {
                MetroMessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không chính xác");
            }
            
        }
    }
}
