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
    public partial class IFUsuariosGUI : Form
    {
        MetodosComunes mc = new MetodosComunes();
        MetodosConsultasSQL mcs = new MetodosConsultasSQL();
        static int id;
        static int rol;
        public IFUsuariosGUI(int idpasado, int rolpasado)
        {
            InitializeComponent();
            id = idpasado;
            rol = rolpasado;
            cargar_Tabla();
            cargarComboRoles();
            cboRol.SelectedIndex = 3;
            
        }

        private void cargar_Tabla()
        {
            try
            {             
                dgvUsuarios.Rows.Clear();

                
                mc.estilodgv(dgvUsuarios);
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData("SELECT * FROM USUARIOS ORDER BY IDUSUARIO", "USUARIOS");

                DataTable tusuarios = data.Tables["USUARIOS"];

                dgvUsuarios.Columns.Add("IDUSUARIO", "IDUSUARIO");
                dgvUsuarios.Columns.Add("NOMBRE", "NOMBRE");
                dgvUsuarios.Columns.Add("PASSW", "PASSW");
                dgvUsuarios.Columns.Add("ROL", "ROL");

                foreach (DataRow row in tusuarios.Rows)
                {
                    dgvUsuarios.Rows.Add(row["IDUSUARIO"], row["NOMBRE"], row["PASSW"], compruebaRol(row["ROL"]));
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }

        }

        private void refrescarTabla()
        {
            try
            {
                string sql = "";
                sql = "SELECT * FROM USUARIOS ";
                if (chkEliminado.Checked)
                {
                    sql = sql + "WHERE ELIMINADO = 1";
                }
                else
                {
                    sql = sql + "WHERE ELIMINADO = 0";
                }
                if (tbNombre.Text.Length > 0)
                {
                    sql = sql + " and upper(NOMBRE) like '%" + tbNombre.Text.ToUpper() + "%'";
                }
                switch (cboRol.SelectedIndex)
                {
                    case 0:
                        sql = sql + " and ROL=" + cboRol.SelectedIndex;
                        break;
                    case 1:
                        sql = sql + " and ROL=" + cboRol.SelectedIndex;
                        break;
                    case 2:
                        sql = sql + " and ROL=" + cboRol.SelectedIndex;
                        break;
                }
                sql = sql + " ORDER BY IDUSUARIO";
                dgvUsuarios.Rows.Clear();                
                mc.estilodgv(dgvUsuarios);
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData(sql, "USUARIOS");

                DataTable tusuarios = data.Tables["USUARIOS"];

                btnModificar.Enabled = false;
                foreach (DataRow row in tusuarios.Rows)//Entrará en este bucle si la consulta devuelve alguna fila
                {//Si entra
                    btnModificar.Enabled = true;//Activo el boton de modificar
                    dgvUsuarios.Rows.Add(row["IDUSUARIO"], row["NOMBRE"], row["PASSW"], compruebaRol(row["ROL"]));
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }
        }
        private object compruebaRol(object p)
        {
            String[] roles = { "SuperAdministrador", "administrador", "vendedor"};
            return roles[Convert.ToInt32(p)];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevousuario = new NuevoUsuario(id,rol);

            nuevousuario.ShowDialog(this);
            refrescarTabla();


        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliRes_Click(object sender, EventArgs e)
        {
            int idsel = Convert.ToInt32(dgvUsuarios.SelectedCells[0].Value.ToString());
            int eliminado;
            if (chkEliminado.Checked == true)
            {
                eliminado = 0;
            }
            else
            {
                eliminado = 1;
            }
            int rolUsuElegido =Convert.ToInt32( mcs.obtenerDato("ROL", "USUARIOS", "IDUSUARIO=" + idsel));
            if (rol<rolUsuElegido)
            {
                String[] datos = { "" + eliminado };
                String[] campos = { "ELIMINADO" };
                String tabla = "USUARIOS";
                String nombreID = "IDUSUARIO";
                mcs.actualizarDato(campos, datos, nombreID, "" + idsel, tabla);
                refrescarTabla();
            }
            else
            {
                MessageBox.Show("No puedes eliminar/restaurar a un usuario con más o los mismos privilegios");
            }
           
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = false;
            if (!(e.RowIndex > -1))
            {
                return;
            }
            else
            {
                //Se activa el boton modificar
                btnModificar.Enabled = true;
            }

           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            int idUsuEle = Convert.ToInt32(dgvUsuarios.SelectedCells[0].Value.ToString());
            int rolUsuEle =Convert.ToInt32(mcs.obtenerDato("ROL", "USUARIOS", "IDUSUARIO=" + idUsuEle));
            if (rol<=rolUsuEle && rol!=2)
            {
                String nombre = mcs.obtenerDato("NOMBRE", "USUARIOS", "IDUSUARIO=" + idUsuEle).ToString();
                ModificarUsuarioGUI modusuario = new ModificarUsuarioGUI(id,rol,idUsuEle, nombre);
                modusuario.ShowDialog(this);
                refrescarTabla(); 
            }
            else
            {
                if (rol==2)
	            {
                    MessageBox.Show("Los vendedores no pueden modificar datos de los usuarios.Por favor contacte con un administrador para mas información");
	            }
                else
                {
                    MessageBox.Show("Permisos insuficientes para modificar a este usuario");
                }
                
            }
          

        }

        private void chkEliminado_CheckedChanged(object sender, EventArgs e)
        {
            
            cambiarBoton();
            refrescarTabla();
        }

        private void cambiarBoton()
        {
            
            if (chkEliminado.Checked == true)
            {
                btnEliRes.Text = "Restaurar";
            }
            else
            {
                btnEliRes.Text = "Eliminar";
            }
        }
        private void cargarComboRoles()
        {
            String[] roles = { "Superadministrador", "Administrador", "Vendedor", "Seleccione un rol" };
            cboRol.DataSource = roles;
        }

        private void tbNombre_KeyUp(object sender, KeyEventArgs e)
        {
            refrescarTabla();
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}

