using TrianglesTest.Drawing;
using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;
using TrianglesTest.Shapes;


var drawingHelper = new DrawingHelper();
var drawer = new ShapeDrawer(drawingHelper);


MainExercise();


if (UserInteraction.CheckContinue())
{
   drawer.DrawShape();
}

void MainExercise()
{
    var input = 10;

    for (int i = 1; i <= input; i++)
    {
        new Triangle(i).Draw(drawingHelper);
        Thread.Sleep(1000);
    }
}

