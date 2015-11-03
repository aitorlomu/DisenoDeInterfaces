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
    public partial class PedidosGUI : Form
    {
        static int idUsuario;

        public PedidosGUI(int id)
        {
            InitializeComponent();
            cargar_Tabla();
            idUsuario = id;
        }

        private void cargar_Tabla()
        {
            try
            {
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData("SELECT * FROM PEDIDOS", "PEDIDOS");

                DataTable tusuarios = data.Tables["PEDIDOS"];

                dgvListaPedidos.Columns.Add("REFCLIENTE", "REFCLIENTE");
                dgvListaPedidos.Columns.Add("REFUSUARIO", "REFUSUARIO");
                dgvListaPedidos.Columns.Add("FECHAPEDIDO", "FECHAPEDIDO");
                dgvListaPedidos.Columns.Add("FECHAENTREGA", "FECHAENTREGA");
                dgvListaPedidos.Columns.Add("REFFORMAPAGO", "REFFORMAPAGO");
                dgvListaPedidos.Columns.Add("TOTAL", "TOTAL");
                dgvListaPedidos.Columns.Add("PAGADO", "PAGADO");
                dgvListaPedidos.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvListaPedidos.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (DataRow row in tusuarios.Rows)
                {
                    dgvListaPedidos.Rows.Add(row["REFCLIENTE"], row["REFUSUARIO"], row["FECHAPEDIDO"], row["FECHAENTREGA"], row["REFFORMAPAGO"], row["TOTAL"], row["PAGADO"]);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedidoGUI nuevoPedido = new NuevoPedidoGUI(idUsuario);
            nuevoPedido.ShowDialog(this);
         
        }
    }
}
