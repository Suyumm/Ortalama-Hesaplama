using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        İslemGir:

            

            int islem;

            Console.WriteLine("-------------------");
            Console.WriteLine(" 1 - kare alan     ");
            Console.WriteLine(" 2 - Üçgen çevre   ");
            Console.WriteLine(" 3 - Daire alan    ");
            Console.WriteLine(" 4 - Hakkımızda    ");
            Console.WriteLine(" 5 - Çıkış         ");
            Console.WriteLine("-------------------");
            Console.WriteLine("işlem seçiniz");
            islem = Convert.ToInt32(Console.ReadLine());


            switch (islem)
            {
                case 1:  //kare alan
                int kenar;
                Console.WriteLine("Kenar giriniz");
                kenar = Convert.ToInt32(Console.ReadLine());
                KareAlan(kenar);

                    break;

                case 2:  //kare alanı
                Console.WriteLine("Üçgen Çevre"+UcgenCevre());
                    
                    break;

                

                case 3:  //daire alan
                int yaricap;
                Console.WriteLine("Yarı çapı giriniz: ");
                yaricap = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dairenin Alanı:   " + DaireAlan(yaricap));           
                    break;

                case 4:
                    Console.WriteLine("Sabahattin Akal 11/B 90");
                        break;

                case 5:
                    break;
                default:
                    {
                        Console.WriteLine("Yanlış işlem girdiniz");
                        goto İslemGir;

                    }

            }


            Console.ReadKey();


            





        }
        static void KareAlan(int sayi)
        {

            Console.WriteLine("Karenin alanı: " + (sayi * sayi)) ;
           
        }

        static int UcgenCevre()
        {
            int a, b, c ;
            Console.WriteLine("1.uzunluk giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.uzunluk giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3.uzunluk giriniz");
            c = Convert.ToInt32(Console.ReadLine());

            return  a + b + c;

            
            
        }


        static int DaireAlan(int yaricap)
        {

            double r,pi=3.14,snc;
            
            Console.WriteLine("Yarı çapı giriniz");
            r = Convert.ToDouble(Console.ReadLine());

            snc = (int)(pi * (r * r));

            return 3 * yaricap * yaricap;
        }

        static void hak(string[] args)
        {
            Console.WriteLine("Sabahattin Akal 11/B 90");
        }

    }
}
