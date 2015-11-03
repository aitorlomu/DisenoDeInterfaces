using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySleepy
{
    public partial class ProveedoresNuevoGUI : Form
    {
        MetodosComunes funciones = new MetodosComunes();
        MetodosConsultasSQL consultas = new MetodosConsultasSQL();
        private int idprov;
        private int idpoblacion;
        ProveedoresGUI padre;
        XML xml = new XML();
        public ProveedoresNuevoGUI()
        {
            InitializeComponent();
            cargarCboComunidad();
        }

        public void cargarCboComunidad()
        {
            string sql = "SELECT idcomunidad,comunidad FROM comunidades";
            funciones.rellenacombobox(cboComunidad, sql, "");
        }

        private void cboComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboComunidad.SelectedIndex != -1 && cboComunidad.SelectedIndex != 0)
            {
                cboProvincia.Enabled = true;
                funciones.rellenacombobox(cboProvincia, "SELECT idprovincia,provincia FROM provincias where refcomunidad=" + cboComunidad.SelectedIndex, "");
            }
        }

        private void cboPoblacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool canConvert = int.TryParse(cboPoblacion.GetItemText(cboPoblacion.SelectedValue), out idpoblacion);
            if(canConvert){
                cboCodigoPostal.Enabled = true;
                String sql = "SELECT CP.IDCODIGOPOSTAL, CP.CODIGOPOSTAL"+
                               " FROM CODIGOSPOSTALES CP, CODIGOSPOSTALESPOBLACIONES CPP,POBLACIONES P"+
                                " WHERE CP.IDCODIGOPOSTAL = CPP.REFCODIGOPOSTAL"+
                                " AND P.IDPOBLACION = CPP.REFPOBLACION"+
                                " AND P.IDPOBLACION ="+idpoblacion;
                funciones.rellenacombobox(cboCodigoPostal, sql, "");
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool canConvert = int.TryParse(cboProvincia.GetItemText(cboProvincia.SelectedValue), out idprov);
            if (canConvert)
            {
                cboPoblacion.Enabled = true;
                funciones.rellenacombobox(cboPoblacion, "SELECT DISTINCT P.IDPOBLACION,P.POBLACION FROM POBLACIONES P,CODIGOSPOSTALESPOBLACIONES CP,PROVINCIAS PP WHERE P.IDPOBLACION = CP.REFPOBLACION "
                    + " AND PP.IDPROVINCIA = CP.REFPROVINCIA AND PP.IDPROVINCIA= " + idprov + " ORDER BY P.POBLACION", "");
            }
        }

        public void asignaPadre(ProveedoresGUI p)
        {
            padre = p;
            
        }
        public void rellenaDatos(int id)
        {
            String nif = xml.XMLToBD(id,"NIF", "Proveedores.xml");
            String nombre = xml.XMLToBD(id, "NOMBRE", "Proveedores.xml");
            String direccion = xml.XMLToBD(id, "DIRECCION", "Proveedores.xml");
            String comunidad = xml.XMLToBD(id, "COMUNIDAD", "Proveedores.xml");
            String provincia = xml.XMLToBD(id, "PROVINCIA", "Proveedores.xml");
            String poblacion = xml.XMLToBD(id, "POBLACION", "Proveedores.xml");
            txtNIF.Text = nif;
            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            cboComunidad.Text = comunidad;
            cboProvincia.Text = provincia;
            cboPoblacion.Text = poblacion;
            String telefono = xml.XMLToBD(id, "TELEFONO", "Proveedores.xml");

        }

        private void ProveedoresNuevoGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
