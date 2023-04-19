using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesTest.Helpers
{
    public static class UserInteraction
    {
        public static bool CheckContinue()
        {
            while (true)
            {
                Console.Write("Would you like to try drawing more geometric shapes? (Y/N): ");

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
                        Console.WriteLine("\nPlease answer with 'Y' or 'N'c");
                        break;
                }
            }

        }


        public static int GetHeight()
        {
            Console.Write("Enter a height: ");
            var heightInput = UserInputHelper.ReadNumericInput();
            return heightInput;
        }

        public static int GetWidth()
        {
            Console.Write("Enter a width: ");
            var widthInput = UserInputHelper.ReadNumericInput();
            return widthInput;
        }

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
