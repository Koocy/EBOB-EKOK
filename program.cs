using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            bool isAsal = true, ortak1 = false, ortak2 = false;

            int[] ortaklar = new int[0];

            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            int x_const = x;

            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            int y_const = y;

            int length = 0;

            if (x > y)
                length = x;
            else
                length = y;

            int i = 2;

            while (i < length)
            {

                if (i > 2)
                {
                    for (int n = 2; n < i; n++)
                    {
                        if (i % n == 0)
                        {
                            isAsal = false;
                            break;
                        }
                    }
                }

                if (isAsal)
                {

                    if (x % i == 0)
                    {
                        x = x / i;
                        ortak1 = true;
                    }

                    if (y % i == 0)
                    {
                        y = y / i;
                        ortak2 = true;
                    }

                    if (ortak1 && ortak2)
                    {
                        Array.Resize(ref ortaklar, ortaklar.Length + 1);
                        ortaklar[ortaklar.Length - 1] = i;
                    }

                }

                if (!ortak1 && !ortak2)
                {
                    i++;
                }

                isAsal = true; ortak1 = false; ortak2 = false;

            }

            int EBOB = 1;

            for (int z = 0; z < ortaklar.Length; z++)
            {
                EBOB = EBOB * ortaklar[z];
            }

            int EKOK = (x_const * y_const) / EBOB;

            Console.Write("EBOB: " + EBOB + "\nEKOK: " + EKOK);
            Console.ReadKey();

        }
    }
}
