using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RealDuck : Duck
    {
        public RealDuck (string name, string color) : base(name, color)
        {
            IFlyBehavior fbehavior = new FlyWithWings();
            IQuackBehavior fquack = new Quack();
            base.setFlyBehavior(fbehavior);
            base.setQuackBehavior(fquack);
        }

    }
}
