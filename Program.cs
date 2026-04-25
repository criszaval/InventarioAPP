using System;
using System.Collections.Generic;
using InventarioApp.Factories;
using InventarioApp.Repositories;
using InventarioApp.Models; // 🔥 corregido (APP -> App)
using InventarioApp.Infrastructure;
using InventarioAPP.Infrastructure;

var productos = new List<Producto>
{
    ProductoFactory.Crear(nombre: "Laptop", precio: 1200.00m, cantidad: 3, CategoriaProducto.Electronica),
    ProductoFactory.Crear(nombre: "Camisa", precio: 45.00m, cantidad: 15, CategoriaProducto.Ropa),
    ProductoFactory.Crear(nombre: "Arroz", precio: 12.00m, cantidad: 50, CategoriaProducto.Alimentos),
    ProductoFactory.Crear(nombre: "Lámpara", precio: 35.00m, cantidad: 2, CategoriaProducto.Hogar),
    ProductoFactory.Crear(nombre: "Balón", precio: 25.00m, cantidad: 8, CategoriaProducto.Deportes),
    ProductoFactory.Crear(nombre: "Mesa", precio: 150.00m, cantidad: 4, CategoriaProducto.Muebles)
};

var generador = new GeneradorReportes(productos);

Console.WriteLine(generador.GenerarResumen());
Console.WriteLine("\n");

Console.WriteLine(generador.GenerarReporteStockBajo());
Console.WriteLine("\n");

Console.WriteLine(generador.GenerarTopProductos());
Console.WriteLine("\n");

Console.WriteLine(generador.ExportarCsv());
Console.WriteLine("\n");

Console.WriteLine(generador.ExportarResumenJson());

/*Console.WriteLine("==PRUEBA INTEGRACION JSON==");

var almacenamiento = new JsonInventarioStorage ();

var productos = new List<Producto>()
{
    new Producto
    {
        Id = 1,
        Nombre = "Laptop",
        Precio = 999.99m,
        Cantidad = 10,
        Categoria = CategoriaProducto.Electronica,
        Estado = EstadoProducto.Activo
    },

    new Producto
    {
        Id = 2,
        Nombre = "Mouse",
        Precio = 25.50m,
        Cantidad = 50,
        Categoria = CategoriaProducto.Electronica,
        Estado = EstadoProducto.Activo
    }
};

string ruta = "inventario_test.json";
almacenamiento.CrearBackup(ruta);
almacenamiento.Guardar(productos,ruta);

Console.WriteLine("Inventario guardado correctamente");

var productosCargados = almacenamiento.Cargar(ruta);

Console.WriteLine("Inventario cargado correctamente");

foreach (var p in productosCargados)
{
   Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}, Cantidad: {p.Cantidad}, Categoria: {p.Categoria}, Estado: {p.Estado}");
    
}/*
























/*

var fileManager = new FileManager();
string contenido = "Inventario Actualizado";
fileManager.Escribir(ruta:"Inventario.txt",contenido);

string leerContenido = fileManager.Leer(ruta: "Inventario.txt");
Console.WriteLine(contenido);





var repositorio = new  InMemoryProductoRepository();

var laptop = ProductoFactory.Crear("Laptop Dell XPS 13", 1200, 5, CategoriaProducto.Electronica);
var mouse = ProductoFactory.Crear("Mouse Logitech MX Master", 99, 20, CategoriaProducto.Electronica);
var teclado = ProductoFactory.Crear("Teclado Mecánico", 150, 3, CategoriaProducto.Electronica);
var silla = ProductoFactory.Crear("Silla Ergonómica Herman Miller", 500, 8, CategoriaProducto.Muebles);
var escritorio = ProductoFactory.Crear("Escritorio Stand-up", 300, 2, CategoriaProducto.Muebles);


repositorio.Agregar(laptop);
repositorio.Agregar(mouse);
repositorio.Agregar(teclado);
repositorio.Agregar(silla);
repositorio.Agregar(escritorio);


Console.WriteLine($"Productos agregado: {repositorio.Cantidad}\n");



//CONSULTAS BASICAS LINQ


var electronicos= repositorio.BuscarPorCategoria(CategoriaProducto.Electronica);

Console.WriteLine("Productos de Electronica: ");

foreach (var producto in electronicos)
{
    Console.WriteLine($"{producto.Nombre} : ${producto.Precio}");

    


}

var conMouse = repositorio.BuscarPorNombre("mouse");


Console.WriteLine($"\nProductos con 'mouse' en el nombre");

foreach (var producto in conMouse)
{
    Console.WriteLine($"{producto.Nombre}");


}

var nombres  = repositorio.ObtenerNombres();

Console.WriteLine($"\nTodos los nombres {string.Join(",", nombres)}");


var hayStockBajo = repositorio.HayStockBajo();

Console.WriteLine($"\nhay stock bajo: {hayStockBajo}");

*/
