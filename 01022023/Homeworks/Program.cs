using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "   ";

            var newStr = RemoveStartSpaces(str);

            Console.WriteLine(str);
            Console.WriteLine(RemoveStartSpaces(str));

            int[] numbers = { -10, -23,40, 55, -3, -54, 34, -5, 0 };
            var newNumbers = MakePositive(numbers); //{40, 55, 34}
        }

        //Verilmis yazidaki ilk boslugun indexini tapan metod

        static int FindFirstSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    return i;
            }

            return -1;
        }

        //Verilmis yazidaki ilk bosluq olmayan indexi tapan metod

        static int FindFirstNonSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }

            return -1;
        }

        //Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod

        static string RemoveStartSpaces(string str)
        {
            string newStr = "";

            var firstIndex = FindFirstNonSpace(str);

            if (firstIndex == -1)
                return newStr;

            for (int i = firstIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        //Verilmiş ədədlər siyahısından yalnız müsbət ədədlərindən ibarət yeni bir array düzəldib qaytaran metod
        //static int[] MakePositive(int[] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 0)
        //        {
        //            count++;
        //        }
        //    }

        //    int[] newArr = new int[count];
        //    int j = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 0)
        //        {
        //            newArr[j] = arr[i];
        //            j++;
        //        }
        //    }
        //    return newArr;
        //}
        static int[] MakePositive(int[] arr)
        {

            int[] newArr = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr = Add(newArr, arr[i]);
                }
            }


            return newArr;
        }

        //Verilmis ededler siyahisina verilmis ededi elave edib arrayi qaytaran metod
        //var array = {13,35,23};
        //Add(array, 10)
        static int[] Add(int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;


            return newArr;
        }

    }
}
