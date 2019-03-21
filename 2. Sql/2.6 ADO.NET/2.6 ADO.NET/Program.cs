using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=MyDataBase;Integrated Security=True";

            new BdOperations(connectionString);
            
            Console.ReadKey();
        }
    }
}
