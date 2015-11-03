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
    public partial class AddArticuloGUI : Form, IArticulos
    {
        public int stockProducto;

        public AddArticuloGUI()
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
            txtNombreArticulo.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecioVenta.Enabled = false;
        }

        void IdArticulo(string id)
        {
            txtRefArticulo.Text = id;
        }

        private void btnExplorarArticulos_Click(object sender, EventArgs e)
        {
            ArticulosGUI nuevoExplorarArticulos = new ArticulosGUI();
            nuevoExplorarArticulos.btnAddArt.Visible = true;
            nuevoExplorarArticulos.ShowDialog(this);
        }






        void IArticulos.changeArticulo(string id, string nombre, string stock, string precio)
        {
            txtRefArticulo.Text = id;
            txtNombreArticulo.Text = nombre;
            txtPrecioVenta.Text = precio;
            this.stockProducto = Convert.ToInt32(stock);
            txtCantidad.Text = "1";
            lblStock.Text = "Stock disponible: " + Convert.ToString(this.stockProducto);
        }

        private void btnStock_Click(object sender, EventArgs e)
        { }

        private void btnCalcularImporte_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precio = Convert.ToDecimal(txtPrecioVenta.Text);
            decimal importe = cantidad * precio;
            txtImporte.Text = Convert.ToString(importe);
            comprobarStock();
            comprobarCampos();

        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            string cantidad = txtCantidad.Text;
            cantidad.TrimStart('0');
            if (txtCantidad.Text == "" || txtCantidad.Text == "0")
            {
                txtCantidad.Text = "1";
            }
            if (comprobarStock() == false)
            {
                MessageBox.Show("Cantidad superior al stock del producto.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String id = txtRefArticulo.Text;
            String nombre = txtNombreArticulo.Text;
            String cantidad = txtCantidad.Text;
            String precioVenta = txtPrecioVenta.Text;

            decimal precioT = Convert.ToDecimal(cantidad) * Convert.ToDecimal(precioVenta);
            String precioTotal = Convert.ToString(precioT);



            INuevoPedido nuevoArtInterface = this.Owner as INuevoPedido;

            if (nuevoArtInterface != null)
            {
                
                nuevoArtInterface.cargarArticuloNuevo(id, nombre, cantidad, precioVenta, precioTotal);
                this.Close();
            }
        }

        private void txtRefArticulo_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void comprobarCampos()
        {
            if (txtRefArticulo.Text != "" && txtNombreArticulo.Text != "" && txtCantidad.Text !="" && txtPrecioVenta.Text != "" && comprobarStock())
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }

        }

        public void permitirCalcular()
        {
            if (txtRefArticulo.Text != "" && txtCantidad.Text != "" && txtNombreArticulo.Text != "" && txtPrecioVenta.Text != "")
            {
                btnCalcularImporte.Enabled = true;
            }
            else
            {
                btnCalcularImporte.Enabled = false;
            }
        }

        public Boolean comprobarStock()
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int stock = stockProducto;

            if (cantidad > stock)
            {
                return false;
            }
            return true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            permitirCalcular();
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "")
            {
                txtPrecioVenta.Text = "0";
            }

        }

        private void btnCalcularImporte_Leave(object sender, EventArgs e)
        {}

        private void txtRefArticulo_Leave(object sender, EventArgs e)
        {
            comprobarCampos();
          
        }

        private void txtNombreArticulo_Leave(object sender, EventArgs e)
        {
            comprobarCampos();
        }

        private void txtRefArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRefArticulo_TextChanged_1(object sender, EventArgs e)
        {
            comprobarCampos();
            permitirCalcular();
            if (txtRefArticulo.Text != "")
            {
                txtNombreArticulo.Enabled = true;
                txtCantidad.Enabled = true;
                txtPrecioVenta.Enabled = true;
            }

            else
            {
                txtNombreArticulo.Enabled = false;
                txtCantidad.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtNombreArticulo.Text = "";
                txtCantidad.Text = "";
                txtPrecioVenta.Text = "";
                txtImporte.Text = "";
            }
        }

        private void txtNombreArticulo_TextChanged(object sender, EventArgs e)
        {
            permitirCalcular();
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            permitirCalcular();
        }
    }
}

