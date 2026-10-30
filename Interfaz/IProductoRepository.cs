using PrimerEjercicio.Models;
namespace PrimerEjercicio.Interfaz
{
    public interface IProductoRepository
    {
        // Metodos de la interfaz IProductoRepository 
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}
