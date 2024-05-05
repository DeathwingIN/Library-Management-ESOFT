using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using LibraryManagementSystemBL;


namespace LM__Bs_Logic
{
    public static class Member


    {

        /// <summary>
        /// Add New Mambers using UI
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        public static void AddNewMembers(string userName, string firstName, string lastName, DateTime dateOfBirth, string address, string email, string contactNumber, string faculty, string role, string nic, string password,int isActive,int isBlocked ,decimal cumilativeFine)
        {
            
            
            //Create Dbcommand Object

            DbCommand command = GenericDataAccess.CreateDbCommand();

            //Setup Stored Procedure Name As Command Text 
            command.CommandText = "InsertNewUser";

            //Create Instance Parameter
            DbParameter param = command.CreateParameter();

            //Setup Up Parameter Name in Stored Procedure 
            param.ParameterName = "@User_Name";

            //Setup Value for Parameter
            param.Value = userName;

            //Define the Data Type 
            param.DbType = DbType.String;

            //Add DbParameter to Command Object
            command.Parameters.Add(param);

            //Create Parameter For Password
            param = command.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Role
            param = command.CreateParameter();
            param.ParameterName = "@Role";
            param.Value = role;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Address
            param = command.CreateParameter();
            param.ParameterName = "@Address";
            param.Value = address;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For First_Name
            param = command.CreateParameter();
            param.ParameterName = "@First_Name";
            param.Value = firstName;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Last_Name 
            param = command.CreateParameter();
            param.ParameterName = "@Last_Name";
            param.Value = lastName;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Contact_Number 
            param = command.CreateParameter();
            param.ParameterName = "@Contact_Number";
            param.Value = contactNumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For E_mail 
            param = command.CreateParameter();
            param.ParameterName = "@E_mail";
            param.Value = email;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Faculty
            param = command.CreateParameter();
            param.ParameterName = "@Faculty";
            param.Value = faculty;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For NIC
            param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = nic;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For DOB
            param = command.CreateParameter();
            param.ParameterName = "@DOB";
            param.Value = dateOfBirth;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            //Create Parameter For Cumilative_Fine
            param = command.CreateParameter();
            param.ParameterName = "@Cumilative_Fine";
            param.Value = 0.00;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            //Create Parameter For Is_Active
            param = command.CreateParameter();
            param.ParameterName = "@Is_Active";
            param.Value = 1;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For Is_blocked
            param = command.CreateParameter();
            param.ParameterName = "@Is_blocked";
            param.Value = 0;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            try
            {
                int updatedRows = GenericDataAccess.ExecuteNonQuery(command);
            }

            catch (Exception e)
            {
                throw;
            }
        }


        /// <summary>
        /// Update Mambers Initials Data using UI
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        public static void UpdateMemberDetails(string userName,string firstName, string lastName, DateTime dateOfBirth, string address, string email, string contactNumber, string faculty, string role, string nic, string password, int isActive, int isBlocked,decimal cumilativeFine, int userId)
        {
            //Create Dbcommand Object

            DbCommand command = GenericDataAccess.CreateDbCommand();

            //Setup Stored Procedure Name As Command Text 
            command.CommandText = "UpdateUserDetails";

            //Create Instance Parameter
            DbParameter param = command.CreateParameter();

            //Setup Up Parameter Name in Stored Procedure 
            param.ParameterName = "@User_Name";

            //Setup Value for Parameter
            param.Value = userName;

            //Define the Data Type 
            param.DbType = DbType.String;

            //Add DbParameter to Command Object
            command.Parameters.Add(param);

            //Create Parameter For UserID
            param = command.CreateParameter();
            param.ParameterName = "@User_ID ";
            param.Value = userId;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For Password
            param = command.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Role
            param = command.CreateParameter();
            param.ParameterName = "@Role";
            param.Value = role;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Address
            param = command.CreateParameter();
            param.ParameterName = "@Address";
            param.Value = address;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For First_Name
            param = command.CreateParameter();
            param.ParameterName = "@First_Name";
            param.Value = firstName;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Last_Name 
            param = command.CreateParameter();
            param.ParameterName = "@Last_Name";
            param.Value = lastName;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Contact_Number 
            param = command.CreateParameter();
            param.ParameterName = "@Contact_Number";
            param.Value = contactNumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For E_mail 
            param = command.CreateParameter();
            param.ParameterName = "@E_mail";
            param.Value = email;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Faculty
            param = command.CreateParameter();
            param.ParameterName = "@Faculty";
            param.Value = faculty;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For NIC
            param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = nic;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For DOB
            param = command.CreateParameter();
            param.ParameterName = "@DOB";
            param.Value = dateOfBirth;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            //Create Parameter For Cumilative_Fine
            param = command.CreateParameter();
            param.ParameterName = "@Cumilative_Fine";
            param.Value = cumilativeFine;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            //Create Parameter For Is_Active
            param = command.CreateParameter();
            param.ParameterName = "@Is_Active";
            param.Value = isActive;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For Is_blocked
            param = command.CreateParameter();
            param.ParameterName = "@Is_blocked";
            param.Value = isBlocked;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            try
            {
                int updatedRows = GenericDataAccess.ExecuteNonQuery(command);
            }

            catch (Exception e)
            {
                throw;
            }
        }


