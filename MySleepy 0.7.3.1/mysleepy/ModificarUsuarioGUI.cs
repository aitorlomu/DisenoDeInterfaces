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
    public partial class ModificarUsuarioGUI : Form
    {
        private int idpasado;
        private string nombre;
        static int id;
        static int rol;
        String PASSWORDENCRIPTAR = ("glados");
        MetodosComunes mc = new MetodosComunes();
        MetodosConsultasSQL mcs = new MetodosConsultasSQL();

        public ModificarUsuarioGUI(int idlog, int rollog,int idsel, string nombre)
        {
            this.idpasado = idsel;
            this.nombre = nombre;
            id = idlog;
            rol = rollog;
            InitializeComponent();
            txtNombre.Text = nombre;
            btnGuardar.Enabled = false;
            comprobarUsuarioPasado();
            
        }

        private void comprobarUsuarioPasado()
        {
            if (rol==0 && idpasado==1)
            {
                txtNombre.Enabled = false;
                cbRol.Enabled = false;
            }
        }

        public void modificarDatos(int id,string nombre)
        {
            String passEncriptada,tabla,nombreID;
            String[] datos;
            String[] campos;

            if (rol==0)//si es el admin no puede cambiar ni su rol ni su nombre(Estan deshabilitados), solo la pass
            {
            passEncriptada = mc.EncryptText(txtPassword.Text, PASSWORDENCRIPTAR);
            String [] datosusu ={ "'" + txtNombre.Text + "'", "'" + passEncriptada + "'", "" + 0 };
            String [] camposusu = { "NOMBRE", "PASSW", "ROL" };
            tabla = "USUARIOS";
            nombreID = "IDUSUARIO";
            campos = camposusu;
            datos = datosusu;
            }
            else
            {
                int rolcb = cbRol.SelectedIndex + 1;
                passEncriptada = mc.EncryptText(txtPassword.Text, PASSWORDENCRIPTAR);
                String[] datosusu = { "'" + txtNombre.Text + "'", "'" + passEncriptada + "'", "" + rolcb };
                String[] camposusu = { "NOMBRE", "PASSW", "ROL" };
                tabla = "USUARIOS";
                nombreID = "IDUSUARIO";
                campos = camposusu;
                datos = datosusu;
            }
            
            
            

            mcs.actualizarDato(campos, datos, nombreID,""+idpasado, tabla);

            
        }

        public void comprobarCampos()
        {
            if ((txtNombre.Text != "" && txtPassword.Text != "" && cbRol.SelectedIndex >= 0) || (txtNombre.Text =="GLaDOS" && txtPassword.Text !=""))
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modificarDatos(idpasado,nombre);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarCampos();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            comprobarCampos();
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            comprobarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
