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
    public partial class ModificarCliente : Form
    {
        MetodosConsultasSQL mc = new MetodosConsultasSQL();
        MetodosComunes metcom = new MetodosComunes();
        Validaciones va = new Validaciones();
        private int id;
        private int idprov;
        private int idpoblacion;
        private int idpoblacionmul;
        public ModificarCliente(int id)
        {
            this.id = id;
            InitializeComponent();
            string sql = "SELECT idcomunidad,comunidad FROM comunidades";
            metcom.rellenacombobox(cbComunidad, sql, "");
            cbProvincia.Enabled = false;
            cbPoblacion.Enabled = false;
            cargarDatos(id);
        }



        private void cargarDatos(int id)
        {
            
            //MAGIA DE LA MAS NEGRA

            txtclientenombre.Text = mc.obtenerDato("NOMBRE", "CLIENTES", "IDCLIENTE=" + id).ToString();
            txtclienteape1.Text = mc.obtenerDato("APELLIDO1", "CLIENTES", "IDCLIENTE=" + id).ToString();
            txtclienteape2.Text = mc.obtenerDato("APELLIDO2", "CLIENTES", "IDCLIENTE=" + id).ToString();
            txtclientedireccion.Text = mc.obtenerDato("DIRECCION", "CLIENTES", "IDCLIENTE=" + id).ToString();
            //txtclientecodpos.Text = mc.obtenerDato("REFCPPOBLACIONES", "CLIENTES", "IDCLIENTE=" + id).ToString();
            cbComunidad.Text = mc.obtenerDato("COMUNIDAD", "CLIENTES", "IDCLIENTE=" + id).ToString();
            cbProvincia.Text= mc.obtenerDato("PROVINCIA", "CLIENTES", "IDCLIENTE=" + id).ToString();
            cbPoblacion.Text= mc.obtenerDato("POBLACION", "CLIENTES", "IDCLIENTE=" + id).ToString();
            cboCPmultiples.Text = mc.obtenerDato("REFCPPOBLACIONES", "CLIENTES", "IDCLIENTE=" + id).ToString();
            txtclientetele.Text = mc.obtenerDato("TELEFONO1", "CLIENTES", "IDCLIENTE=" + id).ToString();
            txttele2.Text = mc.obtenerDato("TELEFONO2", "CLIENTES", "IDCLIENTE=" + id).ToString();
            txtclienteemail.Text = mc.obtenerDato("EMAIL", "CLIENTES", "IDCLIENTE=" + id).ToString();
               
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Quieres guardar las modificaciones? Los datos se sobreescribirán", "Modificar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                actualizaDatos();
            }
            
        }


        private void actualizaDatos()
        {
            if (comprobarFormulario())
            {
                String[] campos ={"NOMBRE",
                                     "APELLIDO1",
                                     "APELLIDO2",
                                     "DIRECCION",
                                     "REFCPPOBLACIONES",
                                     "COMUNIDAD",
                                     "PROVINCIA",
                                     "POBLACION",
                                     "TELEFONO1",
                                     "TELEFONO2",
                                     "EMAIL"                  
                                };
                String[] modificado ={
                                          "\'"+txtclientenombre.Text+"\'",
                                          "\'"+txtclienteape1.Text+"\'",
                                          "\'"+txtclienteape2.Text+"\'",
                                          "\'"+txtclientedireccion.Text+"\'",
                                          cboCPmultiples.Text,                                        
                                          "\'"+cbComunidad.Text+"\'",
                                          "\'"+cbProvincia.Text+"\'",
                                          "\'"+cbPoblacion.Text+"\'",
                                          txtclientetele.Text,
                                          txttele2.Text,
                                          "\'"+txtclienteemail.Text+"\'",
                                          "0"
                                          
                                  };
                //hacer commit 
                mc.actualizarDato(campos, modificado, "IDCLIENTE", id + "", "CLIENTES");
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe cumplimentar todos los datos del formulario");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres salir? Los datos no guardados se perderán", "Cancelar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool comprobarFormulario()
        {
            Boolean correcto = true;
            if (
            txtclientenombre.Text == "" ||
            txtclienteape1.Text == "" ||
            txtclientedireccion.Text == "" ||
            cboCPmultiples.Text == "" ||
            cbComunidad.Text == "" ||
            cbProvincia.Text == "" ||
            cbPoblacion.Text == "" ||
            txtclientetele.Text == "" ||
            !va.ComprobarFormatoEmail(txtclienteemail.Text))
            {
                correcto = false;
                if (txttele2.Text == "")
                {
                    txttele2.Text = "0";
                }
                if (txtclienteape2.Text == "")
                {
                    txtclienteape2.Text = "-";
                }
            }
            return correcto;
        }


        private void cbComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComunidad.SelectedIndex != -1 && cbComunidad.SelectedIndex != 0)
            {
                cbProvincia.Enabled = true;
                metcom.rellenacombobox(cbProvincia, "SELECT idprovincia,provincia FROM provincias where refcomunidad=" + cbComunidad.SelectedIndex, "");
            }
            else
            {
                cbProvincia.Enabled = false;
                cbPoblacion.Enabled = false;
                cboCPmultiples.Enabled = false;
            }
            cbProvincia.Text = "";
            cbPoblacion.Text = "";
            //txtclientecodpos.Text = "";
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool canConvert = int.TryParse(cbProvincia.GetItemText(cbProvincia.SelectedValue), out idprov);
            if (canConvert)
            {
                cbPoblacion.Enabled = true;
                metcom.rellenacombobox(cbPoblacion, "SELECT DISTINCT P.IDPOBLACION,P.POBLACION FROM POBLACIONES P,CODIGOSPOSTALESPOBLACIONES CP,PROVINCIAS PP WHERE P.IDPOBLACION = CP.REFPOBLACION "
                    + " AND PP.IDPROVINCIA = CP.REFPROVINCIA AND PP.IDPROVINCIA= " + idprov + " ORDER BY P.POBLACION", "");

            }

        }

        private void cbPoblacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool canConvert = int.TryParse(cbPoblacion.GetItemText(cbPoblacion.SelectedValue), out idpoblacion);
            if (canConvert)
            {
                //MessageBox.Show(cbPoblacion.GetItemText(cbPoblacion.SelectedValue));
                //txtclientecodpos.Text = mc.obtenerDato("codigopostal", "codigospostales", "idcodigopostal=(select refcodigopostal from CODIGOSPOSTALESPOBLACIONES where refpoblacion=(select refpoblacion from CODIGOSPOSTALESPOBLACIONES where refpoblacion=" + idpoblacion + "))").ToString();
                cbPoblacion.Enabled = true;
                metcom.rellenacombobox(cboCPmultiples, "SELECT CP.IDCODIGOPOSTAL, CP.CODIGOPOSTAL" +
                               " FROM CODIGOSPOSTALES CP, CODIGOSPOSTALESPOBLACIONES CPP,POBLACIONES P" +
                                " WHERE CP.IDCODIGOPOSTAL = CPP.REFCODIGOPOSTAL" +
                                " AND P.IDPOBLACION = CPP.REFPOBLACION" +
                                " AND P.IDPOBLACION =" + idpoblacion, "");
                cboCPmultiples.Enabled = true;

            }
        }


        private void cboCPmultiples_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool canConvert = int.TryParse(cboCPmultiples.GetItemText(cboCPmultiples.SelectedValue), out idpoblacionmul);
            //txtclientecodpos.Text = "";
            //if (canConvert)
            //{
            //    txtclientecodpos.Text = cboCPmultiples.Text;
            //    //MessageBox.Show(cbPoblacion.GetItemText(cbPoblacion.SelectedValue));
            //    //txtclientecodpos.Text = mc.obtenerDato("codigopostal", "codigospostales"," idcodigopostal="+idpoblacionmul).ToString();
            //    //mc.obtenerDato("codigopostal", "codigospostales", "idcodigopostal=(select refcodigopostal from CODIGOSPOSTALESPOBLACIONES where refpoblacion=" + idpoblacionmul + ")").ToString();

            //}
        }

        private void txtclientetele_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.escribirSoloEnterosLimitado(e, txtclientetele.Text, txtclientetele.MaxLength, txtclientetele, lblError);
        }

        private void txttele2_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.escribirSoloEnterosLimitado(e, txttele2.Text, txttele2.MaxLength, txttele2, lblError);
        }

    }
}
