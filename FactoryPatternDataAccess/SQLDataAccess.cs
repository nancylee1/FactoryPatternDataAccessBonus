﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDataAccess
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from SQLDataAccess.");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a  SQLDataAccess.");
        }
    }
}

