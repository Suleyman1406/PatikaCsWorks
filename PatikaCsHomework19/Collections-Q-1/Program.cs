using System.Collections;

namespace question_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 20 positive number");
            ArrayList evenList = new ArrayList();
            ArrayList oddList = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. number: ", i + 1);
                bool isNumeric = int.TryParse(Console.ReadLine(), out int num);
                if (!isNumeric || num < 0)
                {
                    Console.WriteLine("Must be positive number!");
                    --i;
                    continue;
                }
                if (num % 2 == 0) evenList.Add(num);
                else oddList.Add(num);
            }
            evenList.Sort();
            oddList.Sort();
            evenList.Reverse();
            oddList.Reverse();
            Console.WriteLine("Even list: ");
            Console.Write("\t");
            int evenTotal = 0;
            int oddTotal = 0;
            foreach (var even in evenList)
            {
                Console.Write(even + ", ");
                evenTotal += int.Parse(even + "");
            }
            Console.WriteLine();
            Console.WriteLine("Odd list: ");
            Console.Write("\t");

            foreach (var odd in oddList)
            {
                Console.Write(odd + ", ");
                oddTotal += int.Parse(odd + "");
            }
            Console.WriteLine();
            Console.WriteLine("Even list length: " + evenList.Count + ", average: " + (double)evenTotal / evenList.Count);
            Console.WriteLine("Odd list length: " + oddList.Count + ", average: " + (double)oddTotal / oddList.Count);


        }
    }
}