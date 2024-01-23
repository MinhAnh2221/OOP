using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Bingsu : IDessert
    {
        protected string _name;
        private bool hasTraditional;
        private bool hasFruity;
        private bool hasChocolate;
        private bool hasExtraSweet;
        private bool hasNone;

        public Bingsu()
        {
            _name = "Bingsu";
        }

        public string GetDessertName()
        {
            return _name;
        }

        public void SetTraditional(bool value)
        {
            hasTraditional = value;
        }

        public void SetFruity(bool value)
        {
            hasFruity = value;
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

            if (hasTraditional)
            {
                calories += 0;
            }

            if (hasFruity)
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
            Console.WriteLine("\nPlease choose the type of Bingsu:");
            Console.WriteLine("1. Traditional Bingsu");
            Console.WriteLine("2. Fruity Bingsu");
            Console.WriteLine("3. Chocolate Bingsu");
            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetTraditional(true);
                    Console.WriteLine($"\nTraditional Bingsu. Calories: {GetCalories()}");
                    _name = "Traditional Bingsu";
                    break;
                case 2:
                    SetFruity(true);
                    Console.WriteLine($"\nFruity Bingsu. Calories: {GetCalories()}");
                    _name = "Fruity Bingsu";
                    break;
                case 3:
                    SetChocolate(true);
                    Console.WriteLine($"\nChocolate Bingsu. Calories: {GetCalories()}");
                    _name = "Chocolate Bingsu";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nDo you want to customize your Bingsu?");
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
                        Console.WriteLine("\nInvalid choice.");
                        break;
                }

                Console.WriteLine("\nChoose another customization or press 3 to choose another dish.");
                Choice = GetChoice(4);
            }

            Console.WriteLine("\nBingsu customization completed.");
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
