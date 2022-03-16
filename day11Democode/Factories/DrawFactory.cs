namespace day11Democode.Factories
{
    class DrawFactory
    {
        internal static (IDrawTool, ICanvas) Create(ConsoleKeyInfo keyInfo)
        {
            IDrawTool selectedDrawTool = null;
            ICanvas selectedCanvas = null;

            if (keyInfo.KeyChar >= 'a' && keyInfo.KeyChar <= 'z')
            {
                selectedDrawTool = DrawToolFactory.Create(keyInfo.KeyChar);
            }
            else if (keyInfo.KeyChar >= '0' && keyInfo.KeyChar <= '9')
            {
                selectedCanvas = CanvasFactory.Create(keyInfo.KeyChar);
            }

            return (selectedDrawTool, selectedCanvas);
        }
    }
}

