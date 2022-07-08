using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal abstract class ClassAbstract
    {
        public void nonAbstractMethod()
        {
            Console.WriteLine("Non abstract method");
        }

        public abstract void abstractMethod();
    }

    internal class ClassTest: ClassAbstract
    {
        public override void abstractMethod()
        {
            Console.WriteLine("Abstract method");
        }

        public static void Main()
        {
            ClassTest t = new ClassTest();
            ClassAbstract a = t;
            t.abstractMethod();
            t.nonAbstractMethod();
            a.abstractMethod();
            a.nonAbstractMethod();
            Console.ReadLine();
        }
    }
}
