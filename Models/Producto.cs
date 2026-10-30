using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerEjercicio.Models
{
    public class Producto
    {
        // Uso de propiedades autoimplementadas
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public decimal Precio { get; set; }
        public string ? Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
