using day11Democode.Tools;

namespace day11Democode.Factories
{
    class DrawToolFactory
    {
        public static IDrawTool Create(char key = 'b')
        {
            switch (key)
            {
                case 'b':
                    return new Brush();
                case 'r':
                    return new Roller();
                case 'p':
                    return new Pencil();
                case 'n':
                    return new Pen();
                case 'e':
                    return new Eraser();
                case 'k':
                    return new Knife();
            }
            return null;
        }
    }
}

