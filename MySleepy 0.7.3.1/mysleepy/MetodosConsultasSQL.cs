using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MySleepy
{
    class MetodosConsultasSQL
    {
        ConnectDB conexion = new ConnectDB();

        // Método para poner la columna ELIMINADO a 1
        // nombreId es el nombre de la columna
        // numId es el número de id
        // tabla es el nombre de la tabla

        public void eliminarDato(String nombreId, String numId, String tabla, int eliminado)
        {
            String sql;
            sql = "UPDATE " + tabla + " SET ELIMINADO= " + eliminado + " WHERE " + nombreId + "=" + numId;
            conexion.setData(sql);
        }
        // Método para poner la columna ELIMINADO a 0
        public void restaurarDato(String nombreId, String numId, String tabla)
        {
            String sql;
            sql = "UPDATE " + tabla + " SET ELIMINADO=0 WHERE " + nombreId + "=" + numId;
            conexion.setData(sql);
        }

        /*
         * Método para actualizar datos en una tabla
         * nombreId es la id del que se quiere sacar el último registro anotado
         * tabla es la tabla donde se busca el último registro
         * campos es un array con los nombres de los campos que serán actualizados
         * nuevosdatos es un array con los datos con los que se actualizará la tabla
         */
        public void actualizarDato(String[] campos, String[] nuevosdatos, String nombreId, String numId, String tabla)
        {
            String sql;
            for (int i = 0; i < campos.Length; i++)
            {
                sql = "UPDATE " + tabla + " SET "+campos[i]+"="+nuevosdatos[i]+" WHERE " + nombreId + "=" + numId;
                conexion.setData(sql);              
            }
            MessageBox.Show("Datos actualizados");
                
        }

        public void actualizarDato(String campo, String nuevodato, String nombreId, String numId, String tabla)
        {
            String sql;
            sql = "UPDATE " + tabla + " SET " + campo + "=" + nuevodato + " WHERE " + nombreId + "=" + numId;
            conexion.setData(sql);
            
            MessageBox.Show("Datos actualizados");

        }

        public void actualizarStock(String campo, String nuevosdatos, String nombreId, String numId, String tabla)
        {
            String sql;

            sql = "UPDATE " + tabla + " SET " + campo + "=" + nuevosdatos + " WHERE " + nombreId + "=" + numId;
            conexion.setData(sql);

            MessageBox.Show("Datos actualizados");

        }

        public void añadirLog(int id, char tipo, String descripcion)
        {
            string fecha_actual = "" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "  " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            String [] datos={"SEQ_LOG.NEXTVALUE",""+id,"'"+tipo+"'","'"+descripcion+"'",fecha_actual};
            insertarFila(datos, "LOGS");        
            
        }
        // Método que se usará a la hora de añadir registros a nuestra base de datos para sacar la nueva id
        // nombreId es la id del que se quiere sacar el último registro anotado
        // tabla es la tabla donde se busca el último registro
        public int ultimoId(String nombreId, String tabla)
        {
            String ultimo = "";
            DataSet data;
            String sql = "SELECT MAX(" + nombreId + ") FROM " + tabla;
            data = conexion.getData(sql, "res");
            DataTable t = data.Tables["res"];
            foreach (object row in t.Rows)
            {
                ultimo = row.ToString();
                //MsgBox(ultimo)
            }
            int devuelto = -1;
            try
            {
                devuelto = Convert.ToInt32(ultimo);
            }
            catch (Exception e)
            {
                // devuelve -1 si da un error
            }
            return devuelto;
        }

        public int siguienteId(String nombreId, String tabla)
        {
            int ultimo = ultimoId(nombreId, tabla);
            if (ultimo == -1)
            {
                ultimo = 1;
            }
            else
            {
                ultimo = ultimo + 1;
            }
            return ultimo;
        }

        // este método inserta filas a una columna Deben estar todos los campos(Id y eliminado tambien)
        // Devuelve 1 si todo ha salido bien y 0 si ha habido algún error
        // En la cadena de Strings , los datos de tipo string deberán llevar las comillas simples
        public int insertarFila(String[] datos, String tabla)
        {
            int todoCorrecto = 1;
            int num = datos.Length - 1;
            String sql = "INSERT INTO " + tabla + " VALUES(";
            for (int i = 0; i <= num; i++)
            {
                sql = sql + datos[i];
                if (i != num)
                {
                    sql = sql + ",";
                }
            }
            sql = sql + ")";
            try
            {
                MessageBox.Show(sql);
                conexion.setData(sql);
            }
            catch (Exception e)
            {
                return 0;
            }
            return todoCorrecto;
        }
        // Devuelve un dato con el dlookup
        public object obtenerDato(String columna, String tabla, String condition)
        {
            return conexion.DLookUp(columna, tabla, condition);
        }
    }
}
