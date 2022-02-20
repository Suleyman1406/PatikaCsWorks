using System;

namespace type_casting
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---- Implict Conversion----");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "zikriye";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine(g);

            Console.WriteLine("---- Explicit Conversion----");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine(v);
        }


    }
}