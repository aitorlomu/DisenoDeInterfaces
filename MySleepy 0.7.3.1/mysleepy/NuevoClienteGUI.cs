using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySleepy
{
    public partial class NuevoClienteGUI : Form

    {
        private int id;
        int idusuario;
        MetodosConsultasSQL mc = new MetodosConsultasSQL();
        MetodosComunes metcom = new MetodosComunes();
        private int idpoblacionmul;
        private int idprov;
        private int idpoblacion;
        Validaciones va = new Validaciones();
        public NuevoClienteGUI(int idpasado)
        {

            idusuario = id;
            InitializeComponent();

            string sql = "SELECT idcomunidad,comunidad FROM comunidades";
            metcom.rellenacombobox(cbComunidad, sql, "");
            cbProvincia.Enabled = false;
            cbPoblacion.Enabled = false;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres salir? Los datos no guardados se perderán", "Cancelar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
         
            if (comprobarFormulario())
            {
                String[] nuevocliente ={"SEQ_CLIENTES.NEXTVAL", 
                                          "\'"+txtclientenombre.Text+"\'",
                                          "\'"+txtclienteape1.Text+"\'",
                                          "\'"+txtclienteape2.Text+"\'",
                                          "\'"+txtclientedireccion.Text+"\'",
                                          cboCPmultiples.Text,                                         
                                          "\'"+cbComunidad.Text+"\'",
                                          "\'"+cbProvincia.Text+"\'",
                                          "\'"+cbPoblacion.Text+"\'",
                                          txttele1.Text,
                                          txttele2.Text,
                                          "\'"+txtclienteemail.Text+"\'",
                                          "0"
                                          
                                  };

                mc.insertarFila(nuevocliente, "CLIENTES");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Debe cumplimentar todos los datos del formulario");
            }
            
        }

        private bool comprobarFormulario()
        {
            Boolean correcto = true;
            if(
            txtclientenombre.Text==""||
            txtclienteape1.Text==""||
            txtclientedireccion.Text==""||
            cboCPmultiples.Text == "" ||
            cbComunidad.Text == "" ||
            cbProvincia.Text==""||
            cbPoblacion.Text == "" ||
            txttele1.Text==""||
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

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtclientenombre.Text="";
            txtclienteape1.Text="";
            txtclienteape2.Text="";
            txtclientedireccion.Text="";
            cboCPmultiples.SelectedIndex = 0;
            txttele1.Text="";
            txttele2.Text = "";
            cbComunidad.SelectedIndex=0;
            cbProvincia.SelectedIndex=0;
            cbPoblacion.SelectedIndex = 0;
            txtclienteemail.Text = "";

            cbProvincia.Enabled = false;
            cbPoblacion.Enabled = false;
            cboCPmultiples.Enabled = false;
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
                
            }

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
            //        //mc.obtenerDato("codigopostal", "codigospostales", "idcodigopostal=(select refcodigopostal from CODIGOSPOSTALESPOBLACIONES where refpoblacion=" + idpoblacionmul + ")").ToString();

            //}
        }

        private void txttele1_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.escribirSoloEnterosLimitado(e, txttele1.Text, txttele1.MaxLength, txttele1, lblError);
        }

        private void txttele2_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.escribirSoloEnterosLimitado(e, txttele2.Text, txttele2.MaxLength, txttele2, lblError);
        }

        


        

        



      
    }
}
