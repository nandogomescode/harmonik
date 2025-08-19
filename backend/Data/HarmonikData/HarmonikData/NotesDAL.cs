using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.Serialization;

namespace HarmonikData.NotesDAL
{

    #region RECORD CLASS
    [DataContract]
    public class NotesRecord
    {

        [Required]
        [DataMember]
        public int NoteId { get; set; }

        [Required]
        [DataMember]
        public string NoteName { get; set; }

        [Required]
        [DataMember]
        public string NoteKey { get; set; }

        public NotesRecord()
        {

            NoteId = 0;
            NoteName = string.Empty;
            NoteKey = string.Empty;

        }
    }
    #endregion RECORD CLASS

    #region CONTROL CLASS
    public class Notes : DAL
    {
        
        private string _table = "Notes";

        private void GenerateParameters()
        {



        }

        public NotesRecord Get()
        {

            var record = new NotesRecord();

            this.query = $@"SELECT * FROM {this._table} WHERE NoteId = @Id";

            DataRow row = GetSqlTable();

            record.NoteId = Convert.ToInt32(row["NoteId"]);


            return record;

        }

    }
    #endregion CONTROL CLASS
}
