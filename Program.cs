using TrianglesTest.Drawing;
using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;
using TrianglesTest.Shapes;


var drawingHelper = new DrawingHelper();
var drawer = new ShapeDrawer(drawingHelper);


MainExercise(10);


if (UserInteraction.CheckContinue())
{
   drawer.DrawShape();
}

void MainExercise(int input)
{
    for (int i = 1; i <= input; i++)
    {
        new Triangle(i).Draw(drawingHelper);
        Console.WriteLine();
        Thread.Sleep(1000);
    }
}

