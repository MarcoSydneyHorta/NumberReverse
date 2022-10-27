using System;

namespace NumberReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int nr = Reverse(n);
            Console.WriteLine("The reverse number is " + nr);
        }

        static public int Reverse(int x)
        {
            string xs = x.ToString();
            int tam = xs.Length;
            string[] xc = new string[tam];
            for (int i = 0; i < tam; i++)
            {
                if (xs[i].CompareTo('-') == 0)
                {
                    xc[0] = xs[0].ToString();
                }
                else
                {
                    if (xs[0].CompareTo('-') == 0)
                    {
                        xc[i] = xs[tam - i].ToString();
                    }
                    else
                    {
                        xc[i] = xs[tam - 1 - i].ToString();
                    }

                }

            }
            return int.Parse(string.Concat(xc));
        }
    }
}
