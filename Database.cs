﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer.Data
{
    public static class Database
    {
        private static string connectionString = "Server=.; Database=dealer_ship; Integrated Security=true";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
