using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesTest.Helpers
{
    public static class UserInputHelper
    {
        public static int ReadNumericInput()
        {
            int input;

            while(true)
            {
                if(!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
                else
                {
                    return input;
                }
            }
            
        }

        public static string ReadKeyInput()
        {
            var input = Console.ReadKey().Key.ToString();

            while (int.TryParse(input, out int num) || input is null)
            {
                Console.WriteLine("Invalid input. Try again.");
                ReadKeyInput();               
            }

            return input.ToUpper();
        }
    }
}
