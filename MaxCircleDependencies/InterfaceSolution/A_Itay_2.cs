using MaxCircleDependencies.InterfaceSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCircleDependencies
{
    internal class A_Itay_2: IA_Itay_2
    {
        private readonly B_Coffee_2 coffeMaker;
        public A_Itay_2()
        {
            coffeMaker = new B_Coffee_2();
            coffeMaker.MakingCoffe(this);
        }



        public void CallFreinds()
        {
            Console.WriteLine("Calling Freinds....interface solution");
        }
    }
}
