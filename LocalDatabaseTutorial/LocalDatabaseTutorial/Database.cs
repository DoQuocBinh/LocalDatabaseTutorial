using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabaseTutorial
{
    public class Database
    {
        //
        readonly SQLiteAsyncConnection _database;
        //dbPath: la duong dan cua File Database
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            //Tao bang Person sau khi tao database
            _database.CreateTableAsync<Person>().Wait();

        }

        //Save 1 object Person vao table Person
        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
        //Lay tat ca Person trong table Person
        public  Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }
    }
}
