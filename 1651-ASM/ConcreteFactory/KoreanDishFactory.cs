using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1651_ASM.AbstractFactory;
using _1651_ASM.AbstractProduct;
using _1651_ASM.ConcreteProduct;

namespace _1651_ASM.ConcreteFactory
{
    public class KoreanDishFactory : IRestaurantFactory
    {
        public IAppetizer CreateAppetizer()
        {
            return new Kimchi();
        }

        public IMainCourse CreateMainCourse()
        {
            return new Tokbokki();
        }

        public IDessert CreateDessert()
        {
            return new Bingsu();
        }
    }
}
