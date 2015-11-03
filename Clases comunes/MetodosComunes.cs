using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.DataAccess.Client;
using System.Drawing;

namespace MINIERPC
{
    class MetodosComunes
    {

         //Metodo para rellenar combobox con una consulta de dos valores, el primero oculto y el segundo visible
    //
    //combo -> Combobox a rellenar
    //consulta -> Consulta SQL para obtener los valores
    //inicio -> Primer elemento del combo (Seleccione ...). Si no se desea inicio introducir ""
    //
    //
    //Metodos para extraer los elementos del combobox
    //
    //Elem oculto = cboCombo.SelectedValue()
    //Nombre de la columna visible = cboCombo.DisplayMember() 
    //Posicion del seleccionado = cboCombo.SelectedIndex)
    //
        public void rellenacombobox(ComboBox combo, String consulta,String inicio)
        {
            DataSet Data = new DataSet();
            ConnectDB Search = new ConnectDB();

            Data = Search.getData(consulta, "tabla");
            DataTable ttablas = Data.Tables["tabla"];
            if (!inicio.Equals(""))
            {
                DataRow newrow2 = ttablas.NewRow();
                newrow2[0] = -1;
                newrow2[1] = inicio;
                ttablas.Rows.InsertAt(newrow2, 0);
            }
            combo.DataSource = ttablas;
                combo.DisplayMember = ttablas.Columns[1].ToString();
                combo.ValueMember = ttablas.Columns[0].ToString();
        }

        // Método para rellenar tabla con una consulta
        // El primer elemento de la consulta se mantendrá oculto(ID)
        // 
        // tabla -> DataGridView a rellenar
        // consulta -> Consulta SQL para obtener los valores
        //
        // Métodos para extraer datos
        //
        // Celda seleccionada = dgv.currentCell
        // Fila Seleccionadda = dgv.CurrentRow
        // Seleccionar Celda index (0-n) dentro de la fila seleccionada = dgv..CurrentRow.Cells.IndexOf(posicion)
        //

        public void rellenaDGV(DataGridView tabla, String consulta)
        {
            DataSet Data = new DataSet();
            ConnectDB Search = new ConnectDB();

            Data = Search.getData(consulta, "tabla");
            DataTable ttablas = Data.Tables["tabla"];

            tabla.DataSource = ttablas;
            tabla.Columns[0].Visible = false; // Se oculta la primera columna

        }

        public void estilodgv(DataGridView dgv)
        {
            dgv.ReadOnly = true; // Celdas de sólo lectura
            dgv.AllowUserToAddRows = false; // Para que no se muestre la última fila
            dgv.ColumnHeadersVisible = true; // Para que no se muestre el título de la columna
            dgv.RowHeadersVisible = true; // Para que no se muestre la columna vacía de cada fila

            var _with1 = dgv.ColumnHeadersDefaultCellStyle;
            // formato por defecto de las cabeceras de columna
            _with1.Font = new Font("Tahoma", 8, FontStyle.Bold);
            _with1.ForeColor = Color.Black;
            _with1.BackColor = Color.Beige;
            _with1.SelectionForeColor = Color.Yellow;
            _with1.SelectionBackColor = Color.Blue;

            dgv.RowTemplate.Height = 100;
            //altura de las filas
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //modos de seleccion muy importante FullRowSelect//Cellselect
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // para ajustarse el tamaño de las columnas a las dimensiones del datagridview
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // para ajustar el tamaño de las filas a las dimensiones del datagridview
            dgv.AllowUserToResizeColumns = false;
            // no permitir redimensionar columnas
            dgv.AllowUserToResizeRows = false;
            // no permitir redimensionar filas

            var _with2 = (dgv);
            //para alternar dos colores entre las filas del datagridview
            _with2.RowsDefaultCellStyle.BackColor = Color.Linen;
            _with2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            var _with3 = dgv.DefaultCellStyle;
            // formato por defecto del datagridview
            _with3.Font = new Font("Tahoma", 8);
            _with3.ForeColor = Color.Black;
            _with3.BackColor = Color.Beige;
            _with3.SelectionForeColor = Color.Yellow;
            _with3.SelectionBackColor = Color.Silver;

            dgv.MultiSelect = false;
            //Para que solo se pueda seleccionar una fila
            dgv.ScrollBars = ScrollBars.Both;
        }
    }
}
