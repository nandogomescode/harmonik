using Microsoft.Data.SqlClient;
using System.Data;

namespace HarmonikData{

    public class DAL
    {
        public string query { get; set; }

        private string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=HarmonikaDB;Trusted_Connection=True;";

        public DataRow GetSqlTable()
        {

            var outParam = new DataTable();

            using(SqlConnection connection = new SqlConnection(this._connectionString))
            using(SqlCommand command = new SqlCommand(this.query, connection))
            {

                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {

                    outParam.Load(reader);

                }
            
            }

            return outParam.Rows[0];

        }

        public DataRow GetSqlRow()
        {

            DataTable outParam = new DataTable();


            using(SqlConnection connection = new SqlConnection(this._connectionString))
            using(SqlCommand command = new SqlCommand(this.query, connection))
            {

                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {

                    

                }

            }

            return outParam.Rows[0];

        }

        public void CreateSqlRegister()
        {




        }

        public void UpdateSqlRegister()
        {



        }

        public void DeleteSqlRegister()
        {




        }

        public void Excecute()
        {



        }

        public DataTable Query(string query)
        {

            DataTable outParam = new DataTable();            

            using(SqlConnection connection = new SqlConnection(this._connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {

                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {

                    outParam.Load(reader);

                }
            }

            return outParam;            

        }

        public void CreateParameter(string parameterName, DbType type, object value)         
        {

            //SqlClient
            //SqlParameter param = new SqlParameter();

            //param.ParameterName = parameterName;
            //param.DbType = type;
            //param.Value = value;
            
            

        }

    }
}
