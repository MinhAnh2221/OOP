using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Bruschetta : IAppetizer
    {
        protected string _name;
        private bool hasClassic;
        private bool hasSteakAndBlue;
        private bool hasChickenSalad;

        public Bruschetta()
        {
            _name = "Bruschetta";
        }

        public string GetAppetizerName()
        {
            return _name;
        }

        public void SetClassic(bool value)
        {
            hasClassic = value;
        }

        public void SetSteakAndBlue(bool value)
        {
            hasSteakAndBlue = value;
        }
        public void SetChickenSalad(bool value)
        {
            hasChickenSalad = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasClassic)
            {
                calories += 0;
            }

            if (hasSteakAndBlue)
            {
                calories += 50;
            }

            if (hasChickenSalad)
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
            Console.WriteLine("\nPlease choose the type of Bruschetta:");
            Console.WriteLine("1. Classic Bruschetta");
            Console.WriteLine("2. Steak and Blue Cheese Bruschetta");
            Console.WriteLine("3. Chicken Salad Bruschetta");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetClassic(true);
                    Console.WriteLine($"\nClassic Bruschetta selected. Calories: {GetCalories()}");
                    break;
                case 2:
                    SetSteakAndBlue(true);
                    Console.WriteLine($"\nSteak and Blue Cheese Bruschetta selected. Calories: {GetCalories()}");
                    break;
                case 3:
                    SetChickenSalad(true);
                    Console.WriteLine($"\nChicken Salad Bruschetta selected. Calories: {GetCalories()}");
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

    //public class SteakAndBlueCheeseBruschetta : Bruschetta
    //{
    //    public string Type { get; private set; }

    //    private bool hasSteak;
    //    private bool hasCheese;
    //    public SteakAndBlueCheeseBruschetta()
    //    {
    //        Type = "Steak and Blue Cheese Bruschetta";
    //    }
    //    public void AddSteak()
    //    {
    //        Console.WriteLine("Extra Steak");
    //        hasSteak = true;
    //    }

    //    public void AddBlueCheese()
    //    {
    //        Console.WriteLine("Extra Blue cheese");
    //        hasCheese = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasSteak)
    //        {
    //            calories += 100;
    //        }   

    //        if (hasCheese)
    //        {
    //            calories += 50;
    //        }

    //        return calories;
    //    }
    //}


    //public class ChickenSaladBruschetta : Bruschetta
    //{
    //    public string Type { get; private set; }

    //    private bool hasChicken;
    //    private bool hasSalad;
    //    public ChickenSaladBruschetta()
    //    {
    //        Type = "Chicken Salad Bruschetta";
    //    }
    //    public void AddSteak()
    //    {
    //        Console.WriteLine("Extra Chicken");
    //        hasChicken = true;
    //    }

    //    public void AddBlueCheese()
    //    {
    //        Console.WriteLine("Extra Salad");
    //        hasSalad = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasChicken)
    //        {
    //            calories += 100;
    //        }
    //        if (hasSalad)
    //        {
    //            calories += 50;
    //        }

    //        return calories;
    //    }
    //}

}
