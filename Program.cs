
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
        Console.WriteLine("Configuracion .csproj");
        Console.WriteLine("Carpeta srs creada");
        Console.WriteLine("Metadatos Configurados");
        Console.WriteLine();
        Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en github");


