using System;

namespace myApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            var fibNumbers = new List<int>(0, 1, 1, 2, 3, 5, 8, 13);
            int count = 0;
            foreach (int element in fibNumbers)
            {
                console.WriteLine($"Elemento #{count}: {element}");
                count++;
            }
            console.WriteLine($"Número de elementos: {count}");
        }
    }
}