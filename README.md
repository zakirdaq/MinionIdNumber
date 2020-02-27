I love to solve programming problem and this one is my top skill. Working with prime number is always fun. This problem "Minion Id Number" (See problem details from the file inside) is a combination of prime number generation and extracting digit from a number.

And this is a c# implementation to solve the problem. I have choosed very basic way to generate prime here. For higher number n > 100000 you can choose sieve algorithm for prime number generation to increase performance though.

Here is my code:

        string GetMinionIdNumber(int n)
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
