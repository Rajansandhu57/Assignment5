using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                GenerateList a = new GenerateList();
                a.Run(57);
            }
        }
        class GenerateList
        {
            const int LEN = 100;

            ArrayList ListQ;

            public void Run(int AddUptoNumber)
            {
                Random r = new Random();

                ListQ = new ArrayList();

                for (int i = 0; i < LEN; i++)
                {
                    ListQ.Add(r.Next(100));
                    this.findTwoNumbersThatAddUpTo(AddUptoNumber);
                    break;
                }
            }
            public void findTwoNumbersThatAddUpTo(int a)
            {
                Random r = new Random();

                ListQ = new ArrayList();
                int n1 = 0;
                int n2 = 0;
                for (int i = 0; i < LEN; i++)
                {
                    int num1 = ListQ.Add(r.Next(100));
                    int num2 = ListQ.Add(r.Next(100));
                    if (num1 + num2 == a)
                    {
                        n1 = num1;
                        n2 = num2;
                        Console.WriteLine($"The two numbers are {n1} and {n2}.");
                    }
                }
            }
        }
    }
}


    