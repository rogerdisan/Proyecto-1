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

