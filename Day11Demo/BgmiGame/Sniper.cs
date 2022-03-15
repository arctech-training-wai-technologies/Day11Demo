using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Demo.BgmiGame
{
    public class Sniper : IWeapon
    {
        public void Hide() { Console.WriteLine("\nSniper Hide!!"); }
        public void Shoot() { Console.WriteLine("\nSniper Shoot!!"); }
        public void Show() { Console.WriteLine("\nSniper Show!!"); }
    }
}
