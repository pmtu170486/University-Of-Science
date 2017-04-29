using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace demoMyTiles
{
    public class note
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date{get;set;}
    }
}
