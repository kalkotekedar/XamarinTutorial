using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DataStorageDemo.Models
{
    [Table("People")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }
    }
}