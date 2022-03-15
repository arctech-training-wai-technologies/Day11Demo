namespace Day11Demo.BgmiGame;

public class Bazooka: IWeapon
{
    public void Hide() { Console.WriteLine("\nBazooka Hide!!"); }
    public void Shoot() { Console.WriteLine("\nBazooka Shoot!!"); }
    public void Show() { Console.WriteLine("\nBazooka Show!!"); }
}
