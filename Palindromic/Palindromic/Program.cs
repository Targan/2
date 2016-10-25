using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeAlgorithm;
            timeAlgorithm = Stopwatch.StartNew();
            int first = 999, second = 999;
            int []a = SearchPalindromic(first, second);
            timeAlgorithm.Stop();

            Console.WriteLine("Palindromic number = " + a[0]);
            Console.WriteLine("First multiplier = " + a[1] + "\nSecond multiplier = " + a[2]);
            Console.WriteLine("The elapsed time of the algorithm: {0}ms", timeAlgorithm.Elapsed.TotalMilliseconds);
        }



        static private int []SearchPalindromic(int firstNumbers, int secondNumbers)
        {
            int palin = 0;
            string reversePalin;
            int []answer = new int[3];
            for (int j = secondNumbers; j > 0; j--)
            {
                for (int i = secondNumbers; i > 0; i--)
                {

                    if (i % 10 == 1 && j % 10 == 9 || j % 10 == 1 && i % 10 == 9 || i % 10 == 3 && j % 10 == 3)
                    {
                        palin = i * j;
                        reversePalin = ReverseNumb(palin);

                        if (palin / 100000 != 9)
                        {
                            break;
                        }

                        if (Equals(palin.ToString(), reversePalin))
                        {
                           
                            //Console.WriteLine(j + " * " + i + " = " + j * i);
                            if (answer[0] < palin)
                            {
                                answer[0] = palin;
                                answer[1] = j;
                                answer[2] = i;
                                return answer;
                            }
                        }
                    }

                }
            }

            return answer;
        }



        static private string ReverseNumb(int numb)
        {
            char []toReverse = numb.ToString().ToCharArray();
            Array.Reverse(toReverse);
            string temp = "";

            foreach(char ch in toReverse)
            {
                temp += ch;
            }

            return temp;
        }
    }
}