        /// <summary>
        /// GET ALL ACTIVE MEMBERS FROM THE DATA BASE AND PASS IT TO UI LAYER
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        /// <returns>POPULATED DATA TABLE WITH ALL ACTIVE MEMBERS </returns>
        public static DataTable ListMembers()
        {
            //CREATE DB COMMAND OBJECT
            DbCommand command = GenericDataAccess.CreateDbCommand();

            //SET THE COMMAND TEXT STORE PROCEDURE NAME
            command.CommandText = "ListAllUsers";

            //EXCECUTE THE QUARRY COMMAND 
            DataTable table = GenericDataAccess.ExecuteQuery(command);

            //RETURN DATA TABLE
            return table;
        }


        /// <summary>
        ///Deactivate Member
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        public static void DeactivateMemberDetails(string userName,string firstName, string lastName, DateTime dateOfBirth, string address, string email, string contactNumber, string faculty, string role, string nic, string password, int isActive, int isBlocked,decimal cumilativeFine, int userId)
        {
            //Create Dbcommand Object

            DbCommand command = GenericDataAccess.CreateDbCommand();

            //Setup Stored Procedure Name As Command Text 
            command.CommandText = "UpdateUserDetails";

            //Create Instance Parameter
            DbParameter param = command.CreateParameter();

            //Setup Up Parameter Name in Stored Procedure 
            param.ParameterName = "@User_Name";

            //Setup Value for Parameter
            param.Value = userName;

            //Define the Data Type 
            param.DbType = DbType.String;

            //Add DbParameter to Command Object
            command.Parameters.Add(param);

            //Create Parameter For UserID
            param = command.CreateParameter();
            param.ParameterName = "@User_ID ";
            param.Value = userId;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For Password
            param = command.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Role
            param = command.CreateParameter();
            param.ParameterName = "@Role";
            param.Value = role;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Address
            param = command.CreateParameter();
            param.ParameterName = "@Address";
            param.Value = address;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For First_Name
            param = command.CreateParameter();
            param.ParameterName = "@First_Name";
            param.Value = firstName;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Last_Name 
            param = command.CreateParameter();
            param.ParameterName = "@Last_Name";
            param.Value = lastName;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Contact_Number 
            param = command.CreateParameter();
            param.ParameterName = "@Contact_Number";
            param.Value = contactNumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For E_mail 
            param = command.CreateParameter();
            param.ParameterName = "@E_mail";
            param.Value = email;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Faculty
            param = command.CreateParameter();
            param.ParameterName = "@Faculty";
            param.Value = faculty;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For NIC
            param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = nic;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For DOB
            param = command.CreateParameter();
            param.ParameterName = "@DOB";
            param.Value = dateOfBirth;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            //Create Parameter For Cumilative_Fine
            param = command.CreateParameter();
            param.ParameterName = "@Cumilative_Fine";
            param.Value = cumilativeFine;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            //Create Parameter For Is_Active
            param = command.CreateParameter();
            param.ParameterName = "@Is_Active";
            param.Value = 0;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For Is_blocked
            param = command.CreateParameter();
            param.ParameterName = "@Is_blocked";
            param.Value = 0;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            try
            {
                int updatedRows = GenericDataAccess.ExecuteNonQuery(command);
            }

            catch (Exception e)
            {
                throw;
            }
        }
      
    }
}
