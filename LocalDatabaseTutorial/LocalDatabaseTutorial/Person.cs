﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDatabaseTutorial
{
    public class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
