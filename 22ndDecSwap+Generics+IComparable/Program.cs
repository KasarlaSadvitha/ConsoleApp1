using System;
using System.Collections;

    class Swapping:IComparable
    {
        
        public static void Swap<T>(T a, T b) 
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap A={0},B={1}", a, b);
        }

    public int CompareTo(object? obj)
    {
        
    }
}
class MainClass
{
    static void Main()
    {
        int i = 10;
        int j = 20;
        Swap<int>(i, j);
    }
}

