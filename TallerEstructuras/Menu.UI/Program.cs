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
            int size;
            do
            {
                Console.Write("\nEnter array order (odd number): ");
                size = Convert.ToInt32(Console.ReadLine());
            } while (size % 2 == 0);
            var reloj = new Relojito(size);
            Console.Write(reloj);
            Console.WriteLine(reloj.Reloj());
            break;
        case 3:
            Console.Write("\nEnter the number to decompose: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factores = new Factores();
            Console.WriteLine(factores.ResultDecomposition(number));
            break;
        case 4:
            Console.Write("\nEnter location of the fruits: ");
            var locations = Console.ReadLine();
            Console.Write("Enter horse starting position: ");
            var positionHourse = Console.ReadLine();
            Console.Write("Enter the horse's movements: ");
            var indications = Console.ReadLine();
            var cosecha = new Cosecha(locations, positionHourse, indications);
            try
            {
                Console.WriteLine($"\nThe collected fruits are: {cosecha.ResultHarverst()}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n");
            }
            break;
        case 5:
            Console.Write("\nEnter location of horses: ");
            var hourses = Console.ReadLine();
            var conflictHorse = new Conflicto(hourses);
            Console.WriteLine(conflictHorse.ConflictHourse());
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Option is not valid.\n");
            break;
    }
} while (menu != 0);
