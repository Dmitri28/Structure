using System;

namespace Structure
{
    class Program
    {
        struct Num
        {
            public int n;
            public void show()
            {
                Console.WriteLine("You are enered this number"+" " + n);
            }
        }
        static void Main(string[] args)
        {
            Num num = new Num();
            num.n = 10;
            num.show();
        }
    }
  
}

