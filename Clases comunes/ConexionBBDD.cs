using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Oracle.DataAccess.Client;

namespace MySleepy
{
    class ConexionBBDD
    {
        //MAGIA, NO TOCAR
        const string driver = "Data Source=(DESCRIPTION =" +
           "(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = LOCALHOST)(PORT = 1521)))" +
           "(CONNECT_DATA = (SERVICE_NAME = ORADAM2))); " + "User Id=C##SleepyAdmin; Password=admin;";
        //=======================================================================================================
        public DataSet getData(String query, String table)
        {
            
                OracleConnection objConexion = default(OracleConnection);
                OracleDataAdapter objComando = default(OracleDataAdapter);
                DataSet requestquery = new DataSet();

                objConexion = new OracleConnection(driver);
                objConexion.Open();
                objComando = new OracleDataAdapter(query, objConexion);
                objComando.Fill(requestquery, table);
                objConexion.Close();
                return requestquery;
            
        }

        public void setData(string statement)
        {
            OracleConnection objconexion = default(OracleConnection);
            OracleCommand objcomando = default(OracleCommand);

            objconexion = new OracleConnection(driver);
            objconexion.Open();
            objcomando = new OracleCommand(statement, objconexion);

            objcomando.ExecuteNonQuery();

            objcomando.Connection.Close();

        }
        public object DLookUp(String column, string table, string condition)
        {

            OracleConnection objConexion = default(OracleConnection);
            OracleDataAdapter objComando = default(OracleDataAdapter);
            DataSet requestquery = new DataSet();
            object result = null;
            objConexion = new OracleConnection(driver);
            objConexion.Open();
            if (string.IsNullOrEmpty(condition))
            {
                objComando = new OracleDataAdapter("Select " + column + " from " + table, objConexion);
            }
            else
            {
                objComando = new OracleDataAdapter("Select " + column + " from " + table + " where " + condition, objConexion);
            }

            objComando.Fill(requestquery);

            try
            {
                result = requestquery.Tables[0].Rows[0][requestquery.Tables[0].Columns.IndexOf(column)];
            }
            catch (Exception ex)
            {
                result = -1;

            }
            objConexion.Close();
            return result;
         }
    }
}
