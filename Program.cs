using System;
using System.Collections.Generic;

namespace Triangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pockemons();
        }

        static void Pockemons()
        {
            bool status = true;


            List<string> list = new List<string>() { "PIKACHU", "CHARMALEON", "GEODUDE", "GYARADOS", "BUTTERFREE", "MANKEY" };

            while (status != false)
            {
                Console.WriteLine("EXCHANGE POKEMON");
                Console.WriteLine("0. " + list[0]);
                Console.WriteLine("1. " + list[1]);
                Console.WriteLine("2. " + list[2]);
                Console.WriteLine("3. " + list[3]);
                Console.WriteLine("4. " + list[4]);
                Console.WriteLine("5. " + list[5]);
                Console.WriteLine("Choose a Pokemon (or -1 to quit): ");

                string pockeBall1 = String.Empty;
                string pockeBall2 = String.Empty;

                int opt = int.Parse(Console.ReadLine());

                int pockemon = int.Parse(Console.ReadLine());

                if (opt == -1 || pockemon == -1)
                {
                    status = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");

                }
                if (opt >= 0 && opt <= 5 && pockemon >= 0 && pockemon <= 5)
                {
                    pockeBall1 = list[pockemon];
                    pockeBall2 = list[opt];

                    list[opt] = pockeBall1;
                    list[pockemon] = pockeBall2;

                    Console.WriteLine("Choose a Pokemon to exchange with " + list[opt] + ":" + pockemon);

                    Console.WriteLine("Exchanging " + list[opt] + " with " + list[pockemon] + ".");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }




        }
        static void RandomSearchOfNumber()
        {
            Console.WriteLine("Enter number:");

            int num = int.Parse(Console.ReadLine());

            Console.Clear();

            Random c = new Random();

            int[] arr = new int[10];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = c.Next(1, 50);
            }

            string str = "Array: " + arr[0].ToString() + " " + arr[1].ToString() + " " + arr[2].ToString()
                + " " + arr[3].ToString() + " " + arr[4].ToString()
                + " " + arr[5].ToString() + " " + arr[6].ToString()
                + " " + arr[7].ToString() + " " + arr[8].ToString() + " " + arr[9].ToString();

            Console.WriteLine(str);
            Console.WriteLine("Value to find: " + num);

            for (int k = 0; k <= arr.Length - 1; k++)
            {
                if (arr[k] == num)
                {
                    Console.WriteLine(num + " is in the array");
                }
            }
        }
        static void PalindromeString()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            string str2 = string.Empty;

            for (int i = str.Length - 1; i >= 0; --i)
                str2 += str[i];

            if (str == str2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
        static void EqualStrings()
        {
            Console.WriteLine("Enter two strings: ");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();



            if (str1.Length == str2.Length)
            {
                str1 = string.Concat(str1, str2);
                Console.WriteLine(str1);

            }
            else if (str1.Length > str2.Length)
            {
                str1 = str1.Remove(0, str1.Length - str2.Length);

                str1 = string.Concat(str1, str2);
                Console.WriteLine(str1);
            }
            else
            {
                str2 = str2.Remove(0, str2.Length - str1.Length);
                str2 = string.Concat(str1, str2);
                Console.WriteLine(str2);
            }
        }
        static void NewString()
        {
            Console.WriteLine("Enter two strings : ");

            string str1 = Console.ReadLine();

            string str2 = Console.ReadLine();



            if (str1.Length <= 1 || str2.Length <= 1)
            {
                Console.WriteLine("String must be greater than 1");
            }
            else
            {
                string st1 = str1.Remove(0, 1);
                string st2 = str2.Remove(0, 1);

                string newString = String.Concat(st1, st2);

                Console.WriteLine(newString);
            }


        }
    }
}
