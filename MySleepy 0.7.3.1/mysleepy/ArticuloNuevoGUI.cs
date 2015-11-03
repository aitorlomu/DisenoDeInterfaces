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
    public partial class ArticuloNuevoGUI : Form
    {
        MetodosComunes funciones = new MetodosComunes();
        MetodosConsultasSQL consultas = new MetodosConsultasSQL();
        ConnectDB conexion = new ConnectDB();
        Validaciones validar = new Validaciones();
        ArticulosGUI padre;
        private int idNuevo;
        
        public ArticuloNuevoGUI()
        {
            InitializeComponent();
            string sql = "SELECT IDTIPO,DESCRIPCION FROM TIPOARTICULO";
            funciones.rellenacombobox(cboTipo, sql, "-- Seleccione tipo --");
            idNuevo = -1;
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtPeso.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cboTipo.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        public void asignaPadre(ArticulosGUI p)
        {
            padre = p;
        }
        public void rellenaDatos(int id)
        {
            String nombre = consultas.obtenerDato("NOMBRE", "ARTICULOS", "IDARTICULO = " + id).ToString();
            String stock = consultas.obtenerDato("STOCK", "ARTICULOS", "IDARTICULO = " + id).ToString();
            String precio = consultas.obtenerDato("PRECIO", "ARTICULOS", "IDARTICULO = " + id).ToString();
            precio = precio.Replace(",", ".");
            String peso = consultas.obtenerDato("PESO", "ARTICULOS", "IDARTICULO= " + id).ToString();
            String tipo = consultas.obtenerDato("TIPO", "ARTICULOS", "IDARTICULO= " + id).ToString();

            cboTipo.SelectedValue = tipo;
            txtNombre.Text = nombre;
            txtStock.Text = stock;
            txtPrecio.Text = precio;
            txtPeso.Text = peso;
            idNuevo = id;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private Boolean comprobarVacios()
        {
            Boolean resultado = false;
            String mensaje = "ERROR: \n";
            if(txtNombre.Text.Equals("")){
                mensaje = mensaje + " Introduzca un Nombre\n";
                resultado = true;
            }
            if(txtStock.Text.Equals("")){
                mensaje = mensaje + " Introduzca un Stock\n";
                resultado = true;
            }
            if(txtPrecio.Text.Equals("")){
                mensaje = mensaje + " Introduzca un Precio\n";
                resultado = true;
            }
            if(txtPeso.Text.Equals("")){
                mensaje = mensaje + "Introduzca un Peso\n ";
                resultado = true;
            }
            if(cboTipo.SelectedIndex == 0){
                mensaje = mensaje + " Seleccione un Tipo\n";
                resultado = true;
            }
            if(resultado){
                MessageBox.Show(mensaje);
            }
            return resultado;

        }
        private void insertarNuevoArticulo()
        {
            String nombre, stock, precio, peso, tipo,eliminado;
            nombre = "'"+txtNombre.Text+"'";
            precio = txtPrecio.Text;
            peso = txtPeso.Text;
            stock = txtStock.Text;
            tipo = cboTipo.SelectedValue.ToString();
            eliminado = "0";

           String [] datosArticulo = {"SEQ_ARTICULOS.NEXTVAL",nombre,stock,precio,peso,tipo,eliminado};
           int resultado = consultas.insertarFila(datosArticulo, "ARTICULOS");
           //MessageBox.Show(resultado.ToString()); // Si da 1 es correcto si da 0 ha dado error
           MessageBox.Show("Artículo grabado");
         
        }
        private int modificarArticulo()
        {
            String nombre = txtNombre.Text;
            String stock = txtStock.Text;
            String precio = txtPrecio.Text;
            String peso = txtPeso.Text;
            String tipo = cboTipo.SelectedValue.ToString();

            String sql = "UPDATE ARTICULOS SET IDARTICULO=" + idNuevo.ToString();
           //ACTUALIZAMOS EL NOMBRE
            sql = sql + ",NOMBRE='" + nombre + "'";
            //ACTUALIZAMOS EL STOCK
            sql = sql + ",STOCK=" + stock;
            //ACTUALIZAMOS EL PRECIO
            sql = sql + ",PRECIO=" + precio;
            // ACTUALIZAMOS EL PESO
            sql = sql + ",PESO=" + peso;
            // ACTUALIZAMOS EL TIPO
            sql = sql + ",TIPO=" + tipo;
            // SELECCIONAMOS EL IDARTICULO
            sql = sql + " WHERE IDARTICULO=" + idNuevo.ToString();
            //MessageBox.Show(sql);
            try
            {
                conexion.setData(sql);
                MessageBox.Show("Artículo modificado con éxito");
                return 0;
            }catch(Exception e){
                return -1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!comprobarVacios())
            {
                if (idNuevo == -1)
                { // El caso de que el artículo sea un nuevo articulo
                    insertarNuevoArticulo();
                    this.Close();
                }
                else
                {
                    modificarArticulo();
                    this.Close();
                }
            }
            
        }

        private void ArticuloNuevoGUI_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.escribirSoloDoubles(txtPrecio, e, "PRECIO", lblPrecio, 4, 2);
        }

        private void bntTipo_Click(object sender, EventArgs e)
        {
            String descripcion = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre del nuevo tipo", "TIPO", "");
            String descripcionMayuscula = descripcion.ToUpper();
            //MessageBox.Show("" + descripcion);
            
            if(descripcionMayuscula.Equals("")){

            }
            else
            {
                if(descripcionMayuscula.Length>40){
                    MessageBox.Show("No se puede introducir un tipo de más de 40 caracteres");
                }
                else
                {
                    if (!comprobarDescripcion(descripcionMayuscula))
                    {
                        String[] datosTipo = { "SEQ_TIPO.NEXTVAL", "'" + descripcion + "'", "0" };
                        int resultado = consultas.insertarFila(datosTipo, "TIPOARTICULO");
                        string sql = "SELECT IDTIPO,DESCRIPCION FROM TIPOARTICULO";
                        funciones.rellenacombobox(cboTipo, sql, "-- Seleccione tipo --");
                        MessageBox.Show("Tipo Creado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un tipo con esa descripción");
                    }
                }

                
                
            }
            

        }
        private Boolean comprobarDescripcion(String descripciondada)
        {
            Boolean resultado = false;
            DataSet dataset = conexion.getData("SELECT DESCRIPCION FROM TIPOARTICULO", "TIPOARTICULO");
            DataTable dt = dataset.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                string descripcion = Convert.ToString(row["DESCRIPCION"]).ToUpper();
                if(descripcion.Equals(descripciondada)){
                    resultado = true;
                }
            }
            return resultado;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.escribirSoloEnterosLimitado(e, "STOCK", 3, txtStock, lblStock);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.limitarCaracteres(e, "NOMBRE", 50, txtNombre, lblNombre);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.escribirSoloDoubles(txtPeso, e, "PESO", lblPeso, 2, 2);
        }

    }
}
