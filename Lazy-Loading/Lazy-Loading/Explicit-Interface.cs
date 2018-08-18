using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Loading
{
    public interface IServerbale
    {
        void Save();
    }











    class Explicit_Interface : IServerbale
    {



        public void AnotherMethod()
        {
            Console.WriteLine("Inside another method =");
            Console.ReadLine();
        }

        public void Save()
        {
            Console.WriteLine("hi");
            Console.ReadLine();
        }
    }
}
