using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_ASM.AbstractProduct
{
    public interface IAppetizer
    {
        string GetAppetizerName();
        int GetCalories();
        void PairWithBeverage(BeverageType beverageType);
        void PerformAppetizerFunction();
    }
}
