using System;

namespace MinionIdNumber
{
    class Program
    {
        static string GetMinionIdNumber(int n)
        {
            string o = "";
            int r = 0, d = 1, ten = 1;

            if (n == r)
                o = "2";

            for (int i = 3; ; i += 2)
            {
                if (i >= ten * 10)
                {
                    d++;
                    ten *= 10;
                }

                if (CheckPrime(i))
                {
                    if (n > r + d) //Continue until we get the prime number that contain nth digit
                    {
                        r += d;
                    }
                    else
                    {
                        //We got the prime number that contain nth digit, so from now we will collect digits from prime number and return after get 5 digit.
                        int p = i, tten = ten;
                        while (tten > 0)
                        {
                            r++;

                            if (n < r)
                                o = o + "" + (p / tten).ToString();
                            else if (n == r)
                                o = "" + (p / tten).ToString();

                            if (n <= r - 4)
                                return o;

                            p = p % tten;
                            tten = tten / 10;
                        }
                    }
                }
            }
        }

        static bool CheckPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input: (int) n = 0 Output: (string) " + GetMinionIdNumber(0));
            Console.WriteLine("Input: (int) n = 1 Output: (string) " + GetMinionIdNumber(1));
            Console.WriteLine("Input: (int) n = 2 Output: (string) " + GetMinionIdNumber(2));
            Console.WriteLine("Input: (int) n = 3 Output: (string) " + GetMinionIdNumber(3));
            Console.WriteLine("Input: (int) n = 100 Output: (string) " + GetMinionIdNumber(100));
            Console.WriteLine("Input: (int) n = 139 Output: (string) " + GetMinionIdNumber(139));
            Console.WriteLine("Input: (int) n = 1000 Output: (string) " + GetMinionIdNumber(1000));
            Console.WriteLine("Input: (int) n = 10000 Output: (string) " + GetMinionIdNumber(10000));
            Console.ReadLine();
        }
    }
}