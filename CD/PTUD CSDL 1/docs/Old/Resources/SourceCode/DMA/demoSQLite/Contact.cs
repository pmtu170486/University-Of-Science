using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoSQLite
{
    public class Contact
    {
        public Contact()
        {
            //empty constructor
        }
        [SQLite.PrimaryKey]
        public string name { get; set; }
        public string address { get; set; }
    }
}
