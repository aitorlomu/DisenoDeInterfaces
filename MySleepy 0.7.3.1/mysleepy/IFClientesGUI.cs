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
    public partial class IFClientesGUI : Form
    {
        MetodosComunes mc = new MetodosComunes();
        MetodosConsultasSQL metcom = new MetodosConsultasSQL();
        NuevoClienteGUI gesCliente;
        ModificarCliente modCliente;
        static int eliminados;
        String sqlDEFECTO;
        private int id;
        public IFClientesGUI(int idpasado)
        {
            this.id = idpasado;
            eliminados = 0;
            sqlDEFECTO = "SELECT * FROM CLIENTES WHERE ELIMINADO=" + eliminados + " ORDER BY IDCLIENTE";
            InitializeComponent();

            dgvClientes.ClearSelection();
            dgvClientes.CurrentCell = null;
            cbCamposClientes.SelectedIndex = 0;
            cargar_Tabla(sqlDEFECTO);
        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            gesCliente = new NuevoClienteGUI(id);
            gesCliente.ShowDialog(this);
            refrescarTabla(sqlDEFECTO);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvClientes.SelectedCells[0].Value.ToString());
                modCliente = new ModificarCliente(id);
                modCliente.ShowDialog(this);
                refrescarTabla(sqlDEFECTO);
            }
            else
            {
                MessageBox.Show("Selecciona un registro");
            }
        }

        private void btnCerrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void filtrar()
        {
            String sql = "SELECT * FROM CLIENTES WHERE ";
            String filt = txtFiltro.Text.ToUpper();
            switch (cbCamposClientes.SelectedIndex)
            {                   
                case 0:                   
                    break;
                case 1:
                    sql = sql + "  UPPER(NOMBRE)  LIKE \'%" + filt + "%\' and";
                    break;
                case 2:
                    sql = sql + "  UPPER(APELLIDO1) LIKE \'%" + filt + "%\' and";
                    break;
                case 3:
                    sql = sql + "  UPPER(APELLIDO2) LIKE \'%" + filt + "%\' and";
                    break;
                case 4:
                    sql = sql + "  UPPER(DIRECCION) LIKE \'%" + filt + "%\' and";
                    break;
                case 5:
                    sql = sql + "  UPPER(to_char(REFCPPOBLACIONES)) LIKE \'%" + filt + "%\' and";
                    break;
                case 6:
                    sql = sql + "  UPPER(COMUNIDAD) LIKE \'%" + filt + "%\' and";
                    break;
                case 7:
                    sql = sql + "  UPPER(PROVINCIA) LIKE \'%" + filt + "%\' and";
                    break;
                case 8:
                    sql = sql + "  UPPER(POBLACION) LIKE \'%" + filt + "%\' and";
                    break;
                case 9:
                    sql = sql + "  UPPER(to_char(TELEFONO1)) LIKE \'%" + filt + "%\' and";
                    break;
                case 10:
                    sql = sql + "  UPPER(to_char(TELEFONO2)) LIKE \'%" + filt + "%\' and";
                    break;
                case 11:
                    sql = sql + "  UPPER(EMAIL) LIKE \'%" + filt + "%\' and";
                    break;
                    
            }
            sql +=  " ELIMINADO=" + eliminados + " ORDER BY IDCLIENTE";
            refrescarTabla(sql);
        }


        private void cargar_Tabla(String sql)
        {
            try
            {

                dgvClientes.Rows.Clear();

                mc.estilodgv(dgvClientes);
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData(sql, "CLIENTES");

                DataTable tclientes = data.Tables["CLIENTES"];

                dgvClientes.Columns.Add("IDCLIENTE", "IDUSUARIO");
                dgvClientes.Columns.Add("NOMBRE", "NOMBRE");
                dgvClientes.Columns.Add("APELLIDO1", "APELLIDO 1");
                dgvClientes.Columns.Add("APELLIDO2", "APELLIDO 2");
                dgvClientes.Columns.Add("DIRECCION", "DIRECCION");
                dgvClientes.Columns.Add("REFCPPOBLACIONES", "CODIGO POSTAL");
                dgvClientes.Columns.Add("COMUNIDAD", "COMUNIDAD");              
                dgvClientes.Columns.Add("PROVINCIA", "PROVINCIA");
                dgvClientes.Columns.Add("POBLACION", "POBLACION");
                dgvClientes.Columns.Add("TELEFONO1", "TELEFONO 1");
                dgvClientes.Columns.Add("TELEFONO2", "TELEFONO 2");
                dgvClientes.Columns.Add("EMAIL", "EMAIL");

                foreach (DataRow row in tclientes.Rows)
                {
                    dgvClientes.Rows.Add(row["IDCLIENTE"], row["NOMBRE"], row["APELLIDO1"], row["APELLIDO2"], row["DIRECCION"], row["REFCPPOBLACIONES"], row["COMUNIDAD"],  row["PROVINCIA"],row["POBLACION"], row["TELEFONO1"], row["TELEFONO2"], row["EMAIL"]);
                }
                dgvClientes.ClearSelection();
                dgvClientes.CurrentCell = null;
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }

        }

        private void refrescarTabla(String sql)
        {
            try{
                dgvClientes.Rows.Clear();

                mc.estilodgv(dgvClientes);
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData(sql, "CLIENTES");

                DataTable tclientes = data.Tables["CLIENTES"];

                
                foreach (DataRow row in tclientes.Rows)
                {
                    dgvClientes.Rows.Add(row["IDCLIENTE"], row["NOMBRE"], row["APELLIDO1"], row["APELLIDO2"], row["DIRECCION"], row["REFCPPOBLACIONES"], row["COMUNIDAD"], row["PROVINCIA"], row["POBLACION"], row["TELEFONO1"], row["TELEFONO2"], row["EMAIL"]);              
                }
                dgvClientes.ClearSelection();
                dgvClientes.CurrentCell = null;
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {

                String id = dgvClientes.SelectedCells[0].Value.ToString();


                INuevoPedido formInterface = this.Owner as INuevoPedido;

                if (formInterface != null)
                {

                    formInterface.ChangeClientes(id);
                    this.Close();
                }
            
            
        }

        private void chkClientesEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClientesEliminados.Checked == true)
            {
                eliminados = 1;
                btnElimCliente.Text = "Restaurar Cliente";               
            }
            else
            {
                eliminados = 0;
                btnElimCliente.Text = "Eliminar Cliente";              
            }
            sqlDEFECTO = "SELECT * FROM CLIENTES WHERE ELIMINADO=" + eliminados + " ORDER BY IDCLIENTE";
            refrescarTabla(sqlDEFECTO);
        }

        private void btnElimCliente_Click(object sender, EventArgs e)
        {sqlDEFECTO="SELECT * FROM CLIENTES WHERE ELIMINADO="+eliminados+" ORDER BY IDCLIENTE";
            
            if (dgvClientes.SelectedCells.Count>0)
            {
                int id = Convert.ToInt32(dgvClientes.SelectedCells[0].Value.ToString());
                if (eliminados == 0)
                {
                    metcom.actualizarDato("ELIMINADO", 1+"", "IDCLIENTE", id + "", "CLIENTES");
                }
                else
                {
                    metcom.actualizarDato("ELIMINADO", 0+"", "IDCLIENTE", id + "", "CLIENTES");
                }
                sqlDEFECTO = "SELECT * FROM CLIENTES WHERE ELIMINADO=" + eliminados + " ORDER BY IDCLIENTE";
                txtFiltro.Text="";
                refrescarTabla(sqlDEFECTO);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                filtrar();
            }
            else
            {
                refrescarTabla(sqlDEFECTO);
            }
        }
    }
}
