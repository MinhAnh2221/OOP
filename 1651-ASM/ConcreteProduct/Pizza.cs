using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteProduct
{
    public class Pizza : IMainCourse
    {
        protected string _name;
        private bool hasCheese;
        private bool hasVeggie;
        private bool hasPepperoni;
        private bool hasExtraCheese;
        private bool hasExtraVeggie;
        private bool hasExtraPepperoni;

        public Pizza()
        {
            _name = "Pizza";
        }

        public string GetMainCourseName()
        {
            return _name;
        }

        public void SetCheese(bool value)
        {
            hasCheese = value;
        }

        public void SetVeggie(bool value)
        {
            hasVeggie = value;
        }
        public void SetPepperoni(bool value)
        {
            hasPepperoni = value;
        }

        public void SetExtraCheese(bool value)
        {
            hasExtraCheese = value;
        }

        public void SetExtraVeggie(bool value)
        {
            hasExtraVeggie = value;
        }
        public void SetExtraPepperoni(bool value)
        {
            hasExtraPepperoni = value;
        }

        public int GetCalories()
        {
            int calories = 200;

            if (hasCheese)
            {
                calories += 0;
            }

            if (hasVeggie)
            {
                calories += 10;
            }

            if (hasPepperoni)
            {
                calories += 15;
            }

            if (hasExtraCheese)
            {
                calories += 120;
            }

            if (hasExtraVeggie)
            {
                calories += 10;
            }

            if (hasExtraPepperoni)
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
            Console.WriteLine("\nPlease choose the type of Pizza:");
            Console.WriteLine("1. Cheese Pizza");
            Console.WriteLine("2. Veggie Pizza");
            Console.WriteLine("3. Pepperoni Pizza");
            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    SetCheese(true);
                    Console.WriteLine($"\nCheese Pizza. Calories: {GetCalories()}");
                    _name = "Cheese Pizza";
                    break;
                case 2:
                    SetVeggie(true);
                    Console.WriteLine($"\nVeggie Pizza. Calories: {GetCalories()}");
                    _name = "Veggie Pizza";
                    break;
                case 3:
                    SetPepperoni(true);
                    Console.WriteLine($"\nPepperoni Pizza. Calories: {GetCalories()}");
                    _name = "Pepperoni Pizza";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nDo you want to customize your Pizza?");
            Console.WriteLine("1. Extra Cheese");
            Console.WriteLine("2. Extra Vegetable");
            Console.WriteLine("3. Extra Pepperoni");
            Console.WriteLine("4. Done");
            int Choice = GetChoice(4);

            while (Choice != 4)
            {
                switch (Choice)
                {
                    case 1:
                        SetExtraCheese(true);
                        Console.WriteLine($"\nExtra Cheese added. Calories: {GetCalories()}");
                        break;
                    case 2:
                        SetExtraVeggie(true);
                        Console.WriteLine($"\nExtra Vegetable added. Calories: {GetCalories()}");
                        break;
                    case 3:
                        SetExtraPepperoni(true);
                        Console.WriteLine($"\nExtra Pepperoni added. Calories: {GetCalories()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nChoose another customization or press 4 to choose another dish.");
                Choice = GetChoice(4);
            }

            Console.WriteLine("\nPizza customization completed.");
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

    //public class CheesePizza : Pizza
    //{
    //    public CheesePizza() : base()
    //    {
    //        _name = "Cheese Pizza";
    //    }

    //    public override void PerformMainCourseFunction()
    //    {
    //        Console.WriteLine("Please customize your Cheese Pizza:");
    //        Console.WriteLine("1. Add Extra Cheese");
    //        int choice = GetChoice(1);
    //        switch (choice)
    //        {
    //            case 1:
    //                Console.WriteLine("Added extra cheese to your Cheese Pizza.");
    //                break;
    //            default:
    //                Console.WriteLine("Invalid choice.");
    //                break;
    //        }

    //        Console.WriteLine("Please choose the number of slices:");
    //        Console.WriteLine("1. 6 slices");
    //        Console.WriteLine("2. 8 slices");
    //        int sliceChoice = GetChoice(2);
    //        if (sliceChoice == 1)
    //        {
    //            Console.WriteLine("Pizza is cut into 6 slices.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Pizza is cut into 8 slices.");
    //        }
    //    }
    //}


    //public class VeggiePizza : Pizza
    //{
    //    public VeggiePizza() : base()
    //    {
    //        _name = "Veggie Pizza";
    //    }

    //    public override void PerformMainCourseFunction()
    //    {
    //        Console.WriteLine("Please customize your Veggie Pizza:");
    //        Console.WriteLine("1. Add Vegetables");
    //        int choice = GetChoice(1);
    //        switch (choice)
    //        {
    //            case 1:
    //                Console.WriteLine("Added vegetables to your Veggie Pizza.");
    //                break;
    //            default:
    //                Console.WriteLine("Invalid choice.");
    //                break;
    //        }

    //        Console.WriteLine("Please choose the number of slices:");
    //        Console.WriteLine("1. 6 slices");
    //        Console.WriteLine("2. 8 slices");
    //        int sliceChoice = GetChoice(2);
    //        if (sliceChoice == 1)
    //        {
    //            Console.WriteLine("Pizza is cut into 6 slices.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Pizza is cut into 8 slices.");
    //        }
    //    }
    //}


    //public class PepperoniPizza : Pizza
    //{
    //    public PepperoniPizza() : base()
    //    {
    //        _name = "Pepperoni Pizza";
    //    }

    //    public override void PerformMainCourseFunction()
    //    {
    //        Console.WriteLine("Please customize your Cheese Pizza:");
    //        Console.WriteLine("1. Add Pepperoni");
    //        int choice = GetChoice(1);
    //        switch (choice)
    //        {
    //            case 1:
    //                Console.WriteLine("Added Pepperoni to your Pepperoni Pizza.");
    //                break;
    //            default:
    //                Console.WriteLine("Invalid choice.");
    //                break;
    //        }

    //        Console.WriteLine("Please choose the number of slices:");
    //        Console.WriteLine("1. 6 slices");
    //        Console.WriteLine("2. 8 slices");
    //        int sliceChoice = GetChoice(2);
    //        if (sliceChoice == 1)
    //        {
    //            Console.WriteLine("Pizza is cut into 6 slices.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Pizza is cut into 8 slices.");
    //        }
    //    }
    //}





    //public class CheesePizza : Pizza
    //{
    //    private int numberOfSlices;

    //    public string Type { get; private set; }

    //    private bool hasCheese;
    //    public CheesePizza()
    //    {
    //        Type = "Cheese Pizza";

    //        numberOfSlices = 8; 
    //    }
    //    public void AddCheese()
    //    {
    //        Console.WriteLine("Extra Cheese");
    //        hasCheese = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasCheese)
    //        {
    //            calories += 50;
    //        }
    //        return calories;
    //    }

    //    public void CutPizza(int slices)
    //    {
    //        numberOfSlices = slices;
    //        Console.WriteLine($"Pizza is cut into {numberOfSlices} slices.");
    //    }
    //}

    //public class VeggiePizza : Pizza
    //{
    //    private int numberOfSlices;

    //    public string Type { get; private set; }

    //    private bool hasVegetable;
    //    public VeggiePizza()
    //    {
    //        Type = "Veggie Pizza";

    //        numberOfSlices = 8; 
    //    }
    //    public void AddCheese()
    //    {
    //        Console.WriteLine("Extra Cheese");
    //        hasVegetable = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasVegetable)
    //        {
    //            calories += 50;
    //        }
    //        return calories;
    //    }

    //    public void CutPizza(int slices)
    //    {
    //        numberOfSlices = slices;
    //        Console.WriteLine($"Pizza is cut into {numberOfSlices} slices.");
    //    }
    //}

    //public class PepperoniPizza : Pizza
    //{
    //    private int numberOfSlices;

    //    public string Type { get; private set; }

    //    private bool hasSausage;
    //    public PepperoniPizza()
    //    {
    //        Type = "Pepperoni Pizza";

    //        numberOfSlices = 8;
    //    }
    //    public void AddSausage()
    //    {
    //        Console.WriteLine("Extra Sausage");
    //        hasSausage = true;
    //    }
    //    public override int GetCalories()
    //    {
    //        int calories = 200;

    //        if (hasSausage)
    //        {
    //            calories += 50;
    //        }
    //        return calories;
    //    }

    //    public void CutPizza(int slices)
    //    {
    //        numberOfSlices = slices;
    //        Console.WriteLine($"Pizza is cut into {numberOfSlices} slices.");
    //    }



    //}

}
