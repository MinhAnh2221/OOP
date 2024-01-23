using _1651_ASM.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.AbstractFactory
{
    public interface IRestaurantFactory
    {
        IAppetizer CreateAppetizer();
        IMainCourse CreateMainCourse();
        IDessert CreateDessert();
    }
}
