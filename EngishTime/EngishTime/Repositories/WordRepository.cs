using EngishTime.Infrastructure;
using EngishTime.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EngishTime.Repositories
{
    public class WordRepository
    {
        SQLiteConnection database;
        public WordRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Word>();
        }
        public IEnumerable<Word> GetItems()
        {
            return (from i in database.Table<Word>() select i).ToList();

        }
        public Word GetItem(int id)
        {
            return database.Get<Word>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Word>(id);
        }
        public int SaveItem(Word item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
