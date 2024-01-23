using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Ramen : IMainCourse
    {
        protected string _name;
        private bool hasShoyu;
        private bool hasMiso;
        private bool hasShio;
        private bool hasExtraSpicy;
        private bool hasExtraSweet;
        private bool hasExtraSalty;
        private bool hasExtraSour;
        public Ramen()
        {
            _name = "Ramen";
        }

        public string GetMainCourseName()
        {
            return _name;
        }
        public void SetShoyu(bool value)
        {
            hasShoyu = value;
        }

        public void SetMiso(bool value)
        {
            hasMiso = value;
        }
        public void SetShio(bool value)
        {
            hasShio = value;
        }

        public void SetExtraSpicy(bool value)
        {
            hasExtraSpicy = value;
        }

        public void SetExtraSweet(bool value)
        {
            hasExtraSweet = value;
        }
        public void SetExtraSalty(bool value)
        {
            hasExtraSalty = value;
        }
        public void SetExtraSour(bool value)
        {
            hasExtraSour = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasShoyu)
            {
                calories += 0;
            }

            if (hasMiso)
            {
                calories += 10;
            }

            if (hasShio)
            {
                calories += 15;
            }

            if (hasExtraSpicy)
            {
                calories += 120;
            }

            if (hasExtraSweet)
            {
                calories += 10;
            }

            if (hasExtraSalty)
            {
                calories += 25;
            }

            if (hasExtraSour)
            {
                calories += 25;
            }
            return calories;
        }
        public void PerformMainCourseFunction()
        {
            Console.WriteLine("\nPlease choose the type of Ramen:");
            Console.WriteLine("1. Shoyu Ramen");
            Console.WriteLine("2. Miso Ramen");
            Console.WriteLine("3. Shio Ramen");
            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetShoyu(true);
                    Console.WriteLine($"\nShoyu Ramen. Calories: {GetCalories()}");
                    _name = "Shoyu Ramen";
                    break;
                case 2:
                    SetMiso(true);
                    Console.WriteLine($"\nMiso Ramen. Calories: {GetCalories()}");
                    _name = "Miso Ramen";
                    break;
                case 3:
                    SetShio(true);
                    Console.WriteLine($"\nShio Ramen. Calories: {GetCalories()}");
                    _name = "Shio Ramen";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nDo you want to customize your Ramen?");
            Console.WriteLine("1. Add extra rice cakes");
            Console.WriteLine("2. Make it spicy");
            Console.WriteLine("3. Add cheese");
            Console.WriteLine("4. Extra Sour");
            Console.WriteLine("5. Done");
            int Choice = GetChoice(5);

            while (Choice != 5)
            {
                switch (Choice)
                {
                    case 1:
                        SetExtraSpicy(true);
                        Console.WriteLine($"\nExtra rice cakes added. Calories: {GetCalories()}");
                        break;
                    case 2:
                        SetExtraSweet(true);
                        Console.WriteLine($"\nExtra Spicy added. Calories: {GetCalories()}");
                        break;
                    case 3:
                        SetExtraSalty(true);
                        Console.WriteLine($"\nExtra Cheese added. Calories: {GetCalories()}");
                        break;
                    case 4:
                        SetExtraSour(true);
                        Console.WriteLine($"\nExtra Cheese added. Calories: {GetCalories()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nChoose another customization or press 5 to choose another dish.");
                Choice = GetChoice(5);
            }

            Console.WriteLine("\nRamen customization completed.");
        }

        public void PairWithBeverage(BeverageType beverageType)
        {
            Console.WriteLine($"{_name} paired with {beverageType}.");
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
