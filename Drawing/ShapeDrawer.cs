using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianglesTest.Helpers.Interfaces;
using TrianglesTest.Helpers;
using TrianglesTest.Shapes;

namespace TrianglesTest.Drawing
{
    /// <summary>
    /// Provides methods for drawing geometric shapes. 
    /// </summary>
    public class ShapeDrawer
    {
        private readonly IDrawingHelper _drawingHelper;

        public ShapeDrawer(IDrawingHelper drawingHelper)
        {
            _drawingHelper = drawingHelper;
        }

        /// <summary>
        /// Gets user input and calls the Draw method of the corresponding geometric shape so it can be rendered to the console. It then checks if the user would like to continue drawing and calls itself recursively if they give an affirmative answer. 
        /// </summary>

        public void DrawShape()
        {
            Console.WriteLine("\n");

            var sides = UserInteraction.GetNumberOfSides();

            switch (sides)
            {
                case 3:
                    var heightInput = UserInteraction.GetHeight();
                    Console.WriteLine();
                    new Triangle(heightInput).Draw(_drawingHelper);
                    break;

                case 4:
                    heightInput = UserInteraction.GetHeight();
                    var widthInput = UserInteraction.GetWidth();
                    Console.WriteLine();
                    new Rectangle(widthInput, heightInput).Draw(_drawingHelper);
                    break;

                default:
                    Console.WriteLine("\nSorry! You can't draw that geometric shape yet.");
                    break;
            }

            if (UserInteraction.CheckContinue())
            {
                DrawShape();
            }

        }
    }
}
