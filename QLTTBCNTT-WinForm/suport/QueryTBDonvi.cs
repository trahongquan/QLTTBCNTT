using QLTTBCNTT_WinForm.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm.suport
{
    internal class QueryTBDonvi
    {
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDS_TBDonvi()
        {
            DataTable bangXM = new DataTable();
            string query = "select * from TB_Donvi";// * se lay tat ca cac cot
            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi
                    dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return bangXM;
        }

        public void Insert(TBDonvi TBDV) // them
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into TB_Donvi values " +
                "(@idDonvi, @idThietbi, @DateBorrow, @DateReturn)";
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = TBDV.IdDonvi;   // gan cu the
                sqlCMD.Parameters.Add("@idThietbi", SqlDbType.NChar).Value = TBDV.IdThietbi;
                sqlCMD.Parameters.Add("@DateBorrow", SqlDbType.NChar).Value = TBDV.DateBorrow1;
                sqlCMD.Parameters.Add("@DateReturn", SqlDbType.NChar).Value = TBDV.DateReturn1;

                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void Modify(TBDonvi TBDV, int IdTBDonvi) // sua theo TT
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "UPDATE TB_Donvi SET " +
                "idDonvi=@idDonvi, idThietbi=@idThietbi, DateBorrow=@DateBorrow, DateReturn=@DateReturn" +
                "Where IdThieBi = " + IdTBDonvi;
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = TBDV.IdDonvi;   // gan cu the
                sqlCMD.Parameters.Add("@idThietbi", SqlDbType.NChar).Value = TBDV.IdThietbi;
                sqlCMD.Parameters.Add("@DateBorrow", SqlDbType.NChar).Value = TBDV.DateBorrow1;
                sqlCMD.Parameters.Add("@DateReturn", SqlDbType.NChar).Value = TBDV.DateReturn1;

                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Delete(int IdTBDonvi)    // xoa theo ma
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Delete DM_Donvi Where IdTBDonvi = @IdTBDonvi";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@IdTBDonvi", SqlDbType.Int).Value = IdTBDonvi;
                sqlCMD.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        #endregion
    }
}
