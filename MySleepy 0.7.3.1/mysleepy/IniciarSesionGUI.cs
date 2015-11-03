using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MySleepy
{
    public partial class IniciarSesionGUI : Form
    {
        MetodosComunes mc = new MetodosComunes();
        MetodosConsultasSQL metcon = new MetodosConsultasSQL();
        String PASSWORDENCRIPTAR = ("glados");
        public IniciarSesionGUI()
        {
            InitializeComponent();
        }

        private void btnCancelarIS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarIS_Click(object sender, EventArgs e)
        {
            login();           
        }

        private void login()
        {
            if (txtUsuarioIS.Text != "" && txtContraseñaIS.Text != "")
            {
                if (comprobarLogin())
                {

                    MessageBox.Show("Usuario y contraseña correctos. Bienvenido " + txtUsuarioIS.Text);
                    int id = Convert.ToInt32(metcon.obtenerDato("IDUSUARIO", "USUARIOS", "NOMBRE='"+txtUsuarioIS.Text+"'"));
                    int rol = Convert.ToInt32(metcon.obtenerDato("ROL", "USUARIOS", "IDUSUARIO=" + id));
                    EscritorioGUI formuPrincipal = new EscritorioGUI(rol,id);
                    //MessageBox.Show("id IniciarSesión: "+id);
                    this.Hide();
                    formuPrincipal.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");

                }

            }
            else
            {
                MessageBox.Show("Debes introducir tanto un usuario como una contraseña");
            }
        }

        private bool comprobarLogin()
        {
            Boolean correcto = false;
            ConnectDB conexion = new ConnectDB();
            DataSet data = new DataSet();
            //MAGIA DE LA MAS NEGRA
            
            data = conexion.getData("SELECT NOMBRE, PASSW FROM USUARIOS WHERE NOMBRE= \'"+txtUsuarioIS.Text+"\' AND "+
            "PASSW= \'"+mc.EncryptText(txtContraseñaIS.Text,PASSWORDENCRIPTAR)+"\' AND ELIMINADO=0 ","USUARIOS");

            DataTable usuarios = data.Tables["USUARIOS"];
            if (usuarios.Rows.Count == 0)
            {
                MessageBox.Show("Error de conexión");
            }
            else
            {
                //MessageBox.Show("Conexión correcta");               
                correcto = true;
            }

            

            return correcto;
        }

        private void txtUsuarioIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                login();
            }
        }

        private void txtContraseñaIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                login();
            }
        }




    }
}
