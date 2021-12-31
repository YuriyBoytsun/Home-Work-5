/*3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.


 Юрий Бойцун
 */

using System;
using System.Linq;


namespace HW5._2
{
    class Program
    {
        static bool isThisPermutation(string s1, string s2)
        {
            return s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));
        }

        static bool isThisPermutation2(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            string news1 = s1[0].ToString();
            string news2 = s2[0].ToString();

            for (int i = 1; i < s1.Length; i++)
                putCharIntoStr(ref news1, s1[i]);

            for (int i = 1; i < s2.Length; i++)
                putCharIntoStr(ref news2, s2[i]);

            if (news1.Equals(news2))
                return true;
            else
                return false;
        }

        static void putCharIntoStr(ref string s, char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                {
                    s += ch.ToString();
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            

            Console.WriteLine("Вас приветствует программа проверки является ли одна строка перестановкой другой.");
            Console.WriteLine("Введите первую строку.");
            string first = Console.ReadLine();
            Console.WriteLine("Введите вторую строку.");
            string second = Console.ReadLine();

            Console.WriteLine($"Проверим следующие строки: {first}, и {second}");

            if (isThisPermutation(first, second) == true && isThisPermutation2(first, second) == true)
                Console.WriteLine("Строки являются перестановками друг друга.");
            else
                Console.WriteLine("Строки состоят из разных символов.");

            Console.ReadKey();
        }
    }
}
