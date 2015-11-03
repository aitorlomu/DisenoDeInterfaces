using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Windows.Forms;

namespace MySleepy
{

    class XML
    {
       
        String sql = "SELECT P.IDPROVEEDOR, P.NIF, P.DIRECCION,P.POBLACION,P.PROVINCIA,CP.CODIGOPOSTAL,P.TELEFONO,P.COMUNIDAD" +
                    " FROM PROVEEDORES P,CODIGOSPOSTALESPOBLACIONES CPP,CODIGOSPOSTALES CP" +
                    " WHERE P.REFCPPOBLACIONES = CPP.IDCODIGOPOSTALPOB" +
                    " AND CPP.REFCODIGOPOSTAL = CP.IDCODIGOPOSTAL"+
                     "AND P.ELIMINADO = 0";
        public void BDToXML(String sql ,String nombreNodo,String nombreFicheroXML)
        {
            ConnectDB conexion = new ConnectDB();
            DataSet data = conexion.getData(sql, nombreNodo);
            data.WriteXml(nombreFicheroXML);
            MessageBox.Show("Fichero XML creado con éxito");
        }

        public String XMLToBD(int id,String columna,String nombreFicheroXML)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(nombreFicheroXML, new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            return ds.Tables[0].Rows[id-1][columna].ToString();       
        }
    }
}
