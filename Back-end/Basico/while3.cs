using System;

namespace myApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            int n = 0;
            while (n < 5)
            {
                if (n == 2)
                {
                    n++;
                    continue;
                }
                console.WriteLine(n);
                n++;
            }
        }
    }
}