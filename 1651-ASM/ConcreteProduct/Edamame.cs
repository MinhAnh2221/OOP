using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Edamame : IAppetizer
    {
        protected string _name;
        private bool hasWarm;
        private bool hasCold;

        public Edamame()
        {
            _name = "Edamame";
        }

        public string GetAppetizerName()
        {
            return _name;
        }

        public void SetWarm(bool value)
        {
            hasWarm = value;
        }
        public void SetCold(bool value)
        {
            hasCold = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasWarm)
            {
                calories += 50;
            }

            if (hasCold)
            {
                calories += 10;
            }

            return calories;
        }
        public void PairWithBeverage(BeverageType beverageType)
        {
            Console.WriteLine($"{_name} paired with {beverageType}.");
        }

        public void PerformAppetizerFunction()
        {
            Console.WriteLine("\nPlease choose the type of Edamame:");
            Console.WriteLine("1. Warm Edamame");
            Console.WriteLine("2. Cold Edamame");

            int choice = GetChoice(2);

            switch (choice)
            {
                case 1:
                    SetWarm(true);
                    Console.WriteLine($"\nWarm. Calories: {GetCalories()}");
                    break;
                case 2:
                    SetCold(true);
                    Console.WriteLine($"\nCold. Calories: {GetCalories()}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
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
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

    }




}
