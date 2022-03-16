namespace day11Democode
{
    class DrawAction
    {
        public static void Execute(ConsoleKeyInfo keyInfo, IDrawTool selectedDrawTool, ICanvas selectedCanvas)
        {
            switch (keyInfo.KeyChar)
            {
                case 'd':
                    selectedCanvas.Draw(selectedDrawTool);
                    break;
                case 'u':
                    selectedCanvas.Undo();
                    break;

            }
        }        
    }
}

