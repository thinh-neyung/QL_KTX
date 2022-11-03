using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Qly_KTX
{
    class KetNoi_CSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void ket_noi()
        {

            string strKetNoi = @"Data Source= DESKTOP-18GRVC9\SQLEXPRESS; Initial Catalog= QL_KTX; Integrated Security=True";
            cnn = new SqlConnection();
            cnn.ConnectionString = strKetNoi;
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable LayDuLieu(string Sql)
        {
            ket_noi();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            ket_noi();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
