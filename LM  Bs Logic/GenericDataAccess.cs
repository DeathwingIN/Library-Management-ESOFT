﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;



namespace LibraryManagementSystemBL
{
    static class GenericDataAccess
    {
        
        
        //Record database connection string 
        private static string connectionString = "Data Source=(local);Initial Catalog=LIB Managemnt;Integrated Security=True";
        //Record Database type(Data provider)
        private static string dataProvider = "System.Data.SqlClient";





        /// <summary>
        /// Class to create vendor specific Database command object
        /// and encode connectionString ,Provider name and command type
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>21-05-2021</DateCreated>
        /// <returns>SQL Specific Dbcommand object</returns>
        public static DbCommand CreateDbCommand()
        {
            //create new data provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);
            

            //obtain a database specific Dbconnection object
            DbConnection conn = factory.CreateConnection();
            
            //setup database connection string in Dbconnection object
            conn.ConnectionString = connectionString;
            
            //create database specific command object
            DbCommand comm = conn.CreateCommand();

            //setup command type for the store procedure
            comm.CommandType = CommandType.StoredProcedure;
            
            //return initialize command object
            return comm;
        }


        /// <summary>
        /// Method helps to extarct data from database   
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>21-05-2021</DateCreated>
        /// <returns>Data table populated with resluts </returns>
        public static DataTable ExecuteQuery(DbCommand command )
        {
            //create Data table to populate result
            DataTable tbl = new DataTable();

            //execute the command object
            try
            {
                //open data connection
                command.Connection.Open();
                //execute stored proc and save the result set data reader
                DbDataReader reader = command.ExecuteReader();
                //fill the reader to data table
                tbl.Load(reader);
                //close the data reader
            }
            catch (Exception e)
            {
                //Log that error using relevent class
                throw;
            }
            finally
            {
                //close the database connection
                command.Connection.Close();
            }

            return tbl;
        }


        /// <summary>
        /// Method helps to manipulate data in database    
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>21-05-2021</DateCreated>
        /// <returns>Integer value based on success or faliure  </returns>
        public static int ExecuteNonQuery(DbCommand command)
        {
            int rowsAffected = -1;
            //execute command object
            try
            {
                //open connection
                command.Connection.Open();
                //execute Non quwry and get the number of affected rows
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //log the error and rethrow it
                throw;
            }
            finally
            {
                //close the connection
                command.Connection.Close();
            }
            return rowsAffected;
        }


    }
}
