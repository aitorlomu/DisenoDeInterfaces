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
    public partial class ArticulosGUI : Form
    {
        MetodosComunes funciones;
        MetodosConsultasSQL consultas;
        ArticuloNuevoGUI frmnuevo = new ArticuloNuevoGUI();

        public ArticulosGUI()
        {
            InitializeComponent();
            funciones = new MetodosComunes();
            consultas = new MetodosConsultasSQL();
            actualizarTabla();
            cargarComboOperaciones();
            cargarCboTipo();
        }
        public string actualizarTabla()
        {
            string sql = "";
            sql = "SELECT IDARTICULO,NOMBRE,STOCK,PRECIO,PESO,DESCRIPCION AS TIPO FROM ARTICULOS A,TIPOARTICULO T " +
                   " WHERE A.TIPO = T.IDTIPO ";
            if(chkEliminados.Checked){
                sql = sql + " AND A.ELIMINADO = 1";
            }
            else
            {
                sql = sql + " AND A.ELIMINADO =0";
            }
            if (txtNombre.Text.Length > 0)
            {
                sql = sql + " and upper(NOMBRE) like '%" + txtNombre.Text.ToUpper() + "%'";
            }
            if(txtPeso.Text.Length > 0){
                sql = sql + " and upper(PESO) like '%" + txtPeso.Text.ToUpper() + "%'";
            }

            if(txtPrecio.Text.Length>0){
                switch (cboOperacion.SelectedIndex)
                {
                    case 0:
                        sql = sql + " and PRECIO<" + txtPrecio.Text;
                        break;
                    case 1:
                        sql = sql + " and PRECIO=" + txtPrecio.Text;
                        break;
                    case 2:
                        sql = sql + " and PRECIO>" + txtPrecio.Text;
                        break;
                }
                
               
            }
            if(cboTipo.SelectedIndex!=0){
                switch (cboTipo.SelectedIndex)
                {
                    case 1:
                        // Armas
                        sql = sql + " and descripcion = 'Armas'";
                        break;
                    case 2:
                        // Camisetas
                        sql = sql + " and descripcion = 'Camisetas'";
                        break;
                    case 3:
                        // Torretas
                        sql = sql + " and descripcion = 'Torretas'";
                        break;
                    case 4:
                        // Cajas
                        sql = sql + " and descripcion = 'Cajas'";
                        break;
                }
            }

            sql = sql + " ORDER BY A.NOMBRE";
            funciones.rellenaDGV(dgvArticulos, sql);
            funciones.estilodgv(dgvArticulos);

            return sql;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminaroRestaurarArtic();
        }
        public void eliminaroRestaurarArtic()
        {
            String accion;
            int eliminado;
            Boolean eliminarRestaurar = true;
            String estado;
            if(chkEliminados.Checked){
                accion = "Restaurar";
                eliminado = 0;
                estado = "Restaurado";
            }
            else
            {
                accion = "Eliminar";
                eliminado = 1;
                estado = "Eliminado";
            }
            String id;
            try
            {
                id = dgvArticulos.SelectedCells[0].Value.ToString();

                if (eliminarRestaurar)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea " + accion + " el registro?", accion, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        consultas.eliminarDato("IDARTICULO", id, "ARTICULOS", eliminado);
                        MessageBox.Show("Registro " + estado);
                        actualizarTabla();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Debes seleccionar un artículo");
            }

            
        }
       

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            frmnuevo.ShowDialog();
            actualizarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkEliminados_Click(object sender, EventArgs e)
        {
            if (chkEliminados.Checked)
            {
                btnEliminar.Text = "Restaurar";
            }else{
                btnEliminar.Text = "Eliminar";
            }
        }

        private void chkEliminados_CheckStateChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = Convert.ToInt32(dgvArticulos.SelectedCells[0].Value.ToString());
                 ArticuloNuevoGUI hijo = new ArticuloNuevoGUI();
                hijo.asignaPadre(this);
                hijo.rellenaDatos(id);
                hijo.ShowDialog();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes seleccionar un artículo");
            }
            
            
           
        }

        private void ArticulosGUI_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void cargarComboOperaciones()
        {
            String[] operaciones = { "<","=",">"};
            cboOperacion.DataSource = operaciones;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtPeso.Text = "";
            cboTipo.SelectedIndex = 0;
            actualizarTabla();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cargarCboTipo(){
            String sql = "SELECT IDTIPO,DESCRIPCION FROM TIPOARTICULO WHERE ELIMINADO = 0";
            funciones.rellenacombobox(cboTipo,sql,"-- Seleccione Tipo --");
        }

        private void cboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void txtPeso_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void btnAddArt_Click(object sender, EventArgs e)
        {
            String id = dgvArticulos.SelectedCells[0].Value.ToString();
            String nombre = dgvArticulos.SelectedCells[1].Value.ToString();
            String stock = dgvArticulos.SelectedCells[2].Value.ToString();
            String precio = dgvArticulos.SelectedCells[3].Value.ToString();


            IArticulos artInterface = this.Owner as IArticulos;

            if (artInterface != null)
            {

                artInterface.changeArticulo(id, nombre, stock, precio);
                this.Close();
            }
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dgvArticulos.SelectedCells[0].Value.ToString();
            String nombre = dgvArticulos.SelectedCells[1].Value.ToString();
            String stock = dgvArticulos.SelectedCells[2].Value.ToString();
            String precio = dgvArticulos.SelectedCells[3].Value.ToString();


            IArticulos artInterface = this.Owner as IArticulos;

            if (artInterface != null)
            {

                artInterface.changeArticulo(id, nombre, stock, precio);
                this.Close();
            }
        }



    }
}
