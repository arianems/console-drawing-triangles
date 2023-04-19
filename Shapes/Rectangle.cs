using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;

namespace TrianglesTest.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {
            
        }

        public override void Draw(IDrawingHelper _drawingHelper)
        {
            DrawingHelper.WriteFullRow(Width);
            Console.Write("\n");

            for (int rowsCounter = 2; rowsCounter < Height; rowsCounter++)
            {
                DrawingHelper.WriteFullRow(1);
                DrawingHelper.WriteBlankColumns((Width * 2 - 1) - 2);
                DrawingHelper.WriteFullRow(1);
                Console.Write("\n");
            }

            DrawingHelper.WriteFullRow(Width);
            Console.WriteLine("\n");
        }


    }
}
