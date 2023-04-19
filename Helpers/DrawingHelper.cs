using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianglesTest.Helpers.Interfaces;

namespace TrianglesTest.Helpers
{
    /// <summary>
    /// Utility class that provides methods for composing rows and columns. 
    /// </summary>
    public class DrawingHelper : IDrawingHelper
    {
        public static void WriteBlankColumns(int blankColumns)
        {
            for (int i = blankColumns; i > 0; i--)
            {
                Console.Write(" ");
            }
        }

        public static void WriteFullRow(int rowWidth)
        {
            for (int i = rowWidth; i > 0; i--)
            {
                Console.Write("*");
                if (rowWidth > 1)
                {
                    Console.Write(" ");
                }

            }

        }

        public static void WriteBorderedBlankRow(int blankColumns)
        {

            Console.Write("*");
            WriteBlankColumns(blankColumns);
            Console.WriteLine("*");

        }

        void IDrawingHelper.WriteBorderedBlankRow(int rowWidth)
        {
            WriteBorderedBlankRow(rowWidth);
        }

        void IDrawingHelper.WriteBlankColumns(int blankColumns)
        {
            WriteBlankColumns(blankColumns);
        }

        void IDrawingHelper.WriteFullRow(int rowWidth)
        {
            WriteFullRow(rowWidth);
        }
    }
}
