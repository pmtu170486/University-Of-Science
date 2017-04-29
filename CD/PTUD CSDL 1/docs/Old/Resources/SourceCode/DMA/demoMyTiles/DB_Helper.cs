using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace demoMyTiles
{
    class DB_Helper
    {
        private SQLiteConnection conn;
        private string db_name = "note.db";
        public DB_Helper()
        {
            
        }
        public async Task<bool> onCreate()
        {
            if (await checkExists(db_name) == false)
            {
                conn = new SQLiteConnection(db_name);
                conn.CreateTable<note>();
                return true;
            }
            return false;
        }
        public async Task<bool> checkExists(string filename)
        {
            try
            {
                var s = await Windows.Storage
                    .ApplicationData.Current
                    .LocalFolder.GetFileAsync(filename);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void insert(note n)
        {
            using(var conn=new SQLiteConnection(db_name))
            {
                conn.RunInTransaction(() => {
                    conn.Insert(n);
                });
            }
        }
        public List<note> readnotes()
        {
            using (var conn = new SQLiteConnection(db_name))
            {
                List<note> lst = conn.Table<note>().ToList();
                return lst;
            } 
        }
    }
}
