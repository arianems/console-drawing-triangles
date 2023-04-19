using TrianglesTest.Helpers;
using TrianglesTest.Helpers.Interfaces;
using TrianglesTest.Shapes;


var drawingHelper = new DrawingHelper();


MainExercise();


if (UserInteraction.CheckContinue())
{
   DrawShape(drawingHelper);
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

void DrawShape(IDrawingHelper drawingHelper)
{
    Console.WriteLine("\n");

    var sides = UserInteraction.GetNumberOfSides();

    switch (sides)
    {
        case 3:
            var heightInput = UserInteraction.GetHeight();
            Console.WriteLine("");
            new Triangle(heightInput).Draw(drawingHelper);
            break;

        case 4:
            heightInput = UserInteraction.GetHeight();
            var widthInput = UserInteraction.GetWidth();
            Console.WriteLine("");
            new Rectangle(widthInput, heightInput).Draw(drawingHelper);
            break;

        default:
            Console.WriteLine("\nSorry! You can't draw that yet.");
            break;
    }

    if (UserInteraction.CheckContinue())
    {
        DrawShape(drawingHelper);
    }



}