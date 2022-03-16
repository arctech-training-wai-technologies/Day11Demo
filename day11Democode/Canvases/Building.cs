using day11Democode;

class Building : ICanvas
{
    public void Draw(IDrawTool drawTool)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nBuilding Drawing using {drawTool.Draw()}");
        Console.ResetColor();
    }

    public void Undo()
    {

    }
}