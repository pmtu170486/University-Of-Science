﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoSQLite_Contact
{
    public class Contact
    {
        [SQLite.PrimaryKey,SQLite.AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}
