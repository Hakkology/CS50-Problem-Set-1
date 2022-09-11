using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Cs50_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            while (valid)
            {
                Console.Write("Lütfen 16 haneli kredi kartı numarasını giriniz: ");
                string creditcardno = Console.ReadLine();
                int n = creditcardno.Length;
                int temp = 0;
                char[] creditcard = creditcardno.ToCharArray();
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        temp = Convert.ToInt32(creditcard[i].ToString());
                        sum += temp;
                    }
                    else
                    {
                        temp = Convert.ToInt32(creditcard[i].ToString());
                        sum += temp * 2;
                    }
                }
                if (sum % 10 != 0)
                {
                    Console.WriteLine("Hatalı bir kredi kartı numarası girdiniz.");
                    continue;
                }
                else
                {
                    if (n==15 && creditcard[0] == '3' && (creditcard[1] == '4' || creditcard[1] == '7'))
                    {
                        valid = false;
                        Console.WriteLine("Kredi kartınız American Express'tir.");
                    }
                    else if (n==16 && creditcard[0] == '5' && (creditcard[1] == '1' || creditcard[1] == '2' || creditcard[1] == '3' || creditcard[1] == '4' || creditcard[1] == '5'))
                    {
                        valid = false;
                        Console.WriteLine("Kredi kartınız MasterCard'dır."); 
                    }
                    else if ((n==13 || n==16) && creditcard[0] == '4')
                    {
                        valid = false;
                        Console.WriteLine("Kredi kartınız Visa'dır.");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir kredi kartı numarası girdiniz.");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
