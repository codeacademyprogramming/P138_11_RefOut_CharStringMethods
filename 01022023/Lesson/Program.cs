using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            SetZero(out num);

            Console.WriteLine(num);

            string numStr = "45";
            SetZero(ref numStr);
            Console.WriteLine(numStr);

            int[] nums = { 14, 45, 65 };
            SetZero(nums);
            Console.WriteLine(nums[0]);


            num = -10;
            MakePositive(ref num);
            Console.WriteLine(num);

            num = 5;
            Sqrt(ref num);

            Console.WriteLine(num);

            int number = -70;
            ChangeNum(ref number);
            Console.WriteLine(number);

            string str = "Salam  necesen,  Abbas?"; //Salamnecesen,Abbas?
            //RemoveSpace(str);
            Console.WriteLine(str);

            string sentence = "Salam  necesen Abbas";
            RemoveSpaces(ref sentence);

            Console.WriteLine(sentence);
        }

        //Verilmis yazinin icindeki butun bosluqlari silen metod

        static void RemoveSpaces(ref string str)
        {

            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    newStr += str[i];
            }

            str = newStr;
        }

        //Verilmis ededi menfidirse musbet musbetdirse menfi ededn metod
        static void ChangeNum(ref int num)
        {
            num = num * -1;
        }
        static void SetZero(out int number)
        {
            number = 0;
        }

        static void SetZero(ref string str)
        {
            str = "0";
        }

        static void SetZero(int[] arr)
        {
            arr[0] = 0;
        }

        static void MakePositive(ref int x)
        {
            if (x < 0)
                x *= -1;
        }

        static void Sqrt(ref int x)
        {
            x = x * x;
        }
    }
}
