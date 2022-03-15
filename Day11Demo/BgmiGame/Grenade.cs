using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Demo.BgmiGame
{
    public class Grenade : IWeapon
    {
        public void Hide()
        {
            Console.WriteLine("Hide Grenade");
        }

        public void Shoot()
        {
            Console.WriteLine("Whoosh Boom Grenade");
        }

        public void Show()
        {
            Console.WriteLine("Show Grenade");
        }
    }
}
