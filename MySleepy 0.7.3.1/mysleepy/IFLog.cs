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
    public partial class IFLog : Form
    {
        MetodosComunes mc = new MetodosComunes();
        MetodosConsultasSQL mcs = new MetodosConsultasSQL();
        public IFLog()
        {
            InitializeComponent();
            cargar_Tabla();
            cargarComboLogs();
            cboTipo.SelectedIndex = 3;
        }

        private void cargarComboLogs()
        {
            String[] tipos = { "Actualización", "Creación", "Eliminación", "Seleccione un tipo" };
            cboTipo.DataSource = tipos;
        }

        private void cargar_Tabla()
        {
            try
            {
                dgvLogs.Rows.Clear();


                mc.estilodgv(dgvLogs);
                ConnectDB conexion = new ConnectDB();
                DataSet data = new DataSet();
                data = conexion.getData("SELECT * FROM LOGS ORDER BY IDLOG", "LOGS");

                DataTable tusuarios = data.Tables["LOGS"];

                dgvLogs.Columns.Add("IDLOG", "IDLOG");
                dgvLogs.Columns.Add("IDUSUARIO", "IDUSUARIO");
                dgvLogs.Columns.Add("TIPO", "TIPO");
                dgvLogs.Columns.Add("DESCRIPCION", "DESCRIPCION");
                dgvLogs.Columns.Add("FECHA", "FECHA");

                foreach (DataRow row in tusuarios.Rows)
                {
                    dgvLogs.Rows.Add(row["IDLOG"], row["IDUSUARIO"], row["TIPO"], row["DESCRIPCION"], row["FECHA"]);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }

        }
    }
}
