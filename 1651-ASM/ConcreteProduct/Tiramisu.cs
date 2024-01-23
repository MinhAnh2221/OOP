using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Tiramisu : IDessert
    {
        protected string _name;
        private bool hasPumpkin;
        private bool hasStrawberry;
        private bool hasChocolate;
        private bool hasExtraSweet;
        private bool hasNone;

        public Tiramisu()
        {
            _name = "Tiramisu";
        }

        public string GetDessertName()
        {
            return _name;
        }

        public void SetPumpkin(bool value)
        {
            hasPumpkin = value;
        }

        public void SetStrawberry(bool value)
        {
            hasStrawberry = value;
        }
        public void SetChocolate(bool value)
        {
            hasChocolate = value;
        }

        public void SetExtraSweet(bool value)
        {
            hasExtraSweet = value;
        }

        public void SetNone(bool value)
        {
            hasNone = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasPumpkin)
            {
                calories += 0;
            }

            if (hasStrawberry)
            {
                calories += 10;
            }

            if (hasChocolate)
            {
                calories += 15;
            }

            if (hasExtraSweet)
            {
                calories += 120;
            }

            if (hasNone)
            {
                calories += 0;
            }
            return calories;
        }

        public void PairWithBeverage(BeverageType beverageType)
        {
            Console.WriteLine($"{_name} paired with {beverageType}.");
        }
        public void PerformDessertFunction()
        {
            Console.WriteLine("\nPlease choose the type of Tiramisu:");
            Console.WriteLine("1. Pumpkin Tiramisu");
            Console.WriteLine("2. Strawberry Tiramisu");
            Console.WriteLine("3. Chocolate Tiramisu");
            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetPumpkin(true);
                    Console.WriteLine($"\nPumpkin Tiramisu. Calories: {GetCalories()}");
                    _name = "Pumpkin Tiramisu";
                    break;
                case 2:
                    SetStrawberry(true);
                    Console.WriteLine($"\nStrawberry Tiramisu. Calories: {GetCalories()}");
                    _name = "Strawberry Tiramisu";
                    break;
                case 3:
                    SetChocolate(true);
                    Console.WriteLine($"\nChocolate Tiramisu. Calories: {GetCalories()}");
                    _name = "Chocolate Tiramisu";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nDo you want to customize your Tiramisu?");
            Console.WriteLine("1. Extra Sweet");
            Console.WriteLine("2. No custom");
            Console.WriteLine("3. Done");
            int Choice = GetChoice(3);

            while (Choice != 3)
            {
                switch (Choice)
                {
                    case 1:
                        SetExtraSweet(true);
                        Console.WriteLine($"\nExtra Sweet added. Calories: {GetCalories()}");
                        break;
                    case 2:
                        SetNone(true);
                        Console.WriteLine($"\nNo custom. Calories: {GetCalories()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nChoose another customization or press 3 to choose another dish.");
                Choice = GetChoice(4);
            }

            Console.WriteLine("\nTiramisu customization completed.");
        }

        public static int GetChoice(int maxChoice)
        {
            while (true)
            {
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= maxChoice)
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
