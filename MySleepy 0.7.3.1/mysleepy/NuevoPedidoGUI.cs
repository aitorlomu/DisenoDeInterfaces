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
    public partial class NuevoPedidoGUI : Form, INuevoPedido
    {
        MetodosConsultasSQL mcs = new MetodosConsultasSQL();
      
        int idPedido;
        int idCliente;
        static int idUsuario;

        String idFormaPago;
        int pagado;
        int eliminado;
        String refArticulo;
        String nombreArticulo;
        String precioVentaArticulo;
        String precioTotalArticulo;
        String cantidadArticulo;
        decimal importeTotal;

        public NuevoPedidoGUI(int id)
        {
            InitializeComponent();
            cargarFormasPago();
            importeTotal = 0;
            idPedido = id;
            MessageBox.Show("idUsuario NuevoPedido: " + id);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (dgvNuevoPedido.Rows.Count != 0)
            {
                DialogResult opcion = MessageBox.Show("Los pedidos no procesados se eliminarán. ¿Está seguro que quiere salir?", "Aviso", MessageBoxButtons.OKCancel);
                if (opcion == DialogResult.OK)
                {
                    this.Close();

                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere procesar este pedido?", "Aviso", MessageBoxButtons.OKCancel);
            if (opcion == DialogResult.OK)
            {
                procesarPedido();
                insertarArticulosPedido();
                actualizarStocks();
                Console.WriteLine("Pedido procesado");
                dgvNuevoPedido.Rows.Clear();
                txtRefCliente.Text = "";


            }

        }

        private void actualizarStocks()
        {
            


            for (int i = 0; i < dgvNuevoPedido.Rows.Count - 1; i++)
            {

            string cant = dgvNuevoPedido.Rows[i].Cells[2].Value.ToString();
            string refArticulo = dgvNuevoPedido.Rows[i].Cells[0].Value.ToString();
            mcs.actualizarStock("STOCK","STOCK-"+ cant, "IDARTICULO",refArticulo, "ARTICULOS");
           
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            IFClientesGUI nuevoExplorarClientes = new IFClientesGUI(idPedido);
            nuevoExplorarClientes.btnCargarCliente.Visible = true;
            nuevoExplorarClientes.ShowDialog(this);
        }

        public void cargarArticuloNuevo(string idArticulo, string nombre, string cantidad, string precio, string precioTotal)
        {
            this.refArticulo = idArticulo;
            this.nombreArticulo = nombre;
            this.cantidadArticulo = cantidad;
            this.precioVentaArticulo = precio;
            this.precioTotalArticulo = precioTotal;
            existeArticulo(idArticulo);
            dgvNuevoPedido.Rows.Add(this.refArticulo, this.nombreArticulo, this.cantidadArticulo, this.precioVentaArticulo, this.precioTotalArticulo);

            decimal precioTotalArticulo = Convert.ToDecimal(this.precioTotalArticulo);
            calcularImporteTotal(precioTotalArticulo);


            
        }

        public Boolean existeArticulo(string idarticulo)
        {
            for (int i = 0; i < dgvNuevoPedido.Rows.Count - 1; i++)
            {
            

                if (idarticulo == dgvNuevoPedido.Rows[i].Cells[0].Value.ToString())
                {
                    
                    dgvNuevoPedido.Rows.Remove(dgvNuevoPedido.Rows[i]);
                    Console.WriteLine("Existe");
                    return true;
                }
               
                    
               
            }

            return false;
        }

   

        public void ChangeClientes(string text)
        {
            txtRefCliente.Text = text;
        }

        public void calcularImporteTotal(decimal cantidad)
        {
            this.importeTotal += cantidad;
            lblTotalPedido.Text =(Convert.ToString(this.importeTotal));
        }

        

        private void cargarFormasPago()
        {
            try
            {
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData("SELECT FORMAPAGO FROM FORMASDEPAGO","FORMASDEPAGO");

                DataTable tFormasPago= data.Tables["FORMASDEPAGO"];



                foreach (DataRow row in tFormasPago.Rows)
                {
                    cbFormaPago.DataSource = data.Tables[0];
                    cbFormaPago.DisplayMember = "FORMAPAGO";

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddArticuloGUI nuevoAddArticulo = new AddArticuloGUI();
            nuevoAddArticulo.ShowDialog(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvNuevoPedido.RowCount != 0)
                {



                    dgvNuevoPedido.Rows.Remove(dgvNuevoPedido.CurrentRow);
                    //int fila = dgvNuevoPedido.CurrentRow.Index;
                    
                }
                else
                {
                    MessageBox.Show("No hay articulos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar articulo"); 
            }
        }

        private int convertirFechaANumero(DateTimePicker dtp)
        {
            DateTime dt = dtp.Value;
            string dtS = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString();
            int dtI = Convert.ToInt32(dtS);
            Console.WriteLine(dtI);
            return dtI;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            

        }

        public void insertarArticulosPedido()
        {
            for (int i = 0; i < dgvNuevoPedido.Rows.Count - 1; i++)
            {

                int fechaPedido = convertirFechaANumero(calendarFechaPedido);
                string id = dgvNuevoPedido.Rows[i].Cells[0].Value.ToString();
                //Console.WriteLine("id: "+id);
                string cantidad = dgvNuevoPedido.Rows[i].Cells[2].Value.ToString();
                //Console.WriteLine("cantidad: " + cantidad);
                string precioVenta = dgvNuevoPedido.Rows[i].Cells[3].Value.ToString();
                //Console.WriteLine("precio Venta: " + precioVenta);
                //Console.WriteLine("-----");

                String[] nuevoPedidosArticulo ={fechaPedido+"||"+"SEQ_PEDIDOSARTICULO.NEXTVAL", 
                                          fechaPedido+"||"+"SEQ_PEDIDOS.CURRVAL",
                                          "\'"+id+"\'",
                                          "\'"+cantidad+"\'",
                                          "\'"+precioVenta+"\'",     
                                  };

                mcs.insertarFila(nuevoPedidosArticulo, "PEDIDOSARTICULOS");



            }
        }

        public void procesarPedido()
        {
           
            this.idCliente = Convert.ToInt32(txtRefCliente.Text);
            this.idFormaPago = Convert.ToString(cbFormaPago.SelectedIndex+1);
            this.importeTotal = Convert.ToDecimal(lblTotalPedido.Text);
            this.pagado = 0;
            this.eliminado = 0;
            int fechaPedido = convertirFechaANumero(calendarFechaPedido);

            String[] nuevoPedido ={fechaPedido+"||"+"SEQ_PEDIDOS.NEXTVAL", 
                                          txtRefCliente.Text,
                                         "\'"+idPedido+"\'",
                                          "\'"+calendarFechaPedido.Value.ToString("dd/MM/yy")+"\'",
                                          "\'"+calendarFechaEntrega.Value.ToString("dd/MM/yy")+"\'",
                                          this.idFormaPago,
                                          "\'"+lblTotalPedido.Text+"\'",
                                          "0",
                                          "0"
                                          
                                  };
            mcs.insertarFila(nuevoPedido, "PEDIDOS");



        }

       

       
    }
}
