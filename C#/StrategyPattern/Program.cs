using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck aRealDuck = new RealDuck("Rupert", "Blue");
            aRealDuck.performFly();
            aRealDuck.performQuack();

            Duck aModelDuck = new ModelDuck("John", "Yellow");
            aModelDuck.performFly();
            aModelDuck.performQuack();

            Console.ReadKey();

            
        }
    }
}
