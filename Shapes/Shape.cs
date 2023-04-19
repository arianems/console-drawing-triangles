using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;

namespace TrianglesTest.Shapes
{
    public abstract class Shape
    {
        public int Height { get; protected set; }
        public int Width { get; protected set; }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Draws the corresponding shape using the given height and width values 
        /// </summary>
        public abstract void Draw(IDrawingHelper drawingHelper);

    }
}
