
// ============================================
// Estado: Mensaje de bienvenida
// ============================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

        Console.WriteLine("==============================================");
        Console.WriteLine("     SISTEMA DE GESTIÓN DE INVENTARIO        ");
        Console.WriteLine("==============================================");
        Console.WriteLine();
        Console.WriteLine($"Version:{version}");
        Console.WriteLine($"Plataforma: {Environment.OSVersion}");
        Console.WriteLine($".NET Version: {Environment.Version}");
        Console.WriteLine();
        Console.WriteLine("Estructura del Proyecto");
        Console.WriteLine("progam.cs");
        Console.WriteLine("InventarioAPP.csproj");
        Console.WriteLine("gitignore");
        Console.WriteLine("README.md");
        Console.WriteLine("src");
        Console.WriteLine("Models");
        Console.WriteLine("Configuracion .csproj");
        Console.WriteLine("Carpeta srs creada");
        Console.WriteLine("Metadatos Configurados");
        Console.WriteLine();
        Console.WriteLine("proximo paso: checkpoint");


