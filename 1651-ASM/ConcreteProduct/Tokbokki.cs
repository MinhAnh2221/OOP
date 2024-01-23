using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Tokbokki : IMainCourse
    {
        protected string _name;
        private bool hasTraditional;
        private bool hasSpicy;
        private bool hasCheese;
        private bool hasExtraRiceCakes;
        private bool hasExtraSpicy;
        private bool hasExtraCheese;

        public Tokbokki()
        {
            _name = "Tokbokki";
        }

        public string GetMainCourseName()
        {
            return _name;
        }

        public void SetTraditional(bool value)
        {
            hasTraditional = value;
        }

        public void SetSpicy(bool value)
        {
            hasSpicy = value;
        }
        public void SetCheese(bool value)
        {
            hasCheese = value;
        }

        public void SetExtraRiceCakes(bool value)
        {
            hasExtraRiceCakes = value;
        }

        public void SetExtraSpicy(bool value)
        {
            hasExtraSpicy = value;
        }
        public void SetExtraCheese(bool value)
        {
            hasExtraCheese = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasTraditional)
            {
                calories += 0;
            }

            if (hasSpicy)
            {
                calories += 10;
            }

            if (hasCheese)
            {
                calories += 15;
            }

            if (hasExtraRiceCakes)
            {
                calories += 120;
            }

            if (hasExtraSpicy)
            {
                calories += 10;
            }

            if (hasExtraCheese)
            {
                calories += 25;
            }
            return calories;
        }

        public void PairWithBeverage(BeverageType beverageType)
        {
            Console.WriteLine($"{_name} paired with {beverageType}.");
        }
        public void PerformMainCourseFunction()
        {
            Console.WriteLine("\nPlease choose the type of Tokbokki:");
            Console.WriteLine("1. Traditional Tokbokki");
            Console.WriteLine("2. Spicy Tokbokki");
            Console.WriteLine("3. Cheese Tokbokki");
            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetTraditional(true);
                    Console.WriteLine($"\nTraditional Tokbokki: Spicy stir-fried rice cakes. Calories: {GetCalories()}");
                    _name = "Traditional Tokbokki";
                    break;
                case 2:
                    SetSpicy(true);
                    Console.WriteLine($"\nSpicy Tokbokki: Extra spicy stir-fried rice cakes. Calories: {GetCalories()}");
                    _name = "Spicy Tokbokki";
                    break;
                case 3:
                    SetCheese(true);
                    Console.WriteLine($"\nCheese Tokbokki: Stir-fried rice cakes with melted cheese. Calories: {GetCalories()}");
                    _name = "Cheese Tokbokki";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nDo you want to customize your Tokbokki?");
            Console.WriteLine("1. Add extra rice cakes");
            Console.WriteLine("2. Make it spicy");
            Console.WriteLine("3. Add cheese");
            Console.WriteLine("4. Done");
            int Choice = GetChoice(4);

            while (Choice != 4)
            {
                switch (Choice)
                {
                    case 1:
                        SetExtraRiceCakes(true);
                        Console.WriteLine($"\nExtra rice cakes added. Calories: {GetCalories()}");
                        break;
                    case 2:
                        SetExtraSpicy(true);
                        Console.WriteLine($"\nExtra Spicy added. Calories: {GetCalories()}");
                        break;
                    case 3:
                        SetExtraCheese(true);
                        Console.WriteLine($"\nExtra Cheese added. Calories: {GetCalories()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nChoose another customization or press 4 to choose another dish.");
                Choice = GetChoice(4);
            }

            Console.WriteLine("\nTokbokki customization completed.");
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

    //public class TraditionalTokbokki : Tokbokki
    //{
    //    public string Type { get; private set; }

    //    private bool hasRiceCake;
    //    public TraditionalTokbokki()
    //    {
    //        Type = "Traditional Tokbokki";
    //    }
    //    public void AddRiceCake()
    //    {
    //        Console.WriteLine("Extra rice cakes");
    //        hasRiceCake = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasRiceCake)
    //        {
    //            calories += 100;
    //        }

    //        return calories;
    //    }
    //}

    //public class SpicyTokbokki : Tokbokki
    //{
    //    public string Type { get; private set; }

    //    private bool hasRiceCake;
    //    private bool hasSpicy;
    //    public SpicyTokbokki()
    //    {
    //        Type = "Spicy Tokbokki";
    //    }
    //    public void AddRiceCake()
    //    {
    //        Console.WriteLine("Extra rice cakes");
    //        hasRiceCake = true;
    //    }
    //    public void AddSpicy()
    //    {
    //        Console.WriteLine("Extra spicy");
    //        hasSpicy = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasRiceCake)
    //        {
    //            calories += 100;
    //        }
    //        if (hasSpicy)
    //        {
    //            calories += 20;
    //        }

    //        return calories;
    //    }
    //}

    //public class CheeseTokbokki : Tokbokki
    //{
    //    public string Type { get; private set; }

    //    private bool hasRiceCake;
    //    private bool hasCheese;
    //    public CheeseTokbokki()
    //    {
    //        Type = "Cheese Tokbokki";
    //    }
    //    public void AddRiceCake()
    //    {
    //        Console.WriteLine("Extra rice cakes");
    //        hasRiceCake = true;
    //    }
    //    public void AddCheese()
    //    {
    //        Console.WriteLine("Extra cheese");
    //        hasCheese = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasRiceCake)
    //        {
    //            calories += 100;
    //        }
    //        if (hasCheese)
    //        {
    //            calories += 100;
    //        }

    //        return calories;
    //    }

        

    //}




}
