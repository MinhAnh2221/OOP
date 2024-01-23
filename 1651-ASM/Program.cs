using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1651_ASM.AbstractProduct;
using _1651_ASM.ConcreteProduct;
using _1651_ASM.ConcreteFactory;
using _1651_ASM.AbstractFactory;
namespace _1651_ASM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IAppetizer> appetizers = new List<IAppetizer>();
            List<IMainCourse> mainCourses = new List<IMainCourse>();
            List<IDessert> desserts = new List<IDessert>();
            List<BeverageType> selectedBeverages = new List<BeverageType>();

            Console.WriteLine("Welcome to World Flavors Restaurant!");

            IAppetizer appetizer = null;
            IMainCourse mainCourse = null;
            IDessert dessert = null;

            while (true)
            {
                try
                {
                    Console.WriteLine("\nSelect a type of dish:");
                    Console.WriteLine("1. Appetizer");
                    Console.WriteLine("2. Main Course");
                    Console.WriteLine("3. Dessert");
                    Console.WriteLine("4. Exit");

                    int dishChoice = GetChoice(4);

                    if (dishChoice == 4)
                    {
                        break;
                    }

                    Console.WriteLine("\nSelect a type of restaurant:");
                    Console.WriteLine("1. Japanese Restaurant");
                    Console.WriteLine("2. Italian Restaurant");
                    Console.WriteLine("3. Korean Restaurant");

                    int restaurantChoice = GetChoice(3);

                    Console.WriteLine("\nSelect a beverage type:");
                    Console.WriteLine("1. None");
                    Console.WriteLine("2. Water");
                    Console.WriteLine("3. Soda");
                    Console.WriteLine("4. Tea");
                    Console.WriteLine("5. Coffee");

                    int beverageChoice = GetChoice(5);
                    BeverageType selectedBeverage = (BeverageType)(beverageChoice - 1);

                    IRestaurantFactory restaurantFactory = null;

                    switch (restaurantChoice)
                    {
                        case 1:
                            restaurantFactory = new JapaneseDishFactory();
                            break;
                        case 2:
                            restaurantFactory = new ItalianDishFactory();
                            break;
                        case 3:
                            restaurantFactory = new KoreanDishFactory();
                            break;
                        default:
                            break;
                    }

                    switch (dishChoice)
                    {
                        case 1:
                            appetizer = restaurantFactory.CreateAppetizer();
                            break;
                        case 2:
                            mainCourse = restaurantFactory.CreateMainCourse();
                            break;
                        case 3:
                            dessert = restaurantFactory.CreateDessert();
                            break;
                    }

                    if (appetizer != null)
                    {
                        appetizer.PerformAppetizerFunction();
                        appetizers.Add(appetizer);
                        selectedBeverages.Add(selectedBeverage);
                        DisplayAppetizerInfo(appetizer, selectedBeverage);
                    }
                    else if (mainCourse != null)
                    {
                        mainCourse.PerformMainCourseFunction();
                        mainCourses.Add(mainCourse);
                        selectedBeverages.Add(selectedBeverage);
                        DisplayMainCourseInfo(mainCourse, selectedBeverage);
                    }
                    else if (dessert != null)
                    {
                        dessert.PerformDessertFunction();
                        desserts.Add(dessert);
                        selectedBeverages.Add(selectedBeverage);
                        DisplayDessertInfo(dessert, selectedBeverage);
                    }

                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            //Display selected dish
            static void DisplayAppetizerInfo(IAppetizer appetizer, BeverageType beverage)
            {
                Console.WriteLine($"Selected Appetizer Type: {appetizer.GetAppetizerName()}");
                Console.WriteLine($"Selected Beverage: {beverage}");
            }
            static void DisplayMainCourseInfo(IMainCourse mainCourse, BeverageType beverage)
            {
                Console.WriteLine($"Selected Main Course Type: {mainCourse.GetMainCourseName()}");
                Console.WriteLine($"Selected Beverage: {beverage}");
            }
            static void DisplayDessertInfo(IDessert dessert, BeverageType beverage)
            {
                Console.WriteLine($"Selected Dessert: {dessert.GetDessertName()}");
                Console.WriteLine($"Selected Beverage: {beverage}");
            }

            // Display all selected dishes
            Console.WriteLine("\nSelected Appetizers:");
            for (int i = 0; i < appetizers.Count; i++)
            {
                Console.WriteLine($"- {appetizers[i].GetAppetizerName()} (Calories: {appetizers[i].GetCalories()})");
                Console.WriteLine($"  Beverage: {selectedBeverages[i]}");
            }
            Console.WriteLine("\nSelected Main Courses:");
            for (int i = 0; i < mainCourses.Count; i++)
            {
                Console.WriteLine($"- {mainCourses[i].GetMainCourseName()} (Calories: {mainCourses[i].GetCalories()})");
                Console.WriteLine($"  Beverage: {selectedBeverages[i]}");
            }
            Console.WriteLine("\nSelected Desserts:");
            for (int i = 0; i < desserts.Count; i++)
            {
                Console.WriteLine($"- {desserts[i].GetDessertName()} (Calories: {desserts[i].GetCalories()})");
                Console.WriteLine($"  Beverage: {selectedBeverages[i]}");
            }
            Console.WriteLine("Thank you for dining at World Flavors Restaurant!");





            static int GetChoice(int maxChoice)
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
            

            //static IAppetizer GetAppetizer(int restaurantChoice)
            //{
            //    switch (restaurantChoice)
            //    {
            //        case 1: 
            //            return new Edamame();
            //        case 2:
            //            return new Bruschetta();
            //        case 3:
            //            return new Kimchi();
            //        default:
            //            return null;
            //    }
            //}


            //static IMainCourse GetMainCourse(int restaurantChoice)
            //{
            //    switch (restaurantChoice)
            //    {
            //        case 1:
            //            return new Ramen();
            //        case 2:
            //            return new Pizza();
            //        case 3:
            //            return new Tokbokki();
            //        default:
            //            return null;
            //    }
            //}

            //static IDessert GetDessert(int restaurantChoice)
            //{
            //    switch (restaurantChoice)
            //    {
            //        case 1:
            //            return new Mochi();
            //        case 2:
            //            return new Tiramisu();
            //        case 3:
            //            return new Bingsu();
            //        default:
            //            return null;
            //    }
            //}

        }

    }
}
