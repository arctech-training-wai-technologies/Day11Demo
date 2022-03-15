namespace Day11Demo.BgmiGame;

public class WeaponFactory
{
    public static IWeapon Create(char key = 'p')
    { 
        switch(key)
        {
            case 'p':
                return new Pistol();
            case 'b':
                return new Bazooka();
            case 's':
                return new Sniper();
            case 'd':
                return new Sword();
            case 'g':
                return new Grenade();
        }

        return null;
    }
}
