using day11Democode.Factories;

namespace day11Democode
{
    class Draw
    {
        public void Start()
        {
            IDrawTool selectedDrawTool = DrawToolFactory.Create();
            ICanvas selectedCanvas = CanvasFactory.Create();

            do
            {
                // Console.Clear();
                Menu.Show();

                var keyInfo = Console.ReadKey();

                var (tool, canvas) = DrawFactory.Create(keyInfo);

                if (tool != null)
                    selectedDrawTool = tool;
                if (canvas != null)
                    selectedCanvas = canvas;
                
                DrawAction.Execute(keyInfo, selectedDrawTool, selectedCanvas);

            } while (true);

        }        
    }
}

