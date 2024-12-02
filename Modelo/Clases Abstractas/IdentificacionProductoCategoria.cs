using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class IdentificacionProductoCategoria
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
