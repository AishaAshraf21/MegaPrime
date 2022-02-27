using System;

namespace MegaPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Enter Max Number:");

            int  userNumber = Convert.ToInt32 (Console.ReadLine());

            for (int i=1;i<= userNumber; i++)
            {
                int check = p.IsMegaPrime(i);
                {
                    if(check == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public int isPrime(int n)
        {
            int i = 0, flag = 0;
            if (n == 1)
                return 0;
            else
            {
                int t = (int)Math.Sqrt(n);
                for (i = 2; i <= t; i++)
                {
                    if ((n % i) == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 1)
                return 0;
            else
                return 1;
        }

        public int IsMegaPrime(int n)
        {
            int i = 0, flag = 0, temp = 0;
            if (isPrime(n) == 0)
                return 0;
            else
            {
                while (n != 0)
                {
                    temp = n % 10;
                    flag = isPrime(temp);
                    if (flag == 0)
                        return 0;
                    n /= 10;

                }
            }
            if (flag == 1)
                return 1;
            else
                return 0;
        }
    }
}
