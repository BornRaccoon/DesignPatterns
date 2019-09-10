using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ModelDuck : Duck
    {
        public ModelDuck(string name, string color) : base(name, color)
        {
            IFlyBehavior fbehavior = new FlyNoWay();
            IQuackBehavior fquack = new Squeak();
            base.setFlyBehavior(fbehavior);
            base.setQuackBehavior(fquack);
        }



    }
}
