using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStorageDemo.Models
{
    public sealed class PersonRepository
    {
        private SQLiteConnection conn;
        
        // Singleton of the database repository object.
        private static PersonRepository instance;
        public static PersonRepository Instance
        {
            get
            {
                if (instance == null)
                    throw new Exception("You must call Initialize before retrieving the singleton for the PersonRepository.");

                return instance;
            }
        }

        public static void Initialize(string filename)
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));

            if (instance != null)
                instance.conn.Dispose();

            instance = new PersonRepository(filename);
        }

        private PersonRepository(string dbPath)
        {
            //Create SQLite Connection
            conn = new SQLiteConnection(dbPath);

            //Create a SQLite Table
            conn.CreateTable<Person>();
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
    }
}