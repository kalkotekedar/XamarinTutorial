using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStorageDemo.Models
{
    public sealed class PersonRepository
    {
        // Singleton of the database repository object.
        private static PersonRepository instance;

        private SQLiteConnection conn;

        //Sqlite connection for async methods
        private SQLiteAsyncConnection conn1;

        public static PersonRepository Instance
        {
            get
            {
                if (instance == null)
                    throw new Exception("You must call Initialize before retrieving the singleton for the PersonRepository.");

                return instance;
            }
        }

        //public static void Initialize(string filename)
        //{
        //    if (filename == null)
        //        throw new ArgumentNullException(nameof(filename));

        //    if (instance != null)
        //        instance.conn.Dispose();

        //    instance = new PersonRepository(filename);
        //}

        //private PersonRepository(string dbPath)
        //{
        //    //Create SQLite Connection
        //    conn = new SQLiteConnection(dbPath);

        //    //Create a SQLite Table
        //    conn.CreateTable<Person>();
        //}

        /** This is the constructor for async method **/
        public static void Initialize(string filename)
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));

            if (instance != null)
                instance.conn1.GetConnection().Dispose();

            instance = new PersonRepository(filename);
        }

        private PersonRepository(string dbPath)
        {
            //Create SQLite Connection
            conn1 = new SQLiteAsyncConnection(dbPath);

            //Create a SQLite Table
            conn1.CreateTableAsync<Person>().Wait();
        }

        public string StatusMessage { get; set; }

        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = conn.Insert(new Person { Name = name });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }
        }

        public IEnumerable<Person> GetAllPeople()
        {
            try
            {
                return conn.Table<Person>();

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return Enumerable.Empty<Person>();
        }

        /** Async methods for database operations **/
        public async Task AddPersonAsync(string name) {
            int result = 0;
            try {
                if (string.IsNullOrEmpty(name))
                    throw new Exception("String cann't be empty or invalid");

                result = await conn1.InsertAsync(new Person { Name = name });

                StatusMessage = string.Format("{0} records added successful [Name : {1}]", result, name);
            }
            catch (Exception e) {
                StatusMessage = string.Format("Failed to add {0} . Error {1}", name, e.Message);
            }
        }

        public async Task<IEnumerable<Person>> GetAllPersonAsync() {
            try
            {
                return await conn1.Table<Person>().ToListAsync();
            }
            catch (Exception ex) {
                StatusMessage = string.Format("Failed to retrive data. {0}", ex.Message);
            }

            return Enumerable.Empty<Person>();
        }
    }
}