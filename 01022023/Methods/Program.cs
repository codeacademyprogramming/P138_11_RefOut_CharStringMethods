using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.IsDigit('4'));
            Console.WriteLine(char.IsLetter('A'));
            Console.WriteLine(char.IsLetter('@'));
            Console.WriteLine(char.IsLetterOrDigit('t'));

            var letter = char.ToLower('5');
            letter = char.ToUpper('a');

            Console.WriteLine(char.IsUpper('A'));
            Console.WriteLine(char.IsLower('b'));

            string word = "Salam";

            var newWord = word.ToUpper();
            newWord = word.ToLower();

            Console.WriteLine(newWord);

            Console.WriteLine(newWord.Contains("lam"));
            Console.WriteLine(newWord.IndexOf('a'));
            Console.WriteLine(newWord.LastIndexOf('a'));
            Console.WriteLine(newWord.IndexOf("la"));


            word = "   salam necesen   ";
            Console.WriteLine(word.TrimStart());//"salam necesen   "   
            Console.WriteLine(word.TrimEnd());//"   salam necesen"
            Console.WriteLine(word.Trim());//"salam necesen"
            //word = word.Trim();
            Console.WriteLine(word);

            var index = word.IndexOf("necesen");
            var word2 = word.Substring(index,4);

            word2 = word.Replace("salam", "hello");
            
            word = "Hello   P138 group!";
            word = "Salam Abbas necesen.Salam  Hikmet.Salam Tofiq";

            Console.WriteLine("baslayirmi? "+word.StartsWith("Hello P"));
            Console.WriteLine("bitirmi? " + word.EndsWith("up!"));


            word = "Hello P138 group!";
            var arr = word.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string[] names = { "Hikmet", "Abbas", "Tofiq" };
            var result = String.Join(" - ", names);


            Console.WriteLine(result);




            if (char.IsUpper(word[0]))
            {
                Console.WriteLine("Yaziniz boyuk herfle baslayir");
            }

            string input;
            do
            {
                Console.WriteLine("yazi daxil edin");
                input = Console.ReadLine();
            } 
            while (!char.IsUpper(input[0]));

            Console.WriteLine(input);

        }
    }
}
