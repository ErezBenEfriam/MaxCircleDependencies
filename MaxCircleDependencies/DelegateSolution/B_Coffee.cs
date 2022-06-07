using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCircleDependencies
{
    
    public class B_Coffee
    {
        public void MakingCoffe(Action action)
        {
            action.Invoke();
            Console.WriteLine("making coffe.....delegate solution");
        }
    }
}
