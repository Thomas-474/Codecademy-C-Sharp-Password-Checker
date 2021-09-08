using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecademy_C_Sharp_Password_Checker
{
    class Program
    {
        public class Tools
        {
            public Tools()
            {
            }

            public static bool Contains(string target, string list)
            {
                return target.IndexOfAny(list.ToCharArray()) != -1;
            }

            public static void ContainsTest()
            {
                string loudWord = "LASDAD";
                string quietWord = "pssst";
                string mixedWord = "lkaAWEkasfkEW";

                string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string lowercase = "abcdefghijklmnopqrstuvwxyz";

                Console.WriteLine("Running \"tests...\"");
                Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
                Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
                Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
                Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
                Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
                Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
            }
        }

        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!";

            string userPwrd = Console.ReadLine();
            int score = 0;

            int len = userPwrd.Length;
            if (len >= minLength)
            {
                score++;
            }

            if (Tools.Contains(userPwrd, uppercase))
            {
                score++;
            }

            if (Tools.Contains(userPwrd, lowercase))
            {
                score++;
            }

            if (Tools.Contains(userPwrd, digits))
            {
                score++;
            }

            if (Tools.Contains(userPwrd, specialChars))
            {
                score++;
            }

            Console.WriteLine($"{score}/5 Points");

            switch (score)
            {
                case 5:
                    Console.WriteLine("Password is extremely strong");
                    break;
                case 4:
                    Console.WriteLine("Password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 2:
                    Console.WriteLine("Password strength is medium");
                    break;
                case 1:
                    Console.WriteLine("Password is weak");
                    break;
                default:
                    Console.WriteLine("Password doesn’t meet any of the standards");
                    break;
            }

            Console.ReadKey();
        }
    }
}
