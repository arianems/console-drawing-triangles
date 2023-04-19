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
    /// Subclass of the Shape abstract class. Represents a geometric shape with 4 sides and 4 right angles.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Rectangle subclass, passing on the specified width and height values
        /// to the constructor of the base class.
        /// </summary>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public Rectangle(int width, int height) : base(width, height)
        {
            
        }

        public override void Draw(IDrawingHelper drawingHelper)
        {
            drawingHelper.WriteFullRow(Width);
            Console.Write("\n");

            for (int rowsCounter = 2; rowsCounter < Height; rowsCounter++)
            {
                drawingHelper.WriteFullRow(1);
                drawingHelper.WriteBlankColumns((Width * 2 - 1) - 2);
                drawingHelper.WriteFullRow(1);
                Console.Write("\n");
            }

            drawingHelper.WriteFullRow(Width);
            Console.WriteLine("\n");
        }


    }
}
