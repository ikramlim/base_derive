using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_derive
{
    class Baseclass
    {
        int i;
        public Baseclass(int ii)
        {
            i = ii;
            Console.Write("Base");
        }
    }
    class Derived: Baseclass
    {
        public Derived(int ii):base(ii)
        {
            Console.Write("Derived \n");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived(20);
        }
        
    }
}
