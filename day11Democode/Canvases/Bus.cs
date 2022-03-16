using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11Democode.Canvases
{
    public class Bus : ICanvas
    {
        public void Draw(IDrawTool drawTool)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nBus is going fast, I want to paint using {drawTool.Draw()}");
            Console.ResetColor();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
