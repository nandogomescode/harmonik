using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicServices
{
    public class Notes
    {

        public List<string> GetNotas()
        {

            var outParam = new List<string>();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=HarmonikaDB;Trusted_Connection=True;";

            string query = $@"SELECT * FROM Notes";

            DataTable result = new DataTable();

            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {

                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {

                    result.Load(reader);

                }
            }

            return outParam = result.AsEnumerable().Select(row => row.Field<string>("NoteName")).ToList();                       

        }

    }
}
