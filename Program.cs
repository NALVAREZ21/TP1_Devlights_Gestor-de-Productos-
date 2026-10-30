using PrimerEjercicio.Models;

// Instanciacion de la clase ProductoRepository

// Impresión de la lista completa
var repo = new ProductoRepository();

foreach (var i in repo.ObtenerTodos())
{
    Console.WriteLine("Id : " + i.Id);
    Console.WriteLine("Nombre : " + i.Nombre);
    Console.WriteLine("Precio : " + i.Precio);
    Console.WriteLine("Categoria : " + i.Categoria);
    Console.WriteLine("Estado: " + i.Activo);
}

// Esto es una variable del tipo producto
Producto productoAbuscar;

// búsqueda de un producto por ID

Console.Write("Ingrese el Id del producto a buscar: ");
int valor = int.Parse(Console.ReadLine()!);

productoAbuscar = repo.ObtenerPorId(valor);

var respuesta = (productoAbuscar != null) ? $"Se encontro al articulo {productoAbuscar.Nombre}" : $"No se encontro al articulo {productoAbuscar?.Nombre}";
Console.WriteLine(respuesta);

// Filtro de productos por categoría.
Console.Write("Ingrese el nombre de la categoria: ");
string categoriaAbuscar = Console.ReadLine()!;

List<Producto> productosFiltrados = repo.BuscarPorCategoria(categoriaAbuscar);

foreach (var produ in productosFiltrados)
{
    Console.WriteLine($"El producto encontrado por la categoria {categoriaAbuscar} fue {produ.Nombre} que sale ${produ.Precio}");
}
Console.ReadKey();

// Alta de un nuevo articulo

Producto nuevo_articulo = new Producto
{
    Id = 4,
    Nombre = "Yerba Playadito",
    Precio = 2000,
    Categoria = "Yerba mate con palo",
    Activo = false,
};
repo.Agregar(nuevo_articulo);
Console.WriteLine("Nuevo articulo registrado");
Console.Clear();

Console.WriteLine("--DATOS DE TODOS LOS ARTICULOS--");

foreach (var i in repo.ObtenerTodos())
{
    Console.WriteLine("Id : " + i.Id);
    Console.WriteLine("Nombre : " + i.Nombre);
    Console.WriteLine("Precio : " + i.Precio);
    Console.WriteLine("Categoria : " + i.Categoria);
    Console.WriteLine("Estado: " + i.Activo);
}