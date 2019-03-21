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

            SelectAndUpdate();
            //ShowDataConnection();
            //SelectUsers();

            //CreateTable();

            //Update();

            //ManipulatedData();


            //CreateTableTest();
            //CreateTablePC();
            //JoinTables();
            //SelectUsers();
        }

        public void CreateTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string create = "CREATE TABLE FakeTable( Id int , NameF nvarchar(20), number int);";
                using (var sqlcommand = new SqlCommand(create, connection))
                {
                    try
                    {
                        sqlcommand.ExecuteNonQuery();
                        Console.WriteLine("\nCreate tables succes! ");
                    }
                    catch
                    {

                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string create = "CREATE TABLE SecondFake( Id int, adress nvarchar(20), time_sec int);";
                using (var sqlcommand = new SqlCommand(create, connection))
                {
                    try
                    {
                        sqlcommand.ExecuteNonQuery();
                        Console.WriteLine("\nCreate tables succes! ");
                    }
                    catch
                    {

                    }
                }
            }
        }

        public void ManipulatedData()
        {
            DataSet ds = new DataSet();

            string select = "SELECT * FROM FakeTable;";

            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                connect.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, connect);
                SqlCommandBuilder combuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(ds, "FakeTable");

                Console.WriteLine("\nData from FakeTable: ");

                DataTable dt = ds.Tables["FakeTable"];

                DataRow dr = ds.Tables["FakeTable"].NewRow();
                dr["Id"] = 1;
                dr["NameF"] = "testName";
                dr["number"] = 2;
                dt.Rows.Add(dr);

                DataRow dr2 = ds.Tables["FakeTable"].NewRow();
                dr2["Id"] = 2;
                dr2["NameF"] = "secondName";
                dr2["number"] = 4;
                dt.Rows.Add(dr2);

                dataAdapter.Update(ds, "FakeTable");


                //dt.Rows.Remove(dr2);
                //dr2["Id"] = 2;
                //dr2["NameF"] = "unique";
                //dr2["number"] = 4;
                //dt.Rows.Add(dr2);

                //dataAdapter.Update(ds, "FakeTable");

                //dataAdapter.DeleteCommand = connect.CreateCommand();
                //dataAdapter.DeleteCommand.CommandText = "DELETE FROM FakeTable;";
                //dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataAdapter.InsertCommand = new SqlCommand("INSERT INTO FakeTable(Id, NameF, number) VALUES(9, 'eee', 123);", connect);
                var row = dt.NewRow();
                row["Id"] = 9;
                row["NameF"] = "eee";
                row["number"] = 1234;
                dt.Rows.Add(row);

                //dataAdapter.UpdateCommand = connect.CreateCommand();
                //dataAdapter.UpdateCommand.CommandText = "Update FakeTable SET NameF = 'NewValue' WHERE number = 123";
                //dataAdapter.UpdateCommand.ExecuteNonQueryAsync();

                dataAdapter.Update(dt);

                foreach (DataRow r in dt.Rows)
                {
                    Console.WriteLine(r["Id"] + " " + r["NameF"] + " " + r["number"]);
                }
            }
            Console.WriteLine("Update has been successful! ");
        }

        public void SelectAndUpdate()
        {
            DataSet datas = new DataSet();

            string select = "SELECT * FROM FakeTable;";
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand(select, connect);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command1);
                sqlDataAdapter.Fill(datas, "FakeTable");

                sqlDataAdapter.InsertCommand = new SqlCommand("INSERT INTO FakeTable(Id, NameF, number) values(@id,@nameF,@number)", connect);
                sqlDataAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.BigInt, 8, "Id");
                sqlDataAdapter.InsertCommand.Parameters.Add("@nameF", SqlDbType.VarChar, 50, "nameF");
                sqlDataAdapter.InsertCommand.Parameters.Add("@number", SqlDbType.BigInt, 8, "number");

                DataTable dt = datas.Tables["FakeTable"];
                var row = dt.NewRow();
                row["Id"] = 12;
                row["NameF"] = "o mers";
                row["number"] = 132312;
                dt.Rows.Add(row);

                row = dt.NewRow();
                row["Id"] = 13;
                row["NameF"] = "nu o mers";
                row["number"] = 1312;
                dt.Rows.Add(row);

                sqlDataAdapter.Update(datas, "FakeTable");
            }
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

                    sqlcommand.Parameters.Add("@NewFirst", SqlDbType.VarChar, 50).Value = newFName;
                    sqlcommand.Parameters.Add("@NewLast", SqlDbType.VarChar, 50).Value = newLName;
                    sqlcommand.Parameters.Add("@id", SqlDbType.BigInt, 50).Value = id;

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
                        Console.WriteLine(id + " : " + firstName + " " + lastName);
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

                Console.WriteLine("Data about connection:");
                Console.WriteLine("\tLine connection: {0}", connection.ConnectionString);
                Console.WriteLine("\tData Base: {0}", connection.Database);
                Console.WriteLine("\tServer: {0}", connection.DataSource);
                Console.WriteLine("\tServer Version: {0}", connection.ServerVersion);
                Console.WriteLine("\tMood: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);
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
    }
}
