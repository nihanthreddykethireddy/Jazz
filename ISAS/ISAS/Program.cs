using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAS
{
    interface A
    {

    }

    interface B : A
    {

    }
    class C : B
    {

    }
    class E : C
    {

    }
    class Program : E
    {
        static void Main(string[] args)
        {
            Program d = new Program();
            Console.WriteLine(Class1.hai(d, typeof(A)));
            Console.WriteLine(Class1.hai(d, typeof(A)) ? d : null);
        }
    }
}
