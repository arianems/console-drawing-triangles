using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesTest.Helpers
{
    /// <summary>
    /// Provides methods to validate user input.
    /// </summary>
    public static class UserInputHelper
    {
        /// <summary>
        /// Takes in user input and ensure that it is a valid integer value. 
        /// If the user tries entering an input that cannot be parsed to <see cref="int"/>, 
        /// an error message is displayed and they are prompted to try again.
        /// </summary>
        /// <returns>returns the validated <see cref="int"/> value</returns>
        public static int ReadNumericInput()
        {
            int input;

            while(true)
            {
                if(!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Invalid input. Try again: ");
                }
                else
                {
                    return input;
                }
            }
            
        }

        /// <summary>
        /// Takes in user input and ensure that it is a valid string value. 
        /// If the user tries entering an input that cannot be parsed to <see cref="int"/>, 
        /// an error message is displayed and they are prompted to try again.
        /// </summary>
        /// <returns>returns the validated <see cref="int"/> value</returns>
        public static string ReadKeyInput()
        {
            var input = Console.ReadKey().Key.ToString();

            while (int.TryParse(input, out int num) || input is null)
            {
                Console.Write("Invalid input. Try again: ");
                ReadKeyInput();               
            }

            return input.ToUpper();
        }
    }
}
