namespace Day11Demo.BgmiGame;

public class Pistol : IWeapon
{
    public void Hide() { Console.WriteLine("\nPistol Hide!!"); }
    public void Shoot() { Console.WriteLine("\nPistol Shoot!!"); }
    public void Show() { Console.WriteLine("\nPistol Show!!"); }
}
