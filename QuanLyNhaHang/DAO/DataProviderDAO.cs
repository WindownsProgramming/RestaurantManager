using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class DataProviderDAO
    {
        private static DataProviderDAO provider;

        public static DataProviderDAO Provider
        {
            get 
            {
                if (provider == null)
                    provider = new DataProviderDAO();
                return provider;
                
            }
            set { DataProviderDAO.provider = value; }
        }
        private DataProviderDAO() { }//hàm khởi tạo
        //chuỗi kết nối
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLNhaHang;User ID=sa;Password=1";

        //ExcuteQuery
        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            //tao ket noi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(data);

                connection.Close();
            }
            return data;

        }

        //trả về số dòng thành công 
        public int ExcuteNonQuery(string query)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))//tao ket noi
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;

        }
        //trả về ô đầu tiên của bảng kết quả
        public object ExcuteScalar(string query)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))//tao ket noi
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;

        }


    }
}
