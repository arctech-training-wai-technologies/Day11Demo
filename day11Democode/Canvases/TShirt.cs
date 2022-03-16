using day11Democode;

class TShirt : ICanvas
{
    public void Draw(IDrawTool drawTool)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nT-Shirt Drawing using {drawTool.Draw()}");
        Console.ResetColor();
    }

    public void Undo()
    {

    }
}
