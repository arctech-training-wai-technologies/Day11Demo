﻿// See https://aka.ms/new-console-template for more information


// Basic OOP Principle
// Loose binding vs Tight Binding

// S O L I D - Design principles of OOP
// S - Single Responsibility Principle
// O - Open - Close Principle (Classes should be closed to modification and open to extension)

interface IMenuClickable
{
    public void DoClearScreen();
    public void DoShow();
    public void DoAddNew();
}

class StudentManagement: IMenuClickable
{
    public void Start()
    {
        IMenu menu = MenuFactory.Create();
        menu.Show(this);   
    }

    public void DoClearScreen()
    {
        Console.Clear();
    }

    public void DoShow()
    {
        Console.WriteLine("Showing In Progress");
    }

    public void DoAddNew()
    {
        Console.WriteLine("Adding In Progress");
    }
}

class MenuFactory
{
    public static IMenu Create()
    {
        return new Menu(10);
    }
}