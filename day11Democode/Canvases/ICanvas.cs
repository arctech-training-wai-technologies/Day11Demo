namespace day11Democode
{
    public interface ICanvas
    {
        public void Draw(IDrawTool drawTool);
        public void Undo();

    }
}
