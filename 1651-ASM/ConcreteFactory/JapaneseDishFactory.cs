using _1651_ASM.AbstractFactory;
using _1651_ASM.AbstractProduct;
using _1651_ASM.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.ConcreteFactory
{
    public class JapaneseDishFactory : IRestaurantFactory
    {
        public IAppetizer CreateAppetizer()
        {
            return new Edamame();
        }

        public IMainCourse CreateMainCourse()
        {
            return new Ramen();
        }

        public IDessert CreateDessert()
        {
            return new Mochi();
        }
    }
}
