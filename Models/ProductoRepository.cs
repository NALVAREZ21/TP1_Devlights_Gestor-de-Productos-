using PrimerEjercicio.Interfaz;

namespace PrimerEjercicio.Models
{
    public class ProductoRepository : IProductoRepository
    {
        private List<Producto> ListaProducto;

        #region Constructor
        public ProductoRepository()
        {
            ListaProducto = new List<Producto>();

            for(int i = 0; i<3;i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine()!;

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine()!);

                Console.Write("Categoria: ");
                string categoria = Console.ReadLine()!;

                Console.Write("Activo / Inactivo: ");
                bool activo = bool.Parse(Console.ReadLine()!);

                ListaProducto.Add(new Producto
                {
                    Id = id,
                    Nombre = nombre,
                    Precio = precio,
                    Categoria = categoria,
                    Activo = activo,
                
                });
                int cantidad = ListaProducto.Count();
                Console.WriteLine("Cantidad de elementos de la lista: " + cantidad);
            }
        }
        #endregion

        #region Metodos
        public void Agregar(Producto producto)
        {
            ListaProducto.Add(producto);
        }
        public List<Producto> ObtenerTodos()
        {
            return ListaProducto;
        }
        public Producto ObtenerPorId(int id)
        {
            return ListaProducto.FirstOrDefault(valor => valor.Id == id);
        }
        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return ListaProducto.Where(f => f.Categoria == categoria).ToList();
        }
        #endregion
    }
}
