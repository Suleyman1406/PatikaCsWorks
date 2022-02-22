using System.Collections;

namespace question_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] vowels = { 'a', 'ı', 'o', 'u', 'e', 'i', 'ö', 'ü' };
            Console.WriteLine("Please enter sentence: ");
            string sentence = Console.ReadLine();
            if (sentence == null) return;

            char[] charArr = sentence.ToCharArray();
            ArrayList sentenceVowels = new ArrayList();
            foreach (var item in charArr)
            {
                if (vowels.Contains(item))
                {
                    sentenceVowels.Add(item);
                }
            }
            sentenceVowels.Sort();
            foreach (var i in sentenceVowels) Console.Write(i + " ");

        }
    }
}