using _1651_ASM.AbstractFactory;
using _1651_ASM.AbstractProduct;
using _1651_ASM.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1651_ASM.ConcreteProduct;

namespace _1651_ASM.ConcreteFactory
{
    public class ItalianDishFactory : IRestaurantFactory
    {
        public IAppetizer CreateAppetizer()
        {
            return new Bruschetta();
        }

        public IMainCourse CreateMainCourse()
        {
            return new Pizza();
        }

        public IDessert CreateDessert()
        {
            return new Tiramisu();
        }
    }
}
