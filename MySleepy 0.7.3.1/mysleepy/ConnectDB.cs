using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace MySleepy
{
    class ConnectDB
    {
        const string driver = "Data Source=(DESCRIPTION ="
      + "(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = LOCALHOST)(PORT = 1521)))"
      + "(CONNECT_DATA = (SERVICE_NAME = ORADAM2))); "
      + "User Id=C##SleepyAdmin; Password=admin;";

        public DataSet getData(string query, string table)
        {
            OracleConnection objConexion;
            OracleDataAdapter objComando;
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
            OracleConnection objconexion;
            OracleCommand objcomando;
            objconexion = new OracleConnection(driver);
            objconexion.Open();
            objcomando = new OracleCommand(statement, objconexion);
            objcomando.ExecuteNonQuery();
            objcomando.Connection.Close();
        }

        public Object DLookUp(String column,String table,String condition)
        {
            OracleConnection objConexion;
            OracleDataAdapter objComando;
            DataSet requestquery = new DataSet();
            object result;

            objConexion = new OracleConnection(driver);
            objConexion.Open();

            if(condition.Equals("")){
                objComando = new OracleDataAdapter("Select " + column + " from " + table, objConexion);

            }
            else
            {
                objComando = new OracleDataAdapter("Select " + column + " from " + table + " where " + condition, objConexion);

            }
            
            try
            {
                objComando.Fill(requestquery);
                result = requestquery.Tables[0].Rows[0][requestquery.Tables[0].Columns.IndexOf(column)];
            }
            catch (Exception e)
            {
                result = -1;
            }
            objConexion.Close();
            return result;

        }



    }
}
