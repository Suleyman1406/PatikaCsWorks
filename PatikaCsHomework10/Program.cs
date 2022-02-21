namespace array_props
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 23, 12, 8, 56, 1, 5, 298 };

            foreach (var num in nums)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Array.Sort(nums);
            foreach (var num in nums)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Array.Clear(nums, 2, 2);
            foreach (var num in nums)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Array.Reverse(nums);
            foreach (var num in nums)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(Array.IndexOf(nums, 298));

            Array.Resize(ref nums, 3);
            foreach (var num in nums)
            {
                Console.Write(num + ", ");
            }
        }
    }
}