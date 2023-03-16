using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerXCittà
{
    public class DataBase
    {
        private SqlConnectionStringBuilder connectionStringBuilder
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = "WINAPHS2OH2TH8K\\SQLEXPRESS";
                builder.InitialCatalog = "AcademyNet";
                builder.IntegratedSecurity = true; //unione tra sistemi diversi, aumenta livello di sicurezza integrato, APPROFONDIRE
                return builder;
            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionStringBuilder.ConnectionString);
        }

        public DataTable GetListaCittà()
        {
            var conn = GetConnection();
            var sda = new SqlDataAdapter("select DISTINCT c.city from sales.customers c order by city" , conn);
            var dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        public DataTable GetListaCustomerXCity(string x)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("dbo.getClienteXCittà", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@città",x);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
