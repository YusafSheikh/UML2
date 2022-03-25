using System;
using System.Collections.Generic;

namespace UML2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pizzaMenu = new List<T>() { 1, 2, 3, 4 };
            Console.WriteLine(pizzaMenu[1]); // prints 1
            Console.WriteLine(pizzaMenu[2]); // prints 2
            Console.WriteLine(pizzaMenu[3]); // prints 3
            Console.WriteLine(pizzaMenu[4]); // prints 4

            // using foreach LINQ method
            pizzaMenu.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < pizzaMenu.Count; i++)
                Console.WriteLine(pizzaMenu[i]);
        }
    }
}


