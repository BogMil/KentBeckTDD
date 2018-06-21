using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTDD.src
{
    class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int num)
        {
            return new Dollar(amount * num);
        }

        public bool IsEaqualTo(object Object)
        {
            Dollar dollar = (Dollar) Object;
            return amount == dollar.amount;
        }
    }
}
