using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Demo
{
    public interface IEmployee
    {
        public void Initialize(int id, string name, int age);
        public void Show();
    }

    public class Employee : IEmployee
    {
        int Id;
        string Name;
        int Age;

        public void Initialize(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }

        public void ShowHighlight()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
            Console.ResetColor();
        }
    }
}
