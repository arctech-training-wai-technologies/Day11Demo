namespace Day11Demo.BgmiGame;

public class BgmiGame
{
    public void Start()
    {
        IWeapon weapon = WeaponFactory.Create();
        do
        {
            Console.Write ("\nSelect action (1-switch Pistol, 2-switch Bazooka, 3-Shoot, 4-Show, 5-Hide): ");
            var keyInfo = Console.ReadKey();

            var createdWeapon = WeaponFactory.Create(keyInfo.KeyChar);

            if (createdWeapon != null)
                weapon = createdWeapon;
            else
            {
                switch (keyInfo.KeyChar)
                {
                    case '3':
                        weapon.Shoot();
                        break;
                    case '4':
                        weapon.Show();
                        break;
                    case '5':
                        weapon.Hide();
                        break;
                }
            }
        } while (true);
    }
}
