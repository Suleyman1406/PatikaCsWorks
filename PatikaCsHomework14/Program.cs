namespace homework
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteEvens();
            WriteFullyDivided();
            WriteReverse();
            WriteCount();
        }
        public static void WriteEvens()
        {
            Console.WriteLine("Please enter length(must be positive): ");
            int len = int.Parse(Console.ReadLine() + "");
            if (len < 1)
            {
                WriteEvens();
                return;
            }
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Please enter {0}. number: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine() + "");
            }
            foreach (var i in arr)
                if (i % 2 == 0) Console.Write(i + ", ");

            Console.WriteLine();

        }
        public static void WriteFullyDivided()
        {
            Console.WriteLine("Please enter length(must be positive): ");
            int n = int.Parse(Console.ReadLine() + "");
            Console.WriteLine("Please enter divided(must be positive): ");
            int m = int.Parse(Console.ReadLine() + "");
            if (n < 1 || m < 1)
            {
                WriteFullyDivided();
                return;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter {0}. number: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine() + "");
            }
            foreach (var i in arr)
                if (i % m == 0) Console.Write(i + ", ");

            Console.WriteLine();
        }

        public static void WriteReverse()
        {
            Console.WriteLine("Please enter length(must be positive): ");
            int n = int.Parse(Console.ReadLine() + "");

            if (n < 1)
            {
                WriteReverse();
                return;
            }
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter {0}. word: ", i + 1);
                arr[i] = Console.ReadLine() + "";
            }
            Array.Reverse(arr);
            foreach (var i in arr)
                Console.Write(i + ", ");

            Console.WriteLine();
        }

        public static void WriteCount()
        {
            Console.WriteLine("Please enter sentence: ");
            string sentence = Console.ReadLine() + "";

            int wordCount = sentence.Split(" ").Count();
            int charCount = sentence.ToCharArray().Count();

            Console.WriteLine("Word Count: {0}; Char count: {1}", wordCount, charCount);

        }
    }
}