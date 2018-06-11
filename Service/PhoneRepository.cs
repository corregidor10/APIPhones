using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model;

namespace Service
{
   public class PhoneRepository
    {
        public static async Task<IEnumerable<Phone>> GetAllPhones()
        {
            IEnumerable<Phone> phoneList;

            var builder = GetConnectionString();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                await connection.OpenAsync();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT Id, Name, Brand, Descripton, Color, ImageUrl, Price ");
                sb.Append("FROM PHONES");
                String sql = sb.ToString();

                phoneList = await connection.QueryAsync<Phone>(sql);

            }

            return phoneList;
        }

        public static async Task<PhoneDetail> GetPhoneDetail(int id)
        {
            PhoneDetail phone;
            var builder = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                await connection.OpenAsync();
                StringBuilder sb = new StringBuilder();
                sb.Append($"SELECT Id, Name, Brand, Descripton, Color, ImageUrl, Price, Height, Width, SO, Scoring ");
                sb.Append("FROM PHONES ");
                sb.Append($"WHERE Id={id}");
                String sql = sb.ToString();

                phone = await connection.QueryFirstAsync<PhoneDetail>(sql);

            }

            return phone;

        }

        private static SqlConnectionStringBuilder GetConnectionString()
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder
                {
                    DataSource = "tcp:tajamarreactserver.database.windows.net",
                    UserID = "USER",
                    Password = "PASS",
                    InitialCatalog = "bbddreacttajamar"
                };
            return builder;
        }
    }
}
