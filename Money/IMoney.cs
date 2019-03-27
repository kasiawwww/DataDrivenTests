using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    /// <summary>
    /// Ten interfejs jest do pieniedzy.
    /// </summary>
    interface IMoney
    {
        IMoney Add(IMoney m);
        IMoney AddMoney(Money m);
        IMoney AddMoneyBag(MoneyBag s);

        bool isZero { get;}
        IMoney Multiply(int factor);
        IMoney Negate();
        IMoney Substract(IMoney m);
    }
}
