using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proveedores
{
    public partial class ProveedoresGUI : Form
    {
        MetodosComunes funciones;
        MetodosConsultasSQL consultas;
        ProveedoresNuevoGUI frmnuevo = new ProveedoresNuevoGUI();
        XML xml = new XML();

        

        public ProveedoresGUI()
        {
            InitializeComponent();
            funciones = new MetodosComunes();
            consultas = new MetodosConsultasSQL();
            actualizarTabla();
            
        }

        public string actualizarTabla()
        {

            String sql = " SELECT P.IDPROVEEDOR, P.NIF,P.NOMBRE, P.DIRECCION,P.POBLACION,P.PROVINCIA,CP.CODIGOPOSTAL,P.TELEFONO,P.COMUNIDAD"
                    + " FROM PROVEEDORES P,CODIGOSPOSTALESPOBLACIONES CPP,CODIGOSPOSTALES CP"
                    + " WHERE P.REFCPPOBLACIONES = CPP.IDCODIGOPOSTALPOB"
                    + " AND CPP.REFCODIGOPOSTAL = CP.IDCODIGOPOSTAL";


            if (chkEliminados.Checked)
            {
                sql = sql + " AND P.ELIMINADO = 1";
            }
            else
            {
                sql = sql + " AND P.ELIMINADO = 0";
            }

            if(txtCIF.Text.Length>0)
            {
                sql = sql + " and upper(P.NIF) like '%" + txtCIF.Text.ToUpper() + "%'";
            }

            if(txtTelefono.Text.Length>0)
            {
                sql = sql + " and upper(P.TELEFONO) like '%" + txtTelefono.Text.ToUpper() + "%'";
            }

            if(txtNombre.Text.Length>0)
            {
                sql = sql + " and upper(P.NOMBRE) like '%" + txtNombre.Text.ToUpper() + "%'";
            }
           
            funciones.rellenaDGV(dgvProveedores, sql);
            funciones.estilodgv(dgvProveedores);

            // Actualizamos el proveedor en el XML
            xml.BDToXML(sql, "Proveedor", "Proveedores.xml");

            return sql;

        }

        private void ProveedoresGUI_Load(object sender, EventArgs e)
        {
        }

        private void chkEliminados_CheckStateChanged(object sender, EventArgs e)
        {
            actualizarTabla();
            if(chkEliminados.Checked)
            {
                btnEliminar.Text = "Restaurar";
            }
            else
            {
                btnEliminar.Text = "Eliminar";
            }
        }

        private void txtCIF_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmnuevo.ShowDialog();
            actualizarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvProveedores.SelectedCells[0].Value.ToString());
                ProveedoresNuevoGUI hijo = new ProveedoresNuevoGUI();
                hijo.asignaPadre(this);
                hijo.rellenaDatos(id);
                hijo.ShowDialog();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes seleccionar un artículo");
            }
        }

    }
}
