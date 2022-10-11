using System;

namespace myApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);

                int Var1 = 10;
                int Var2 = 20;
                int Var3 = 30;

                Console.WriteLine(Var1);
                Console.WriteLine(Var2);
                Console.WriteLine(Var3);

                Console.WriteLine(Var1 < Var2);
                Console.WriteLine(Var2 == Var3);

                Var1++;
                Var3--;

                Console.WriteLine(Var1);
                Console.WriteLine(Var3);

                Var1 += 10;
                Var2 += 10;
                Var3 += 10;
            }
        }
    }
}