using day11Democode.Canvases;

namespace day11Democode.Factories
{
    class CanvasFactory
    {
        public static ICanvas Create(char key = '1')
        {
            switch (key)
            {
                case '1':
                    return new Building();

                case '2':
                    return new Paper();

                case '3':
                    return new Train();

                case '4':
                    return new Plane();

                case '5':
                    return new TShirt();

                case '6':
                    return new Dress();
                case '7':
                    return new Bus();
            }

            return null;
        }
    }
}

