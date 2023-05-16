using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.UI
{
    public static class GetMenu
    {
        public static int Menu()
        {
            bool isValid = false;
            int menu;
            do
            {
                var validate = Console.ReadLine();
                if (!int.TryParse(validate, out menu))
                {
                    Console.WriteLine("\nOption is not valid.");
                    Console.Write("Try again: ");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return menu;
        }
    }
}
