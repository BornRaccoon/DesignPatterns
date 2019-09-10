using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        readonly string name;
        readonly string color;

        public Duck(string duckName, string duckColor)
        {
            this.name = duckName;
            this.color = duckColor;
        }

        public void swim()
        {
            Console.WriteLine("Duck swims");
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void setFlyBehavior(IFlyBehavior behavior)
        {
            flyBehavior = behavior;
        }

        public void setQuackBehavior(IQuackBehavior behavior)
        {
            quackBehavior = behavior;
        }
    }
}
