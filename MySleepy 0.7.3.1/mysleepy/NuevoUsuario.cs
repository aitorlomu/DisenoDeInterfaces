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
    public partial class NuevoUsuario : Form
    {
        MetodosConsultasSQL mcs = new MetodosConsultasSQL();
        MetodosComunes mc = new MetodosComunes();
        String PASSWORDENCRIPTAR = ("glados");
        int id;
        int rol;
        public NuevoUsuario(int idpasado, int rolpasado)
        {
            InitializeComponent();
            btnCrear.Enabled = false;
            id = idpasado;
            rol = rolpasado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtRepPassword_TextChanged(object sender, EventArgs e)
        {
            
            comprobarClaves(); 
            comprobarCampos();
        
        }

        private void cbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void comprobarCampos()
        {
            if (txtNombre.Text != "" && comprobarClaves() && cbRol.SelectedIndex>=0 && comprobarUsuario()==false)
            {
                btnCrear.Enabled = true;
            }
            else
            {
                btnCrear.Enabled = false;
            }

        }

        public Boolean comprobarClaves()
        {
            Boolean igual = false;
            String c1 = txtPassword.Text;
            String c2 = txtRepPassword.Text;

            if (c1.Equals(c2))
            {
                
                txtPassword.BackColor = Color.Green;
                txtRepPassword.BackColor = Color.Green;
                igual = true;
            }
            else
            {
                
                txtPassword.BackColor = Color.Red;
                txtRepPassword.BackColor = Color.Red;
                igual = false;
            }

            if (c1 == "" || c2 == "")
            {
                txtPassword.BackColor = Color.White;
                txtRepPassword.BackColor = Color.White;
                igual = false;
            }

            return igual;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            comprobarCampos();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            comprobarCampos();
        }

        private void cbRol_TextChanged(object sender, EventArgs e)
        {
            comprobarCampos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Esta seguro de que quiere introducir a este nuevo Usuario?", "Guardar", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                try
                {
                    int rol = cbRol.SelectedIndex + 1;
                    String nombreLog=mcs.obtenerDato("NOMBRE","USUARIOS","IDUSUARIO="+id).ToString();
                    String passEncriptada = mc.EncryptText(txtPassword.Text, PASSWORDENCRIPTAR);
                    string[] datos = { "SEC_USUARIOS.NEXTVAL", "\'" + txtNombre.Text + "\'", "\'" + passEncriptada + "\'", "" + rol, "0" };
                    mcs.insertarFila(datos, "USUARIOS");
                    mcs.añadirLog(id, 'C', "El usuario " + nombreLog + " ha creado al usuario " + txtNombre.Text + " con el rol " + rol);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
               
                
            }
        }

        private Boolean comprobarUsuario()
        {
            Boolean repetido = false;
            String nombreusu = mcs.obtenerDato("NOMBRE", "USUARIOS", "UPPER(NOMBRE)='" + txtNombre.Text.ToUpper() + "'").ToString().ToUpper();
            if (nombreusu==txtNombre.Text.ToUpper())
            {
                MessageBox.Show("Este nombre de usuario ya existe, por favor introduzca otro");
                txtNombre.Text = "";
                repetido = true;
            }
            return repetido;
        }



      

      
    }
}
