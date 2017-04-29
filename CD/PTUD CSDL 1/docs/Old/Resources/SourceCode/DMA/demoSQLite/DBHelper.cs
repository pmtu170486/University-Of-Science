using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;
namespace demoSQLite
{
    class DBHelper
    {
        SQLiteConnection dbConn;
        public async Task<bool> oncreate(string db_path)
        {
            try
            {
                if (await checkFileExists(db_path) == false)
                {
                    using (dbConn = new SQLiteConnection(db_path))
                    {
                        dbConn.CreateTable<Contact>();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public async Task<bool> checkFileExists(string filename)
        {
            try
            {
                var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(filename);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void insert(Contact ct)
        {
            using (var db = new SQLiteConnection("test.db"))
            {
                db.Insert(ct);
            }
        }
        public ObservableCollection<Contact> readContacts()
        {
            using (var db = new SQLiteConnection("test.db"))
            {
                List<Contact> lst = db.Table<Contact>().ToList<Contact>();
                return new ObservableCollection<Contact>(lst);
            }

        }
    }
}
