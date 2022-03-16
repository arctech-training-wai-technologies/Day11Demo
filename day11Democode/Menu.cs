namespace day11Democode
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("\nDraw Menu");
            Console.WriteLine("Change Surface, (1.Building, 2.Paper, 3.Train, 4.Plane, 5.T-Shirt, 6. Dress, 7. Bus");
            Console.WriteLine("Change Tool, (b.Brush, r.Roller, p.Pencil, n.Pen, e.Eraser, k.Knife");
            Console.WriteLine("d.Draw");
            Console.WriteLine("u.Undo");

            Console.Write("Select a choice: ");
        }
    }
}

