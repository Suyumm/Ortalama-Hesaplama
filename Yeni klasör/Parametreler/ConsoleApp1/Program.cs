using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main2(string[] args)
        {
            //3 öğrencinin Ortalama Hesaplama do while

            /*
            int a, b, c, snc = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            snc = (a + b + c) / 3;
            Console.WriteLine("Ortalama" + snc);
            Console.ReadKey();
            */
            //-----------------------------------------------------------


            //Ortalama Hesaplayıp Geçti Kaldı yazdırma

            /*
            int a, b, c, snc = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            snc = (a + b + c) / 3;
            Console.WriteLine("Ortalama" + snc);
            if (snc>=50)
            {
                

                if (snc>=50&&snc<70)
                {
                    Console.WriteLine("Geçti Fakat belge alamadı");
                    
                }
                else if (snc >= 70 && snc < 85)
                {
                    Console.WriteLine("Teşekkür");
                }
                else if (snc >= 85 && snc < 100)
                {
                    Console.WriteLine("Taktir");
                }


            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            Console.ReadKey();
            */
            //-----------------------------------------------------------


            //100 e kadar tek sayıları yazdırma

            /*
            for (int i = 0; i < 100; i++)
            {
                if(i%2 !=1)
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */
            //-----------------------------------------------------------

            // 5 öğrencinin notunun ortalaması
            /*
            int a,snc=0;
            for (int i = 0; i < 5; i++)
            {
                a=Convert.ToInt32(Console.ReadLine());
                snc = (snc + a);
                
            }
            Console.WriteLine(snc/5);
            Console.ReadKey();
            */
            //-----------------------------------------------------------

            // 5 tane isim yazdırmak

            
            int isim,snc=0;
            int a = 0;
            while (a<5)
            {
                isim = Convert.ToInt32(Console.ReadLine());
                snc = snc + isim;
                
                a++;
            }
            Console.WriteLine(snc);
            Console.ReadKey();
            
            //-----------------------------------------------------------

            //do while ile 1 den 100 e kadar çift sayıları yazdırma

            /*
            int sayi = 1;
            do
            {
                if (sayi % 2 == 0)
                    Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi <= 50);
            Console.ReadKey();
            */
            //-----------------------------------------------------------


            // 1 den 5 a kadar sayı girdirip yazdırma diziler

            /*
            int[] sayi = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sayi[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (var say in sayi)
            {
                Console.WriteLine(say);
            }
            Console.ReadKey();
            */

            //-----------------------------------------------------------




        }
        //geri değer dönürmeyen parametre almayan karenin alanını hesaplama
        /*
        static void Main(string[] args)
        {
            KareAl();
            Console.ReadKey();
        }


        static void KareAl()
        {
            int kenar;
            Console.Write("kenar gir");
            kenar = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("sonuç" + (kenar*kenar));
        }
        */
        //-----------------------------------------------------------

        // geri değer döndürmeyen parametre alan karenin alanın hesaplama
        /*
        static void Main(string[] args)
        {
            int kenar;
            kenar = Convert.ToInt32(Console.ReadLine());
            KareAl(kenar);
            Console.ReadKey();
        }


        static void KareAl(int kenar)
        {
            
            

            Console.WriteLine("sonuç" + (kenar * kenar));
        }
        */
        //-----------------------------------------------------------

        //geri değer döndüren parametre almayan
        
        static void Main(string[] args)
        {
            int a;
            a = Kare();
            Console.WriteLine(Convert.ToInt32(a));
            Console.ReadKey();
        }


        static int Kare()
        {

            int kenar;
            kenar = Convert.ToInt32(Console.ReadLine());

           

            return kenar * kenar;

        }
        
        //-----------------------------------------------------------
        //geri değer döndüren parametre alan


       



    }
}
