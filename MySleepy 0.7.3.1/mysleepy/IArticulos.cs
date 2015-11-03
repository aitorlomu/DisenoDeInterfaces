using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySleepy
{
    public interface IArticulos
    {
        void changeArticulo(string id, string nombre, string stock, string precio);
    }
}
