using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11Democode.Canvases
{
    class Dress : ICanvas
    {
        public void Draw(IDrawTool drawTool)
        {
            Console.WriteLine($"Drawing on Dress with {drawTool.Draw()}");
        }

        public void Undo()
        {
            
        }
    }
}
