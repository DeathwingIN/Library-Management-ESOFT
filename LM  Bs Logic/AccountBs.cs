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
    public static class AccountBs
    {
        public static object ListBorrowingHistory(int userID)
        {
            //CREATE DB COMMAND OBJECT
            DbCommand command = GenericDataAccess.CreateDbCommand();

            //SET THE COMMAND TEXT STORE PROCEDURE NAME
            command.CommandText = "GetBorrowinHistory";

            //Create Parameter For UserID
            DbParameter param = command.CreateParameter();
            param = command.CreateParameter();
            param.ParameterName = "@User_ID ";
            param.Value = userID;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //EXCECUTE THE QUARRY COMMAND 
            DataTable table = GenericDataAccess.ExecuteQuery(command);

            //RETURN DATA TABLE
            return table;
        }

        public static object ListOutstandigItems(int userID)
        {
            //CREATE DB COMMAND OBJECT
            DbCommand command = GenericDataAccess.CreateDbCommand();

            //SET THE COMMAND TEXT STORE PROCEDURE NAME
            command.CommandText = "GetActiveReservationandBorrowingData";

            //Create Parameter For UserID
            DbParameter param = command.CreateParameter();
            param = command.CreateParameter();
            param.ParameterName = "@User_ID ";
            param.Value = userID;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //EXCECUTE THE QUARRY COMMAND 
            DataTable table = GenericDataAccess.ExecuteQuery(command);

            //RETURN DATA TABLE
            return table;
        }
    }
}
