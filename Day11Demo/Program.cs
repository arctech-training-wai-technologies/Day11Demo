// See https://aka.ms/new-console-template for more information

// Basic OOP Principle
// Loose binding vs Tight Binding

// S O L I D - Design principles of OOP
// S - Single Responsibility Principle
// O - Open - Close Principle (Classes should be closed to modification and open to extension)

using Day11Demo.BgmiGame;

BgmiGame game = new BgmiGame();
game.Start();

//IEmployee employee = new Employee();
//employee.Initialize(10, "Raman", 40);
//employee.Show();

//StudentManagement studentManagement = new StudentManagement();
//studentManagement.Start();

// Basic OOP Principle
// Loose binding vs Tight Binding

// S O L I D - Design principles of OOP
// S - Single Responsibility Principle
// O - Open - Close Principle (Classes should be closed to modification and open to extension)

class Menu : IMenu
{
    public Menu(int x)
    {

    }
    public void Show(IMenuClickable menuClickable)
    {
        do
        {
            int i = 10;
            var menuId = ShowMenu();

            switch (menuId.KeyChar)
            {
                case '1':
                    menuClickable.DoAddNew();
                    break;
                case '2':
                    menuClickable.DoShow();
                    break;
                case '3':
                    return;
                case '4':
                    menuClickable.DoClearScreen();
                    break;
            }
        } while (true);
    }

    public void Fly()
    {

    }

    private ConsoleKeyInfo ShowMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("=========");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Show");
        Console.WriteLine("3. Exit");
        Console.WriteLine("4. Clear Screen");

        var keyInfo = Console.ReadKey();
        return keyInfo;
    }
}
