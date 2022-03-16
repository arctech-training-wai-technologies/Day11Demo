using day11Democode;

class Train : ICanvas
{
    public void Draw(IDrawTool drawTool)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nTrain Drawing using {drawTool.Draw()}");
        Console.ResetColor();
    }

    public void Undo()
    {

    }
}
