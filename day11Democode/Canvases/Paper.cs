using day11Democode;

class Paper : ICanvas
{
    public void Draw(IDrawTool drawTool)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nPaper Drawing using {drawTool.Draw()}");
        Console.ResetColor();
    }

    public void Undo()
    {

    }
}
