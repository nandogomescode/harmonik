using HarmonikData;
using System.Data;

namespace HarmonicServices
{
    public class Notes
    {

        private DAL _data = new DAL();

        public List<string?> GetNotas()
        {

            var outParam = new List<string>();            

            string query = $@"SELECT * FROM Notes";
            this._data._query = query;           

            return this._data.GetSqlTable().AsEnumerable().Select(row => row.Field<string>("NoteName")).ToList();                       

        }

        

    }
}
