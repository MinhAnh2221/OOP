using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Kimchi : IAppetizer
    {
        protected string _name;
        private bool hasCabbage;
        private bool hasCucumber;
        private bool hasMustardLeaf;

        public Kimchi()
        {
            _name = "Kimchi";
        }

        public string GetAppetizerName()
        {
            return _name;
        }

        public void SetCabbage(bool value)
        {
            hasCabbage = value;
        }

        public void SetCucumber(bool value)
        {
            hasCucumber = value;
        }
        public void SetMustardLeaf(bool value)
        {
            hasMustardLeaf = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasCabbage)
            {
                calories += 20;
            }

            if (hasCucumber)
            {
                calories += 50;
            }

            if (hasMustardLeaf)
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
            Console.WriteLine("\nPlease choose the type of Kimchi:");
            Console.WriteLine("1. Cabbage Kimchi");
            Console.WriteLine("2. Cucumber Kimchi");
            Console.WriteLine("3. Mustard Leaf Kimchi");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetCabbage(true);
                    Console.WriteLine($"\nCabbage Kimchi selected. Calories: {GetCalories()}");
                    break;
                case 2:
                    SetCucumber(true);
                    Console.WriteLine($"\nCucumber Kimchi selected. Calories: {GetCalories()}");
                    break;
                case 3:
                    SetMustardLeaf(true);
                    Console.WriteLine($"\nMustard Leaf Kimchi selected. Calories: {GetCalories()}");
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

    //public class CabbageKimchi : Kimchi
    //{
    //    public string GetKimchiName()
    //    {
    //        return "Cabbage Kimchi";
    //    }

    //    public int GetCalories()
    //    {
    //        return 100;
    //    }
    //}
    //public class CucumberKimchi : Kimchi
    //{
    //    public string GetKimchiName()
    //    {
    //        return "Cucumber Kimchi";
    //    }

    //    public int GetCalories()
    //    {

    //        return 80;
    //    }
    //}

    //public class MustardLeafKimchi : Kimchi
    //{
    //    public string GetKimchiName()
    //    {
    //        return "Mustard Leaf Kimchi";
    //    }

    //    public int GetCalories()
    //    {

    //        return 120;
    //    }
    //}


}
