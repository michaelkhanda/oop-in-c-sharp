using System;

namespace objectorientedprogramming
{
    class items
    {
        int unit_cost, quantity;
        string item_name, item_number;

        items()
        {
            Console.WriteLine("Enter item name: ");
            item_name = Console.ReadLine();

            Console.WriteLine("Enter item number: ");
            item_number = Console.ReadLine();

            if(item_number.Length != 4)
            {
                Console.WriteLine("Invalid item number! Please re-enter");
            }

            Console.WriteLine("Enter the item quantity: ");
            quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the unit cost: ");
            unit_cost = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine(item_name + " " + item_number + " " + quantity + " " + unit_cost);
        }

        public void totalcost()
        {
            Console.WriteLine("The total cost of " + item_name + " is " + unit_cost * quantity);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many items do you want to enter?");
            int items_amount = int.Parse(Console.ReadLine());
            items[] shopitem = new items [items_amount];

            for (int i = 0; i < items_amount; i++)
            {
                shopitem[i] = new items();
                shopitem[i].display();
                shopitem[i].totalcost();
            }

      
        }
    }
}
