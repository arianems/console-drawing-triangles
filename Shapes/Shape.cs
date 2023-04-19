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
    /// Base class for geometric shapes.
    /// </summary>
    public abstract class Shape
    {
        public int Height { get; protected set; }
        public int Width { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the Shape abstract class with the specified width and height values.
        /// </summary>
        /// <param name="width">The width of the geometric shape.</param>
        /// <param name="height">The height of the geometric shape.</param>
        protected Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Takes an <see cref="IDrawingHelper"/> object as an argument and draws the corresponding geometric shape using the required measurements.
        /// </summary>
        /// <param name="drawingHelper">The drawing helper to be used.</param>
        public abstract void Draw(IDrawingHelper drawingHelper);

    }
}
