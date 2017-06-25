using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngishTime.Models
{
    [Table("Words")]
    public class Word
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }

        public string En { get; set; }
        public string Ru { get; set; }
    }
}
