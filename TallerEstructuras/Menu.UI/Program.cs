using ConflictoCaballos.Logic;
using CosechandoCaballo;
using DescomposicionFactores;
using Menu.UI;
using MultiplicacionMatrices.Logic;
using RelojArena;

int menu;

do
{
    Console.WriteLine(
        "Taller Estructuras.\n" +
            "   - Option 1: Multiplicación de matrices.\n" +
                "   - Option 2: Reloj de arena.\n" +
                    "   - Option 3: Descomposición en factores.\n" +
                        "   - Option 4: Cosechando caballo.\n" +
                            "   - Option 5: Caballos en conflicto.\n" +
                                "   - Option 0: Salir.");
    Console.Write("Type your option: ");
    menu = GetMenu.Menu();

    switch (menu)
    {
        case 1:
            Console.Write("\nEnter the value of M: ");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of N: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of P: ");
            var p = Convert.ToInt32(Console.ReadLine());
            var matrix = new MultiplicarMatrices(m, n, p);
            Console.WriteLine(matrix.Process());
            break;
        case 2:
            var reloj = new Relojito();
            break;
        case 3:
            var factores = new Factores();
            break;
        case 4:
            var cosecha = new Cosecha();
            break;
        case 5:
            var conflicto = new Conflicto();
            break;
        case 0:
            break;
        default:
            Console.WriteLine("\nOption is not valid.");
            break;
    }
} while (menu != 0);
