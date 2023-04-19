using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;

namespace TrianglesTest.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int height) : base(height, height)
        {

        }

        public override void Draw(IDrawingHelper drawingHelper)
        {
            var outerBlankColumns = Height - 1;
            var innerBlankColumns = 1;

            for (int row = 1; row <= Height; row++)
            {
                if (row == 1)
                {
                    drawingHelper.WriteBlankColumns(outerBlankColumns);
                    Console.WriteLine("*");
                }
                else if (row == Height)
                {
                    var lastRowColumns = 0;
                    while (lastRowColumns < row)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                        lastRowColumns++;
                    }

                    Console.WriteLine("\n");

                }
                else
                {
                    outerBlankColumns--;
                    drawingHelper.WriteBlankColumns(outerBlankColumns);
                    drawingHelper.WriteBorderedBlankRow(innerBlankColumns);
                    innerBlankColumns += 2;

                }
            }
        }
    }
}
