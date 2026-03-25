using System;

int totalEvaluados = 0;
int totalPublicados = 0;
int totalRechazados = 0;
int totalEnRevision = 0;
int totalPublicadosConAjustes = 0;
int impactoAltoCount = 0;
int impactoMedioCount = 0;
int impactoBajoCount = 0;

Main(args);

void Main(string[] args)
{
    Console.Title = "Simulador de Decisiones - Plataforma de Streaming";
    MostrarBienvenida();

    int opcion;
    do
    {
        MostrarMenu();
        opcion = LeerEnteroValido("Seleccione una opción (1-5): ", 1, 5);

        switch (opcion)
        {
            case 1:
                EvaluarContenido();
                break;
            case 2:
                MostrarReglas();
                break;
            case 3:
                MostrarEstadisticas();
                break;
            case 4:
                ReiniciarEstadisticas();
                break;
            case 5:
                MostrarResumenFinal();
                break;
        }

    } while (opcion != 5);
}

void MostrarBienvenida()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("╔══════════════════════════════════════════════════════╗");
    Console.WriteLine("║   SIMULADOR DE DECISIONES - PLATAFORMA DE STREAMING  ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════╝");
    Console.ResetColor();
    Console.WriteLine();
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("═══════════════ MENÚ PRINCIPAL ═══════════════");
    Console.ResetColor();
    Console.WriteLine("  1. Evaluar nuevo contenido");
    Console.WriteLine("  2. Mostrar reglas del sistema");
    Console.WriteLine("  3. Mostrar estadísticas de la sesión");
    Console.WriteLine("  4. Reiniciar estadísticas");
    Console.WriteLine("  5. Salir");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("═══════════════════════════════════════════════");
    Console.ResetColor();
}

void EvaluarContenido()
{

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n══════════ EVALUACIÓN DE CONTENIDO ══════════");
    Console.ResetColor();

    Console.WriteLine("\nTipos de contenido disponibles:");
    Console.WriteLine("  1. Película");
    Console.WriteLine("  2. Serie");
    Console.WriteLine("  3. Documental");
    Console.WriteLine("  4. Evento en vivo");
    int tipoNum = LeerEnteroValido("Seleccione el tipo (1-4): ", 1, 4);

    string tipo = "";
    if (tipoNum == 1) tipo = "pelicula";
    else if (tipoNum == 2) tipo = "serie";
    else if (tipoNum == 3) tipo = "documental";
    else tipo = "evento";

    int duracion = LeerEnteroValido("Duración en minutos: ", 1, 999);

    Console.WriteLine("\nClasificación:");
    Console.WriteLine("  1. Todo público");
    Console.WriteLine("  2. +13");
    Console.WriteLine("  3. +18");
    int claseNum = LeerEnteroValido("Seleccione clasificación (1-3): ", 1, 3);

    string clasificacion = "";
    if (claseNum == 1) clasificacion = "todo publico";
    else if (claseNum == 2) clasificacion = "+13";
    else clasificacion = "+18";

    int hora = LeerEnteroValido("Hora programada (0-23): ", 0, 23);

    Console.WriteLine("\nNivel de producción:");
    Console.WriteLine("  1. Bajo");
    Console.WriteLine("  2. Medio");
    Console.WriteLine("  3. Alto");
    int prodNum = LeerEnteroValido("Seleccione nivel (1-3): ", 1, 3);

    string produccion = "";
    if (prodNum == 1) produccion = "bajo";
    else if (prodNum == 2) produccion = "medio";
    else produccion = "alto";

    ProcesarEvaluacion(tipo, duracion, clasificacion, hora, produccion);
}

