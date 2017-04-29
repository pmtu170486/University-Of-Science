using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoSQLite_Contact
{
    class DB_Helper
    {
        private  const string db_name = "test.db";
        public async Task<bool> checkDBExists()
        {
            try
            {
                var s = 
                    await Windows.Storage.ApplicationData.Current
                    .LocalFolder.GetFileAsync(db_name);
                return true; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private SQLite.SQLiteConnection conn;
        public async Task<bool> oncreate()
        {
            try
            {
                if(await checkDBExists()==false)
                {
                    conn = new SQLite.SQLiteConnection(db_name);
                    conn.CreateTable<Contact>();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void insert(Contact ct)
        {
            using(var conn=new SQLite.SQLiteConnection(db_name))
            {
                conn.RunInTransaction(() => {
                    conn.Insert(ct);
                });
            }
        }
        public List<Contact> readContact()
        {
            List<Contact> lst = new List<Contact>();
            using(var conn=new SQLite.SQLiteConnection(db_name))
            {
                lst = conn.Table<Contact>().ToList<Contact>();
                return lst;
            }
        }
    }
}
