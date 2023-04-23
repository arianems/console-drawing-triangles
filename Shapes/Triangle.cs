using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;

namespace TrianglesTest.Shapes
{
    /// <summary>
    /// Subclass of the Shape abstract class. Represents a geometric shape with 3 (in this case, equal) sides.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> subclass, passing on the specified height value
        /// to the constructor of the base class. Ensures that the triangle will be equilateral by assigning the height's value to the width parameter of the base class.
        /// </summary>
        /// <param name="height">The height of the triangle.</param>
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
                    DrawingHelper.WriteFullRow(Height);
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
