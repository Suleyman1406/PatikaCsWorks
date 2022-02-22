namespace question_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 20 number");
            int[] arr = new int[20];
            int[] biggerArr = new int[3];
            int[] smallerArr = new int[3];
            int biggerTotal = 0;
            int smallerTotal = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. number: ", i + 1);
                bool isNumeric = int.TryParse(Console.ReadLine(), out arr[i]);
                if (!isNumeric)
                {
                    Console.WriteLine("Must be numeric!");
                    --i;
                    continue;
                }

            }
            Array.Sort(arr);
            for (int i = 0; i < 3; i++) smallerArr[i] = arr[i];
            for (int i = arr.Length - 1, j = 0; i > arr.Length - 4; j++, i--) biggerArr[j] = arr[i];
            Console.WriteLine("Bigger numbers list: ");
            Console.Write("\t");

            foreach (var i in biggerArr)
            {
                Console.Write(i + ", ");
                biggerTotal += i;
            }
            Console.WriteLine();
            Console.WriteLine("Bigger numbers average: " + (double)biggerTotal / 3);
            Console.WriteLine("Smaller numbers list: ");
            Console.Write("\t");
            foreach (var i in smallerArr)
            {
                Console.Write(i + ", ");
                smallerTotal += i;
            }
            Console.WriteLine();
            Console.WriteLine("Smaller numbers average: " + (double)smallerTotal / 3);
            Console.WriteLine();
            Console.WriteLine("Total average: " + (double)(smallerTotal + biggerTotal) / 6);

        }
    }
}