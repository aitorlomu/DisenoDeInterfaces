using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySleepy
{
    public interface INuevoPedido
    {
        void ChangeClientes(string text);
        void cargarArticuloNuevo(string idArticulo, string nombre, string cantidad, string precio, string precioTotal);
    }
}
