using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Cs50_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 1, 5, 10, 20, 50, 100 };
            int[] adet = new int[6];
            int sum = 0;

            //Müşteri {ödeme} lira veriyor. Para üstü en verimli şekilde nasıl belirlenmeli ?
            Console.WriteLine("Lütfen fatura meblağsını belirtiniz: ");
            int fatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen yapılan ödemeyi belirtiniz: ");
            int ödeme = Convert.ToInt32(Console.ReadLine());
            int paraüstü = fatura - ödeme;

            for (int i = 1; i <= para.Length; i++)
            {
                for (int j = 0; sum < paraüstü; j++)
                {
                    sum =+ para[para.Length - i];
                    adet[adet.Length - i]++;
                }


                
            }

            Console.WriteLine($"Geri ödeme olarak {adet[5]} adet 100, {adet[4]} adet 50, {adet[3]} adet 20, {adet[2]} adet 10, {adet[1]} adet 5, {adet[0]} adet 1 TL ödenmesi gerekmektedir.");

            for (int i = 1; i <= para.Length; i++)
            {
                sum =+ adet[adet.Length - i] * para[para.Length - i];
            }


            Console.WriteLine($"Sonuç olarak {sum} TL ödenecektir.");
            Console.ReadLine();


        }
    }
}
