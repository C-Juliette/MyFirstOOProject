using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            #region My First Class

            Console.WriteLine("Hello World!");
            var m = new MaClasse();
            var m2 = new MaClasse("I am m2");
            Console.WriteLine("a - m : " + m.GetTata());
            Console.WriteLine("b - m2 : " + m2.GetTata());
            m.SetTata("untruc");
            Console.WriteLine("c - m : " + m.GetTata());
            m.DoubleWord();
            Console.WriteLine("d - m : " + m.GetTata());

            #endregion

            #region Fractions

            

            #endregion
            
        }
    }
}