using day11Democode;

class Plane : ICanvas
{
    public void Draw(IDrawTool drawTool)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nPlane Drawing using {drawTool.Draw()}");
        Console.ResetColor();
    }

    public void Undo()
    {

    }
}
