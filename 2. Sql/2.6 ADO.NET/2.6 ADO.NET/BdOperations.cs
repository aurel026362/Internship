using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_ADO.NET
{
    class BdOperations
    {
        string connectionstring;
        DataTable test;
        DataTable PC;

        DataTable users, interns;

        public BdOperations(string connstring)
        {
            connectionstring = connstring;

            ShowDataConnection();
            SelectUsers();

            CreateTableTest();
            CreateTablePC();

            ReadData();

            //JoinTables();
            //Update();
            //SelectUsers();
        }

        public void ReadData()
        {
            DataSet ds = new DataSet();

            string select = "SELECT * FROM Users;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, connectionstring);
            dataAdapter.Fill(ds, "Users");
            
            foreach(DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine(r["FirstName"] + " " + r["LastName"]);
            }

            DataRow dr = ds.Tables["Users"].NewRow();
            dr["FirstName"] = "test";
            dr["LastName"] = "testL";
            dr["DateOfBirth"] = "2019-01-01";
            dr["NumberPhone"] = "+35435432432";
            dr["Login"] = "login";
            dr["Password"] = "pass";
            dr["EMail"] = "email@mail.ru";
            ds.Tables["Users"].Rows.Add(dr);

            dataAdapter.Update(ds, "Users");

            select = "SELECT * FROM Interns";
            dataAdapter = new SqlDataAdapter(select, connectionstring);
            dataAdapter.Fill(ds, "SecondTable");

            foreach (DataRow r in ds.Tables[1].Rows)
            {
                Console.WriteLine(r["Id"] + " " + r["UserId"]);
            }
        }

        public void JoinTables()
        {
            DataSet ds = new DataSet("newJoin");

            ds.Tables.Add(test);
            ds.Tables.Add(PC);

            Console.WriteLine("\n \n ------------------------");

            ds.Relations.Add("TestPc",

                test.Columns["Id"],
                PC.Columns["TestId"]
                );

            Console.WriteLine("List of tets:");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr["Id"] + " " + dr["Name"]);
            }

            Console.WriteLine("\nList of PCs:");
            foreach (DataRow dr in ds.Tables[1].Rows)
            {
                Console.WriteLine(dr["PcId"] + " " + dr["NamePC"]);
            }
            

        }

        public void CreateTablePC()
        {
            PC = new DataTable("PC");

            DataColumn id2 = new DataColumn("PcId", typeof(int));
            DataColumn Name2 = new DataColumn("NamePC", typeof(string));
            DataColumn Year = new DataColumn("Year", typeof(int));
            DataColumn TestId = new DataColumn("TestId", typeof(int));

            PC.Columns.Add(id2);
            PC.Columns.Add(Name2);
            PC.Columns.Add(Year);
            PC.Columns.Add(TestId);

            PC.PrimaryKey = new DataColumn[] { PC.Columns["PcId"] };

            DataRow newRow = PC.NewRow();
            newRow["PcId"] = 1;
            newRow["NamePC"] = "Acer";
            newRow["Year"] = 2010;
            newRow["TestId"] = 3;
            PC.Rows.Add(newRow);

            newRow = PC.NewRow();
            newRow["PcId"] = 2;
            newRow["NamePC"] = "Asus";
            newRow["Year"] = 2005;
            newRow["TestId"] = 1;
            PC.Rows.Add(newRow);

            newRow = PC.NewRow();
            newRow["PcId"] = 3;
            newRow["NamePC"] = "Dell";
            newRow["Year"] = 2019;
            newRow["TestId"] = 2;
            PC.Rows.Add(newRow);

            Console.WriteLine("\nNew Table PC:");

            foreach (DataRow dr in PC.Rows)
            {
                Console.WriteLine(dr["PcId"] + " " + dr["NamePC"] + " " + dr["Year"] + " " + dr["TestId"]);
            }

            Console.WriteLine("Tabel 2 is been created!");
        }

        public void CreateTableTest()
        {
            test = new DataTable("Test");

            DataColumn id = new DataColumn("Id", typeof(int));
            DataColumn Name = new DataColumn("Name", typeof(string));
            DataColumn For = new DataColumn("For", typeof(string));

            test.Columns.Add(id);
            test.Columns.Add(Name);
            test.Columns.Add(For);

            test.PrimaryKey = new DataColumn[] { test.Columns["Id"] };

            DataRow newRow = test.NewRow();
            newRow["Id"] = 1;
            newRow["Name"] = "Number1";
            newRow["For"] = "Asus";
            test.Rows.Add(newRow);

            newRow = test.NewRow();
            newRow["Id"] = 2;
            newRow["Name"] = "Number2";
            newRow["For"] = "Dell";
            test.Rows.Add(newRow);

            newRow = test.NewRow();
            newRow["Id"] = 3;
            newRow["Name"] = "Number3";
            newRow["For"] = "Acer";
            test.Rows.Add(newRow);

            Console.WriteLine("\nNew Table Test:");

            foreach (DataRow dr in test.Rows)
            {
                Console.WriteLine(dr["Id"] + " " + dr["Name"] + " " + dr["For"]);
            }

            Console.WriteLine("Tabel is been created!");
        }

        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string selectUsers = "UPDATE Users SET FirstName = @NewFirst, LastName = @NewLast WHERE Id = @id;";
                using (var sqlcommand = new SqlCommand(selectUsers, connection))
                {
                    Console.Write("Chose new First Name: ");
                    string newFName = Console.ReadLine();

                    Console.Write("Chose new Last Name: ");
                    string newLName = Console.ReadLine();

                    Console.Write("Chose id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    sqlcommand.Parameters.Add("@NewFirst", newFName);
                    sqlcommand.Parameters.Add("@NewLast", newLName);
                    sqlcommand.Parameters.Add("@id", id);

                    sqlcommand.ExecuteNonQuery();
                    Console.WriteLine("\nUpdate succes! ");
                }
            }
        }

        public void SelectUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string selectUsers = "SELECT Id, FirstName, LastName FROM Users;";
                using (var sqlcommand = new SqlCommand(selectUsers, connection))
                {
                    SqlDataReader usersReader = sqlcommand.ExecuteReader();
                    Console.WriteLine("\nList of users: ");
                    while (usersReader.Read())
                    {
                        long id = (long)usersReader["Id"];
                        string firstName = (string)usersReader["FirstName"];
                        string lastName = (string)usersReader["LastName"];
                        Console.WriteLine(id + " : "  + firstName + " " + lastName);
                    }
                }
            }
            Console.WriteLine();
        }

        public void ShowDataConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                Console.WriteLine("Connection opened");

                // Вывод информации о подключении
                Console.WriteLine("Data about connection:");
                Console.WriteLine("\tLine connection: {0}", connection.ConnectionString);
                Console.WriteLine("\tData Base: {0}", connection.Database);
                Console.WriteLine("\tServer: {0}", connection.DataSource);
                Console.WriteLine("\tServer Version: {0}", connection.ServerVersion);
                Console.WriteLine("\tMood: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);
            }
        }
    }
}
