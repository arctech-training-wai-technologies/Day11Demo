using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Demo.BgmiGame
{
    public class Sword : IWeapon
    {
        public void Hide()
        {
            Console.WriteLine("Hide Sword");
        }

        public void Shoot()
        {
            Console.WriteLine("Swipe Sword");
        }

        public void Show()
        {
            Console.WriteLine("Show Sword");
        }
    }
}
