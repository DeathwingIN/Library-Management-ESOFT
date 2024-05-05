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
    public static class cat
    {
        /// <summary>
        /// GET ALL CATALOG ITEMS FROM THE DATA BASE AND PASS IT TO UI LAYER
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        /// <returns>POPULATED DATA TABLE WITH ALL ACTIVE MEMBERS </returns>
        public static DataTable DisplayAllCatalogItems()
        {
            //CREATE DB COMMAND OBJECT
            DbCommand command = GenericDataAccess.CreateDbCommand();

            //SET THE COMMAND TEXT STORE PROCEDURE NAME
            command.CommandText = "DisplayAllCatalogItems";

            //EXCECUTE THE QUARRY COMMAND 
            DataTable table = GenericDataAccess.ExecuteQuery(command);

            //RETURN DATA TABLE
            return table;
        }


        /// <summary>
        /// Add New Catlog Items using UI
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        public static void AddNewCatlogItems(string title, string author, string isbn, string edition, string language, string catergory, string type, string description ,decimal price, DateTime issuedDate, int isBorrowed, int isActive, string quentity, string subject, string bookID)
        {


            //Create Dbcommand Object

            DbCommand command = GenericDataAccess.CreateDbCommand();

            //Setup Stored Procedure Name As Command Text 
            command.CommandText = "AddNewCatalogItem";

            //Create Instance Parameter
            DbParameter param = command.CreateParameter();

            //Setup Up Parameter for @Title
            param.ParameterName = "@Title";
            param.Value = title;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Author 
            param = command.CreateParameter();
            param.ParameterName = "@Author ";
            param.Value = author;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Role
            param = command.CreateParameter();
            param.ParameterName = "@ISBN";
            param.Value = isbn;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Edition
            param = command.CreateParameter();
            param.ParameterName = "@Edition";
            param.Value = edition;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Language
            param = command.CreateParameter();
            param.ParameterName = "@Language";
            param.Value = language;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Catergory
            param = command.CreateParameter();
            param.ParameterName = "@Catergory";
            param.Value = catergory;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For  @Type
            param = command.CreateParameter();
            param.ParameterName = "@Type";
            param.Value = type;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Description 
            param = command.CreateParameter();
            param.ParameterName = "@Description ";
            param.Value = description;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Subject 
            param = command.CreateParameter();
            param.ParameterName = "@Subject ";
            param.Value = subject;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Book_ID
            param = command.CreateParameter();
            param.ParameterName = "@Book_ID ";
            param.Value = bookID;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For  @Quentity
            param = command.CreateParameter();
            param.ParameterName = "@Quentity";
            param.Value = quentity;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Issued_Date 
            param = command.CreateParameter();
            param.ParameterName = "@Issued_Date ";
            param.Value = issuedDate;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            //Create Parameter For  @Price
            param = command.CreateParameter();
            param.ParameterName = "@Price";
            param.Value = price;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            //Create Parameter For Is_Active
            param = command.CreateParameter();
            param.ParameterName = "@Is_Active";
            param.Value = 1;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For @Is_Borrowed
            param = command.CreateParameter();
            param.ParameterName = "@Is_Borrowed";
            param.Value = 0;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            try
            {
                int updatedRows = GenericDataAccess.ExecuteNonQuery(command);
            }

            catch (Exception ex)
            {
                throw;
            }
        }


        /// <summary>
        ///Update Catlog Items using UI
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        public static void UpdateCatlogItems(string title, string author, string isbn, string edition, string language, string catergory, string type, string description, decimal price, DateTime issuedDate, int isBorrowed, int isActive, string quentity, string subject, string bookID, int catalogID)
        {


            //Create Dbcommand Object

            DbCommand command = GenericDataAccess.CreateDbCommand();

            //Setup Stored Procedure Name As Command Text 
            command.CommandText = "UpdateCatalogItem";

            //Create Instance Parameter
            DbParameter param = command.CreateParameter();

            //Setup Up Parameter for @Title
            param.ParameterName = "@Title";
            param.Value = title;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Author 
            param = command.CreateParameter();
            param.ParameterName = "@Author ";
            param.Value = author;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Role
            param = command.CreateParameter();
            param.ParameterName = "@ISBN";
            param.Value = isbn;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Edition
            param = command.CreateParameter();
            param.ParameterName = "@Edition";
            param.Value = edition;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Language
            param = command.CreateParameter();
            param.ParameterName = "@Language";
            param.Value = language;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Catergory
            param = command.CreateParameter();
            param.ParameterName = "@Catergory";
            param.Value = catergory;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For  @Type
            param = command.CreateParameter();
            param.ParameterName = "@Type";
            param.Value = type;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Description 
            param = command.CreateParameter();
            param.ParameterName = "@Description ";
            param.Value = description;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Subject 
            param = command.CreateParameter();
            param.ParameterName = "@Subject ";
            param.Value = subject;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Book_ID
            param = command.CreateParameter();
            param.ParameterName = "@Book_ID ";
            param.Value = bookID;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For  @Quentity
            param = command.CreateParameter();
            param.ParameterName = "@Quentity";
            param.Value = quentity;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Issued_Date 
            param = command.CreateParameter();
            param.ParameterName = "@Issued_Date ";
            param.Value = issuedDate;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            //Create Parameter For  @Price
            param = command.CreateParameter();
            param.ParameterName = "@Price";
            param.Value = price;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            //Create Parameter For Is_Active
            param = command.CreateParameter();
            param.ParameterName = "@Is_Active";
            param.Value = isActive;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For @Is_Borrowed
            param = command.CreateParameter();
            param.ParameterName = "@Is_Borrowed";
            param.Value = isBorrowed;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For @Is_Borrowed
            param = command.CreateParameter();
            param.ParameterName = "@Catalog_ID ";
            param.Value = catalogID;
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
        ///Update Catlog Items using UI
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        public static void DeactivateCatlogItems(string title, string author, string isbn, string edition, string language, string catergory, string type, string description, decimal price, DateTime issuedDate, int isBorrowed, int isActive, string quentity, string subject, string bookID, int catalogID)
        {


            //Create Dbcommand Object

            DbCommand command = GenericDataAccess.CreateDbCommand();

            //Setup Stored Procedure Name As Command Text 
            command.CommandText = "UpdateCatalogItem";

            //Create Instance Parameter
            DbParameter param = command.CreateParameter();

            //Setup Up Parameter for @Title
            param.ParameterName = "@Title";
            param.Value = title;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Author 
            param = command.CreateParameter();
            param.ParameterName = "@Author ";
            param.Value = author;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For Role
            param = command.CreateParameter();
            param.ParameterName = "@ISBN";
            param.Value = isbn;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Edition
            param = command.CreateParameter();
            param.ParameterName = "@Edition";
            param.Value = edition;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Language
            param = command.CreateParameter();
            param.ParameterName = "@Language";
            param.Value = language;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Catergory
            param = command.CreateParameter();
            param.ParameterName = "@Catergory";
            param.Value = catergory;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For  @Type
            param = command.CreateParameter();
            param.ParameterName = "@Type";
            param.Value = type;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Description 
            param = command.CreateParameter();
            param.ParameterName = "@Description ";
            param.Value = description;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Subject 
            param = command.CreateParameter();
            param.ParameterName = "@Subject ";
            param.Value = subject;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Book_ID
            param = command.CreateParameter();
            param.ParameterName = "@Book_ID ";
            param.Value = bookID;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For  @Quentity
            param = command.CreateParameter();
            param.ParameterName = "@Quentity";
            param.Value = quentity;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Parameter For @Issued_Date 
            param = command.CreateParameter();
            param.ParameterName = "@Issued_Date ";
            param.Value = issuedDate;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            //Create Parameter For  @Price
            param = command.CreateParameter();
            param.ParameterName = "@Price";
            param.Value = price;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            //Create Parameter For Is_Active
            param = command.CreateParameter();
            param.ParameterName = "@Is_Active";
            param.Value = 0;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For @Is_Borrowed
            param = command.CreateParameter();
            param.ParameterName = "@Is_Borrowed";
            param.Value = isBorrowed;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Parameter For @Is_Borrowed
            param = command.CreateParameter();
            param.ParameterName = "@Catalog_ID ";
            param.Value = catalogID;
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
