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
    public partial class EscritorioGUI : Form
    {

        PedidosGUI pedidos;
        IFUsuariosGUI usuarios;
        IFClientesGUI clientes;
        ArticulosGUI articulos;
        IFLog log;
        ProveedoresGUI proveedores;
        static int rol;
        static int id;
        public EscritorioGUI(int rolpasado,int idpasado)
        {
            id = idpasado;
            rol = rolpasado;
            InitializeComponent();
            if (rolpasado == 2)
            {
                artículosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                logToolStripMenuItem.Enabled = false;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedidos != null) pedidos.Close();
            if (usuarios != null) usuarios.Close();
            if (clientes != null) clientes.Close();
            if (log != null) log.Close();
            if (proveedores != null) proveedores.Close();

            clientes = new IFClientesGUI(id);
            clientes.MdiParent = this;
            clientes.Dock = DockStyle.Fill;
            clientes.WindowState = FormWindowState.Maximized;
            clientes.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedidos != null) pedidos.Close();
            if (usuarios != null) usuarios.Close();
            if (clientes != null) clientes.Close();
            if (log != null) log.Close();
            if (proveedores != null) proveedores.Close();

            usuarios = new IFUsuariosGUI(id,rol);
            usuarios.MdiParent = this;
            usuarios.Dock = DockStyle.Fill;
            usuarios.WindowState = FormWindowState.Maximized;
            usuarios.Show();

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedidos != null) pedidos.Close();
            if (usuarios != null) usuarios.Close();
            if (clientes != null) clientes.Close();
            if (log != null) log.Close();
            if (proveedores != null) proveedores.Close();

            pedidos = new PedidosGUI(id);
            pedidos.MdiParent = this;
            pedidos.Dock = DockStyle.Fill;
            pedidos.WindowState = FormWindowState.Maximized;
            pedidos.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedidos != null) pedidos.Close();
            if (usuarios != null) usuarios.Close();
            if (clientes != null) clientes.Close();
            if (log != null) log.Close();
            if (proveedores != null) proveedores.Close();

            articulos = new ArticulosGUI();
            articulos.MdiParent = this;
            articulos.Dock = DockStyle.Fill;
            articulos.WindowState = FormWindowState.Maximized;
            articulos.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedidos != null) pedidos.Close();
            if (usuarios != null) usuarios.Close();
            if (clientes != null) clientes.Close();
            if (log != null) log.Close();
            if (proveedores != null) proveedores.Close();

            log = new IFLog();
            log.MdiParent = this;
            log.Dock = DockStyle.Fill;
            log.WindowState = FormWindowState.Maximized;
            log.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedidos != null) pedidos.Close();
            if (usuarios != null) usuarios.Close();
            if (clientes != null) clientes.Close();
            if (log != null) log.Close();
            if (proveedores != null) proveedores.Close();

            proveedores = new ProveedoresGUI();
            proveedores.MdiParent = this;
            proveedores.Dock = DockStyle.Fill;
            proveedores.WindowState = FormWindowState.Maximized;
            proveedores.Show();
        }

    }
}
