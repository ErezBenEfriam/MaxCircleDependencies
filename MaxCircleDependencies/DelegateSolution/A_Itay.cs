using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCircleDependencies
{
    internal class A_Itay
    {
        private readonly B_Coffee coffeMaker;
        public A_Itay()
        {
            coffeMaker = new B_Coffee();
            coffeMaker.MakingCoffe(CallFreinds);
        }



        public void CallFreinds()
        {
            Console.WriteLine("Calling Freinds....delegate solution");
        }
    }
}
