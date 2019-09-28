//Nicholas Tran && Jimmy Pham
//CIS 3309
//Frank Friedman
//EmpMan Final Project
//4/30/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;

namespace CIS3309_EmpMan
{
    //Database class responsible for injecting sql commands using form information
    class DatabaseClass
    {
        // Connection string for EmpManDB (type: Microsoft Access) in the Resources folder
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../Debug/Resources/EmpManDB.accdb";

        // *********** INSERTION METHODS **********
        // Inserts a new record for Person in the Person table with parameters name, birthDate and personID
        public bool InsertPerson(int personID, string personName, string personBirthDate)
        {
            // SQL insert statement for Person
            string strInsertPerson = "INSERT INTO PERSON (fldID, fldName, fldBirthDate) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Person error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        }  // end InsertPerson
        // Inserts a new record for Client in the client table with parameters name, birthDate and personID
        public bool InsertClient(int personID, string clientType)
        {
            // SQL insert statement for Client
            string strInsertClient = "INSERT INTO CLIENT (fldID, fldType) " +
                "VALUES(" + personID + " , '" + clientType + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertClient, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Client error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        } // end InsertClient
        // Inserts a new record for employee in the employee table with parameters name, birthDate and personID
        public bool InsertEmployee(int personID, string employeeJobTitle)
        {
            // SQL insert statement for Employee
            string strInsertWorker = "INSERT INTO EMPLOYEE (fldID, fldTitle) " +
                "VALUES(" + personID + "', '" + employeeJobTitle + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertWorker, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Worker error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        } // end InsertEmployee

        // Inserts a new record for manager in the manager table with parameters name, birthDate and personID
        public bool InsertManager(int personID, decimal managerSalary, decimal managerBonus)
        {
            // SQL insert statement for Manager
            string strInsertManager = "INSERT INTO MANAGER (fldID, fldSalary, fldBonus) " +
                "VALUES(" + personID + " , '" + managerSalary + "', '" + managerBonus + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertManager, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Manager error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        } // end InsertManager

        // Inserts a new record for worker in the worker table with parameters name, birthDate and personID
        public bool InsertWorker(int personID, decimal workerHourlyPay)
        {
            // SQL insert statement for Worker
            string strInsertWorker = "INSERT INTO WORKER (fldID, fldHourlyPay) " +
                "VALUES(" + personID + " , '" + workerHourlyPay + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertWorker, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Worker error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        } // end InsertWorker

        // ********** Update Method ********** 
        // Updates records from Person, Client, Employee, Manager, and Worker tables that match integer parameter personID

        // Uses strConnection to open a connection with the database
        // Updates Person with given ID from every table in the database
        // If a person with the given ID is not in a table, the Insert command does nothing
        public bool UpdatePerson(string personID, string personName, string personBirthDate)
        {
            string strUpdatePerson = "UPDATE Person SET fldName = '" + personName + "', fldBirthDate = '" + personBirthDate + "' WHERE fldId = " + personID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdatePerson, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Person error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Person

        // Uses strConnection to open a connection with the database
        // Updates client with given ID from every table in the database
        // If a client with the given ID is not in a table, the Insert command does nothing
        public bool UpdateClient(int clientID, string clientType)
        {
            string strUpdateClient = "UPDATE Client SET fldType = '" + clientType + "' WHERE fldId = " + clientID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateClient, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Client error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Client

        // Uses strConnection to open a connection with the database
        // Updates employee with given ID from every table in the database
        // If a employee with the given ID is not in a table, the Insert command does nothing
        public bool UpdateEmployee(int employeeID, string employeeTitle)
        {
            string strUpdateEmployee = "UPDATE Employee SET fldTitle = '" + employeeTitle + "' WHERE fldId = " + employeeID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateEmployee, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Employee error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Employee

        // Uses strConnection to open a connection with the database
        // Updates manager with given ID from every table in the database
        // If a manager with the given ID is not in a table, the Insert command does nothing
        public bool UpdateManager(int managerID, decimal managerSalary, decimal managerBonus)
        {
            string strUpdateManager = "UPDATE Manager SET fldSalary = '" + managerSalary + "', fldBonus = '" + managerBonus + "' WHERE fldId = " + managerID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateManager, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Manager error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Manager

        // Uses strConnection to open a connection with the database
        // Updates worker with given ID from every table in the database
        // If a worker with the given ID is not in a table, the Insert command does nothing
        public bool UpdateWorker(int workerID, decimal workerHourlyPay)
        {
            string strUpdateWorker = "UPDATE Worker SET fldHourlyPay = '" + workerHourlyPay + "' WHERE fldId = " + workerID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateWorker, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Worker error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Worker

        // ********** DELETE Method ********** 
        // Deletes records from Person, Client, Employee, Manager, and Worker tables that match integer parameter personID

        // Uses strConnection to open a connection with the database
        // Deletes Person with given ID from every table in the database
        // If a person with the given ID is not in a table, the Delete command does nothing
        // Code written by Christopher Tither and Frank Branigan, CIS 3309 Section 1, April 2017
        public void Delete(int personID)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM Person WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM Client WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM Employee WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM Manager WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
                    using (OleDbCommand command5 = new OleDbCommand("DELETE FROM Worker WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            // FormController.clear(this);
        }  // end Delete

        // ********** Select Method ********** 
        // Select records from Person, Client, Employee, Manager, and Worker tables that match integer parameter personID

        // Uses strConnection to open a connection with the database
        // Selects Person with given ID from every table in the database
        // If a person with the given ID is not in a table, the Select command does nothing
        // Code written by Christopher Tither and Frank Branigan, CIS 3309 Section 1, April 2017
        public void Select(int personID, ref int id, ref string name,
             ref DateTime birthDate, ref string type, ref string title, ref decimal salary, ref decimal bonus, ref decimal hourlyPay,
             ref bool isPerson, ref bool isClient, ref bool isEmployee, ref bool isManager, ref bool isWorker)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {

                try
                {
                    connection.Open();
                    using (OleDbCommand command1 = new OleDbCommand("SELECT fldID, fldName, fldBirthDate FROM Person WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                        if (reader.Read())
                        {
                            isPerson = true;
                            id = Convert.ToInt32(reader.GetValue(0).ToString());
                            name = Convert.ToString(reader.GetValue(1));
                            birthDate = Convert.ToDateTime(reader.GetValue(2));
                        }
                    }
                    using (OleDbCommand command2 = new OleDbCommand("SELECT fldType FROM Client WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                        if (reader.Read())
                        {
                            isClient = true;
                            type = reader.GetString(0);
                        }
                    }
                    using (OleDbCommand command3 = new OleDbCommand("SELECT fldTitle FROM Employee WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                        if (reader.Read())
                        {
                            isEmployee = true;
                            title = reader.GetString(0);
                        }
                    }
                    using (OleDbCommand command4 = new OleDbCommand("SELECT fldSalary, fldBonus FROM Manager WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                        if (reader.Read())
                        {
                            isManager = true;
                            salary = Convert.ToDecimal(reader.GetValue(0).ToString());
                            bonus = Convert.ToDecimal(reader.GetValue(1).ToString());
                        }
                    }
                    using (OleDbCommand command5 = new OleDbCommand("SELECT fldHourlyPay FROM Worker WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                        if (reader.Read())
                        {
                            isWorker = true;
                            hourlyPay = Convert.ToDecimal(reader.GetValue(0).ToString());
                        }
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
        }  // end Select

        //finds a duplicate and returns ref for if a query finds a match.
        public void findDuplicateID(int personID, ref bool foundID)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {

                try
                {
                    connection.Open();
                    using (OleDbCommand command1 = new OleDbCommand("SELECT fldID FROM Person WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                        if (reader.Read())
                        {
                            foundID = true;
                        }
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
        }  // end Select

    }
}
