using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesTest.Helpers
{
    /// <summary>
    /// Utility class that provides methods for interacting with the user.
    /// </summary>
    public static class UserInteraction
    {
        /// <summary>
        /// Checks whether the user would like to continue. 
        /// </summary>
        /// <returns> returns <see langword="true"/> if the user answers positively; returns <see langword="false"/> otherwise</returns>
        public static bool CheckContinue()
        {
            while (true)
            {
                Console.Write("\nWould you like to try drawing more geometric shapes? (Y/N): ");

                switch (UserInputHelper.ReadKeyInput())
                {
                    case "Y":
                    case "y":
                        return true;
                    case "N":
                    case "n":
                        Environment.Exit(0);
                        return false;
                    default:
                        Console.Write("\nPlease answer with 'Y' or 'N'");
                        break;
                }
            }

        }

        /// <summary>
        /// Prompts the user to enter a value for the height of the geometric shape to be drawn.
        /// </summary>
        /// <returns>returns the <see cref="int"/> that represents the geometric shape's height.</returns>
        public static int GetHeight()
        {
            Console.Write("Enter an integer for the height: ");
            var heightInput = UserInputHelper.ReadNumericInput();
            return heightInput;
        }

        /// <summary>
        /// Prompts the user to enter a value for the width of the geometric shape to be drawn.
        /// </summary>
        /// <returns>returns the <see cref="int"/> that represents the geometric shape's width.</returns>
        public static int GetWidth()
        {
            Console.Write("Enter an integer for the width: ");
            var widthInput = UserInputHelper.ReadNumericInput();
            return widthInput;
        }

        /// <summary>
        /// Prompts the user to enter a value for the number of sides that compose the geometric shape to be drawn.
        /// If a non-valid value is provided, the method displays an error message and the user is prompted to try again.
        /// </summary>
        /// <returns>returns an <see cref="int"/> representing the number of sides of the geometric shape</returns>
        public static int GetNumberOfSides()
        {
            while (true)
            {
                Console.Write("How many sides should your figure have? Enter an integer: ");
                var sides = UserInputHelper.ReadNumericInput();
                if (sides < 3)
                {
                    Console.WriteLine("Your figure must have at least 3 sides! \n");
                }
                else
                {
                    return sides;
                }

            }


        }
    }
}
