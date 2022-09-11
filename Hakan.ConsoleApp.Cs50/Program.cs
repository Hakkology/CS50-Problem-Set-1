using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Cs50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen kaç satır istediğinizi giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 2* x + 2; j++)
                {
                    if (j == x || j == x + 1)
                    {
                        Console.Write(" ");
                    }
                    else if (j < x - 1 - i && j < x + 1)
                    {
                        Console.Write(" ");
                    }
                    else if (j > x + 2 && j > x + 2 + i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
