using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Mochi : IDessert
    {
        protected string _name;
        private bool hasDaifuku;
        private bool hasKinako;
        private bool hasIceCream;
        private bool hasExtraSweet;
        private bool hasNone;

        public Mochi()
        {
            _name = "Mochi";
        }

        public string GetDessertName()
        {
            return _name;
        }

        public void SetDaifuku(bool value)
        {
            hasDaifuku = value;
        }

        public void SetKinako(bool value)
        {
            hasKinako = value;
        }
        public void SetIceCream(bool value)
        {
            hasIceCream = value;
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

            if (hasDaifuku)
            {
                calories += 0;
            }

            if (hasKinako)
            {
                calories += 10;
            }

            if (hasIceCream)
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
            Console.WriteLine("\nPlease choose the type of Mochi:");
            Console.WriteLine("1. Daifuku Mochi");
            Console.WriteLine("2. Kinako Mochi");
            Console.WriteLine("3. Ice Cream Mochi");
            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetDaifuku(true);
                    Console.WriteLine($"\nDaifuku Mochi. Calories: {GetCalories()}");
                    _name = "Daifuku Mochi";
                    break;
                case 2:
                    SetKinako(true);
                    Console.WriteLine($"\nKinako Mochi. Calories: {GetCalories()}");
                    _name = "Kinako Mochi";
                    break;
                case 3:
                    SetIceCream(true);
                    Console.WriteLine($"\nIceCream Mochi. Calories: {GetCalories()}");
                    _name = "Ice Cream Mochi";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nDo you want to customize your Mochi?");
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

            Console.WriteLine("\nMochi customization completed.");
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
