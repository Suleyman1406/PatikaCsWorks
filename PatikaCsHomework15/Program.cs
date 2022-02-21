namespace string_methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "Hello, this is a sentence";
            Console.WriteLine(str.Length);

            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            Console.WriteLine(String.Concat(str, ". This is new sentence."));

            str = "hello";
            Console.WriteLine(str.CompareTo("Hello"));
            Console.WriteLine(String.Compare(str, "Hello", true));
            Console.WriteLine(String.Compare(str, "Hello", false));

            Console.WriteLine(str.Contains("ell"));
            Console.WriteLine(str.EndsWith("ello"));
            Console.WriteLine(str.StartsWith("hel"));

            Console.WriteLine(str.IndexOf("el"));
            Console.WriteLine(str.IndexOf("a"));
            Console.WriteLine(str.LastIndexOf("l"));

            Console.WriteLine(str.Insert(0, "Firstly, "));

            Console.WriteLine("Firstly," + str.PadLeft(30));
            Console.WriteLine(str.PadLeft(30) + " again");

            Console.WriteLine(str.Remove(2));
            Console.WriteLine(str.Remove(4));
            Console.WriteLine(str.Remove(0, 1));

            Console.WriteLine(str.Replace("hello", "bye"));

            Console.WriteLine(str.Split(" ")[1]);

            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Substring(2, 4));

        }
    }
}