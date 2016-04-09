using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoGIT.Models
{
    public class Producto
    {
        public int codigoproducto { get; set; }
        public string nombreproducto { get; set; }
        public string descripcion { get; set; }
        public decimal precioproducto { get; set; }
    }
}