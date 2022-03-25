using System;
using System.Collections.Generic;
namespace UML2
{
    public class MenuCatalog
    {
        public MenuCatalog()
        {
            List<int> pizzaMenu = new List<int>();
            pizzaMenu.Add(1); // adding elements using add() method
            pizzaMenu.Add(2);
            pizzaMenu.Add(3);
            pizzaMenu.Add(4);

            var pizza = new List<string>();
            pizza.Add("New Yorker");
            pizza.Add("Salat pizza");
            pizza.Add("Punjabi Mix");
            pizza.Add("Oblock");
            pizza.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var Thepizza = new List<string>()
            {
                "New Yorker" +
                "Salat pizza" +
                "Punjabi Mix" +
                "Oblock"
            };
        }
    }
}

// PrintMenu og SearchPizza