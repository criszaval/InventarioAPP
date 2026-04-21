// ============================================
// Estado: Mensaje de bienvenida
// ============================================

int cantidadProductos = 0;
decimal valorTotalDelInventario = 0.00m;
bool sistemaActivo = true;
string nombreSistema = "Sistema de Gestion de Inventario";

MostrarBanner();
bool continuar = true;

while (continuar)
{
    MostrarMenu();
    string comando = LeerEntrada("Inventario");
    Console.WriteLine($"Comando ingresado: {comando}");
    
    continuar = ProcesarComando(comando);
}

// ============================================
// METODOS
// ============================================

bool ProcesarComando(string comando)
{
    switch (comando)
    {
        case "1":
            ListarProductos();
            return true;
        case "2":
            AgregarProductos();
            return true;
        case "3":
            BuscarProductos();
            return true;
        case "4":
            Console.WriteLine("Saliendo del sistema...");
            return false;
        default:
            Console.WriteLine($"Comando '{comando}' no válido");
            return true;
    }
}

void ListarProductos()
{
    Console.WriteLine("Mostrando Productos...");
    Console.WriteLine($"Total: {cantidadProductos} productos en el inventario");
    Console.WriteLine($"Valor: {valorTotalDelInventario}");
}

void AgregarProductos()
{
    Console.WriteLine("Agregar Producto (Modulo 3)");
     // ejemplo simple
}

void BuscarProductos()
{
    Console.WriteLine("Buscar Producto (Modulo 4)");
}

string LeerEntrada(string prompt)
{
    Console.Write($"{prompt}> ");
    return Console.ReadLine() ?? "";
}

// ============================================
// FUNCIONES
// ============================================

void MostrarBanner()
{
    Console.WriteLine("==============================================");
    Console.WriteLine("     SISTEMA DE GESTIÓN DE INVENTARIO        ");
    Console.WriteLine("==============================================");
    Console.WriteLine();
}

void MostrarMenu()
{
    Console.WriteLine("\nMENU PRINCIPAL");
    Console.WriteLine("1. Listar - Ver Productos");
    Console.WriteLine("2. Agregar - Añadir Productos");
    Console.WriteLine("3. Buscar - Buscar Productos");
    Console.WriteLine("4. Salir - Terminar");
}