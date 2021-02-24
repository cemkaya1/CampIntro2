using System;

namespace CollectionsMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> cities = new MyList<int, string>();
            cities.AddItems(1, "Adana");
            cities.AddItems(6, "Ankara");
            cities.AddItems(19, "Corum");
            cities.ListItems();
            Console.WriteLine("Total items in the list is " + cities.ItemsLenght);
        }
    }
}
