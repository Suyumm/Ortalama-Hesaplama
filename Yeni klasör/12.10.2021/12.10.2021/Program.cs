using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*{
                int a = 5, b = 9, c;
                a *= 5;
                b /= 3;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine("-------");

                c = a++ + --b;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.ReadKey();
            }*/




            /*Console.WriteLine("\n Merhaba");
            Console.WriteLine("F Dünya");
            Console.ReadKey();
            */




            /*
            int x = 9, y = 5;

            Console.WriteLine("xin değeri = {0} ve ynin değeri = {1}", x, y);
            Console.WriteLine();
            Console.WriteLine("xin değeri = " + x + " ve ynin değeri = " + y ) ;
            Console.WriteLine();
            Console.WriteLine("xin değeri = {0} ",x);
            Console.WriteLine("ynin değeri = " + y);

            Console.ReadKey();
            */




            /*
            string ad = "aaa";
            string sad = " bbb";
            Console.WriteLine("Merhaba\t" + ad + sad + " \t Nasılsın?");
            Console.ReadKey();
            */



            /*
            string ad;

            ad=Console.ReadLine();

            string sad;

            sad=Console.ReadLine();

            Console.WriteLine("Merhaba\t" + ad + sad + "\t Nasılsın?");
            Console.ReadKey();
            */





            /*
            int sayi;
            Console.Write("Sayı giriniz:  ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("girdiğiniz sayı= " + sayi);
            Console.WriteLine("Girdiğiniz sayının 7 fazlasının 5 katı = " + (sayi + 7 )* 5 );
            Console.ReadKey();
            */




            /*
            int a,b;
            Console.WriteLine("A sayısını giriniz");

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B sayısını giriniz");
            b = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("A ve b nin toplamı= " + (a + b ));
            Console.ReadKey();
            */


            /*
            double a, b, c;
            Console.WriteLine("A sayısını giriniz");

            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B sayısını giriniz");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C sayısını giriniz");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Girilen sayıların ortalaması = " + ((a + b + c) / 3));
            Console.ReadKey();

            */
            /*
            double taban, yükseklik, alan;
            Console.WriteLine("Lütfen taban ve yükseklik değerlerini giriniz");

            taban = Convert.ToDouble( Console.ReadLine());
            yükseklik = Convert.ToDouble(Console.ReadLine());

            alan = ((taban * yükseklik) / 2);

            Console.WriteLine("Üçgeninizin alanı = " + alan);
            Console.ReadKey();
            */




            /*
            int sayi;

            sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("birler: " + (sayi % 10));

            Console.WriteLine("yüzler: " + (sayi / 100));
            Console.ReadKey();
            */




            /*
            int dakika;

            dakika = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((dakika / 60) + " saat " + (dakika % 60) + " dakika");


            Console.ReadKey();

            */








            /*

            int saat, dakika;

            saat = Convert.ToInt32(Console.ReadLine());
            dakika = Convert.ToInt32(Console.ReadLine());

            saat= (saat *= 60);

            Console.WriteLine((saat+dakika));


            */


            /*
            int puan;
            Console.WriteLine("puanınızı giriniz ");
                puan = Convert.ToInt16(Console.ReadLine());

            if (puan >= 50)
            {
                Console.WriteLine("Başarılı");
            }


            else
                Console.WriteLine("Başarısız");

            Console.ReadKey();


            */



            /*
            int sayi;
            Console.WriteLine("sayınızı giriniz ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi %2 ==0)
            {
                Console.WriteLine("sayınız çift");
            }

            else

                Console.WriteLine("sayınız tek");

            Console.ReadKey();
            */

            /*
            int sayi;
            Console.WriteLine("sayınızı giriniz ");
            sayi = Convert.ToInt16(Console.ReadLine());
            if ((sayi % 3 == 0) && (sayi % 5 == 0) )
            {
                Console.WriteLine("sayının 3've 5'e kalansız bölünebilir");
            }
            else
                Console.WriteLine("kalansız bölünmez");
            Console.ReadKey();
            */







            /*
            int yas;
            string cinsiyet;
            Console.WriteLine("Yaşınızı giriniz ");

            yas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Cinsiyetinizi giriniz ");
            cinsiyet = Console.ReadLine();

            if ((yas >= 20) && ((cinsiyet == "erkek") || cinsiyet == "Erkek" || cinsiyet == "ERKEK"))
            {
                Console.WriteLine("askere gidebilir");
            }
            else
                Console.WriteLine("askere gidemez");
            Console.ReadKey();


            */


            /*
            int sayi;
            Console.WriteLine("sayınızı giriniz ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("negatif");
            }

            else if (sayi > 0)

                Console.WriteLine("pozitif");

            else

                Console.WriteLine("sıfıra eşit");

            Console.ReadKey();

            */


            /*
            int sayi,sayi2,sayi3;
            Console.WriteLine("1.sayınızı giriniz ");
            sayi = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("2.sayınızı giriniz ");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("3.sayınızı giriniz ");
            sayi3 = Convert.ToInt16(Console.ReadLine());


            if ((sayi > sayi2) && (sayi > sayi3))
            {
                Console.WriteLine(sayi + " en büyük sayı");
            }

            else if ((sayi2 > sayi) && (sayi2 > sayi3)) 

                Console.WriteLine(sayi2 + " en büyük sayı");

            else if ((sayi == sayi2)&& (sayi == sayi3))

                Console.WriteLine("sayılar eşit");

            else

                Console.WriteLine(sayi3 + " en büyük sayı");

            Console.ReadKey();


             */


            /*
            int sayi;
            Console.WriteLine("su sıcaklığını giriniz ");
            sayi = Convert.ToInt16(Console.ReadLine());


            if (sayi > 100)
            {
                Console.WriteLine(" gaz");
            }

            else if (sayi == 100)

                Console.WriteLine("kaynıyor");

            else if (sayi > 0)

                Console.WriteLine("sıvı");

            else if (sayi == 0)
                Console.WriteLine("eriyor");

            else

                Console.WriteLine(" katı");

            Console.ReadKey();
            */


            /*
            int sayi;
            Console.WriteLine("not girin ");
            sayi = Convert.ToInt16(Console.ReadLine());


            if ((sayi >= 85) && (sayi < 101))
            {
                Console.WriteLine("5");
            }

            else if ((sayi >= 70) && (sayi < 84))

                Console.WriteLine("4");

            else if ((sayi >= 55) && (sayi < 69))

                Console.WriteLine("3");

            else if ((sayi >=45) && (sayi < 54))
                Console.WriteLine("2");

            else if ((sayi >= 25) && (sayi < 44))
                Console.WriteLine("1");

            else if ((sayi >=0) && (sayi <=24)) 
                Console.WriteLine("0");


            else

                Console.WriteLine("geçersiz puan");

            Console.ReadKey();

             */


            /*
            int sayi,devam;
            Console.WriteLine("not girin ");
            sayi = Convert.ToInt16(Console.ReadLine());


            if (sayi >= 50)
            {
                Console.WriteLine("Devamsızlık girin ");
                devam = Convert.ToInt16(Console.ReadLine());

                if (devam > 3)
                    Console.WriteLine("belge alamaz");

                else
                    Console.WriteLine("belge alabilir ");

            }

            else
                Console.WriteLine("belge alamaz");

            Console.ReadKey();
            */

            /*
            int ort,devam,kd;
            Console.WriteLine("ortalamanızı giriniz ");
            ort = Convert.ToInt16(Console.ReadLine());


            if (ort >= 50)
            {

                Console.WriteLine("Devamsızlık girin ");
                devam = Convert.ToInt16(Console.ReadLine());

                if (devam < 5)
                { 

                    Console.WriteLine("kaldığı ders sayısını girin ");
                    kd = Convert.ToInt16(Console.ReadLine());
                    if (kd > 0)
                        Console.WriteLine("belge alamaz");
                    else if ((kd == 0) && (ort > 85))
                        Console.WriteLine("takdir alabilir");
                    else if ((kd == 0) && (ort > 75))
                        Console.WriteLine("teşekkür alabilir");
                    else if ((ort >50) && (ort <74))
                        Console.WriteLine("geçti");
                }
                else
                    Console.WriteLine("belge alamaz ");

            }

            else
                Console.WriteLine("kaldı");

            Console.ReadKey();

            */

            /*
            int ort, zayıf;
            Console.WriteLine("ortalamanızı giriniz ");
            ort = Convert.ToInt16(Console.ReadLine());


            if (ort >= 50)
            {

                Console.WriteLine("zayıf girin ");
                zayıf = Convert.ToInt16(Console.ReadLine());

                if (zayıf == 0)
                {
                    Console.WriteLine("geçti");


                }
                else if (zayıf <= 3)
                    Console.WriteLine("sorumlu geçti");
                else
                    Console.WriteLine("kaldı ");

            }

            else
                Console.WriteLine("kaldı");

            Console.ReadKey();
            */



            /*
            int s1,s2,snc;
            string islem;
            Console.WriteLine("---------------");
            Console.WriteLine(" 1 - Toplama   ");
            Console.WriteLine(" 2 - Çıkarma   ");
            Console.WriteLine(" 3 - Çarpma    ");
            Console.WriteLine(" 4 - Bölme     ");
            Console.WriteLine(" 5 - Mod alma  ");
            Console.WriteLine(" 6 - Kare Kök  ");
            Console.WriteLine("---------------");
            Console.WriteLine("işlem seçiniz");

            islem = Console.ReadLine();


            if (islem == "1")
            {
                Console.WriteLine("s1 giriniz:  ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("s2 giriniz:  ");
                s2 = Convert.ToInt32(Console.ReadLine());

                snc = s1 + s2;

                Console.WriteLine("{0} + {1} = {2}", s1, s2, snc);
            }

            else if (islem == "2")
            {
                Console.WriteLine("s1 giriniz:  ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("s2 giriniz:  ");
                s2 = Convert.ToInt32(Console.ReadLine());

                snc = s1 - s2;

                Console.WriteLine("{0} - {1} = {2}", s1, s2, snc);
            }

            else if (islem == "3")
            {
                Console.WriteLine("s1 giriniz:  ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("s2 giriniz:  ");
                s2 = Convert.ToInt32(Console.ReadLine());

                snc = s1 * s2;

                Console.WriteLine("{0} * {1} = {2}", s1, s2, snc);
            }

            else if (islem == "4")
            {
                Console.WriteLine("s1 giriniz:  ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("s2 giriniz:  ");
                s2 = Convert.ToInt32(Console.ReadLine());
                if (s2 != 0 && s1 != 0)
                {
                    snc = s1 / s2;

                    Console.WriteLine("{0} / {1} = {2}", s1, s2, snc);
                }
                else
                    Console.WriteLine("sıfıra bölünmez!");

            }


            else if (islem == "5")
            {
                Console.WriteLine("s1 giriniz:  ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("s2 giriniz:  ");
                s2 = Convert.ToInt32(Console.ReadLine());

                    snc = s1 % s2;

                    Console.WriteLine("{0} % {1} = {2}", s1, s2, snc);

            }

            else if (islem == "6")
            {
                double sayi,sonuc;
                Console.WriteLine("s1 giriniz:  ");
                sayi = Convert.ToInt32(Console.ReadLine());
                sonuc=Math.Sqrt(sayi);


                Console.WriteLine("{0} Kökü {1} ", sayi,sonuc);
            }
            else Console.WriteLine("");
            Console.ReadKey();


            */


            /*
            string mevsim;
            MevsimGir:
            Console.WriteLine("Mevsim Giriniz");
            mevsim = Console.ReadLine();

            switch (mevsim)
              {
                case "yaz":
                    {
                        Console.WriteLine("Haziran,Temmuz,Agustos");
                        break;
                    }
                case "kış":
                    {
                        Console.WriteLine("Aralık,Ocak,Şubat");
                        break;
                    }
                case "İlkbahar":
                    {
                        Console.WriteLine("Mart,Nisan,Mayıs");
                        break;
                    }
                case "sonbahar":
                    {
                        Console.WriteLine("Eylül,Ekim,Kasım");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Yanlış seçim yaptınız");
                        goto MevsimGir;
                        // break;
                    }
               }
            Console.ReadKey();
            */



            /*
            string gunler;
        gunlergir:
            Console.WriteLine("Bir giriniz");
            gunler = Console.ReadLine();
            switch (gunler)
            {
                case ("1"):
                    {
                        Console.WriteLine("Pazartesi");
                        break;

                    }
                case ("2"):
                    {
                        Console.WriteLine("salı");
                        break;
                    }
                case ("3"):
                    {
                        Console.WriteLine("çarşamba");
                        break;
                    }
                case ("4"):
                    {
                        Console.WriteLine("perşembe");
                        break;
                    }
                case ("5"):
                    {
                        Console.WriteLine("cuma");
                        break;
                    }
                case ("6"):
                    {
                        Console.WriteLine("cumartesi");
                        break;
                    }
                case ("7"):
                    {
                        Console.WriteLine("pazar");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("1-7 arası gün giriniz");
                        goto gunlergir;

                    }



            }

            Console.ReadKey();
            */




            /*
           İslemGir:
               int s1, s2, snc;
               string islem;
               Console.WriteLine("---------------");
               Console.WriteLine(" 1 - Toplama   ");
               Console.WriteLine(" 2 - Çıkarma   ");
               Console.WriteLine(" 3 - Çarpma    ");
               Console.WriteLine(" 4 - Bölme     ");
               Console.WriteLine(" 5 - Mod alma  ");
               Console.WriteLine(" 6 - Kare Kök  ");
               Console.WriteLine("---------------");
               Console.WriteLine("işlem seçiniz");
               islem = Console.ReadLine();


               switch (islem)
               {
                   case "1":

                       Console.WriteLine("1.sayıyı giriniz");
                       s1 = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("2.sayıyı giriniz");
                       s2 = Convert.ToInt16(Console.Read());

                       snc = s1 + s2;

                       Console.WriteLine("{0} + {1} = {2}", s1,s2, snc);
                       break;
                   case "2":

                       Console.WriteLine("1.sayıyı giriniz");
                       s1 = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("2.sayıyı giriniz");
                       s2 = Convert.ToInt16(Console.Read());

                       snc = s1 - s2;

                       Console.WriteLine("{0} - {1} = {2}", s1, s2, snc);
                       break;
                   case "3":

                       Console.WriteLine("1.sayıyı giriniz");
                       s1 = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("2.sayıyı giriniz");
                       s2 = Convert.ToInt16(Console.Read());

                       snc = s1 * s2;

                       Console.WriteLine("{0} * {1} = {2}", s1, s2, snc);
                       break;
                   case "4":

                       Console.WriteLine("1.sayıyı giriniz");
                       s1 = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("2.sayıyı giriniz");
                       s2 = Convert.ToInt16(Console.Read());

                       snc = s1 + s2;

                       Console.WriteLine("{0} + {1} = {2}", s1, s2, snc);
                       break;
                   case "5":

                       Console.WriteLine("s1 giriniz:  ");
                       s1 = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine("s2 giriniz:  ");
                       s2 = Convert.ToInt32(Console.ReadLine());

                       snc = s1 % s2;

                       Console.WriteLine("{0} % {1} = {2}", s1, s2, snc);
                       break;
                   case "6":
                       double sayi, sonuc;
                       Console.WriteLine("s1 giriniz:  ");
                       sayi = Convert.ToInt32(Console.ReadLine());
                       sonuc = Math.Sqrt(sayi);
                       Console.WriteLine("{0} Kökü {1} ", sayi, sonuc);
                       break;
                   default:
                       {
                           Console.WriteLine("Yanlış işlem girdiniz");
                           goto İslemGir;

                       }

               }


               Console.ReadKey();



               */


            /*
                İslemGir:
                    int s1, s2, snc;
                    string islem;
                    Console.WriteLine("---------------");
                    Console.WriteLine(" 1 - Kare      ");
                    Console.WriteLine(" 2 - Küp       ");
                    Console.WriteLine(" 3 - Kare Kök  ");
                    Console.WriteLine(" 4 - Üs Alma   ");
                    Console.WriteLine(" 5 - Mod Alma  ");
                    Console.WriteLine("---------------");
                    Console.WriteLine("işlem seçiniz");
                    islem = Console.ReadLine();


                    switch (islem)
                    {
                        case "1":  //kare

                            Console.WriteLine("1.sayıyı giriniz");
                            s1 = Convert.ToInt16(Console.ReadLine()); 

                            snc = s1*s1;

                            Console.WriteLine( snc);
                            break;
                        case "2": // küp

                            Console.WriteLine("1.sayıyı giriniz");
                            s1 = Convert.ToInt16(Console.ReadLine());

                            snc = s1*s1*s1;

                            Console.WriteLine( snc);
                            break;
                        case "3":  //kare kök

                            double sayi, sonuc;
                            Console.WriteLine("s1 giriniz:  ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                            sonuc = Math.Sqrt(sayi);
                            Console.WriteLine("{0} Kökü {1} ", sayi, sonuc);
                            break;

                        case "4":  //üs alma

                            double taban,us;
                            Console.WriteLine("s1 giriniz:  ");
                            taban = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("üs giriniz:  ");
                            us = Convert.ToDouble(Console.ReadLine());
                            sonuc = Math.Pow(taban,us);
                            Console.WriteLine(sonuc);
                            break; 
                        case "5":  //mod alma

                            Console.WriteLine("s1 giriniz:  ");
                            s1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("s2 giriniz:  ");
                            s2 = Convert.ToInt32(Console.ReadLine());

                            snc = s1 % s2;

                            Console.WriteLine("{0} % {1} = {2}", s1, s2, snc);
                            break;

                        default:
                            {
                                Console.WriteLine("Yanlış işlem girdiniz");
                                goto İslemGir;

                            }

                    }


                    Console.ReadKey();
                        */


            /*
        İslemGir:
            int yukseklik, snc;
            double pi = 3.14;
            string islem;
            Console.WriteLine("-------------------");
            Console.WriteLine(" 1 - Üçgen alan    ");
            Console.WriteLine(" 2 - Üçgen çevre   ");
            Console.WriteLine(" 3 - Kare alan     ");
            Console.WriteLine(" 4 - Kare çevre    ");
            Console.WriteLine(" 5 - Daire alan    ");
            Console.WriteLine(" 6 - Daire çevre   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("işlem seçiniz");
            islem = Console.ReadLine();


            switch (islem)
            {
                case "1":  //üçgenin alanı
                    int taban;
                    Console.WriteLine("taban sayısını giriniz");
                    taban = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("yükseklik sayısını giriniz");
                    yukseklik = Convert.ToInt16(Console.ReadLine());

                    snc = ((taban * yukseklik) / 2);

                    Console.WriteLine(snc);
                    break;
                case "2":  //üçgenin çevresi
                    int uzunluk1, uzunluk2, uzunluk3;
                    Console.WriteLine("1.uzunluk giriniz");
                    uzunluk1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("2.uzunluk giriniz");
                    uzunluk2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("3.uzunluk giriniz");
                    uzunluk3 = Convert.ToInt32(Console.ReadLine());

                    snc = uzunluk1 + uzunluk2 + uzunluk3;

                    Console.WriteLine(snc);
                    break;
                case "3":  //kare alanı

                    Console.WriteLine("1.uzunluk giriniz");
                    uzunluk1 = Convert.ToInt32(Console.ReadLine());


                    snc=uzunluk1*uzunluk1;
                    Console.WriteLine(snc);
                    break;

                case "4":  //kare çevresi

                    Console.WriteLine("1.uzunluk giriniz");
                    uzunluk1 = Convert.ToInt32(Console.ReadLine());


                    snc = uzunluk1 +uzunluk1+uzunluk1+uzunluk1;
                    Console.WriteLine(snc);
                    break;
                case "5":  //daire alan

                    double r;
                    Console.WriteLine("Yarı çapı giriniz");
                    r = Convert.ToDouble(Console.ReadLine());

                    snc = (int)(pi * (r * r));

                    Console.WriteLine(snc);
                    break;

                case "6":  //daire çevre

                    Console.WriteLine("Yarı çapı giriniz");
                    r = Convert.ToDouble(Console.ReadLine());

                    snc = (int)(2 *pi*r);

                    Console.WriteLine(snc);
                    break;

                default:
                    {
                        Console.WriteLine("Yanlış işlem girdiniz");
                        goto İslemGir;

                    }

            }


            Console.ReadKey();

            */


            /*
            for (int a = 1; a <= 5; a++)
                Console.WriteLine(a + ".Merhaba");

            Console.ReadKey();
            */

            /*
            for (int a = 2; a <= 10; a=a+3)
                Console.WriteLine(a + ".Merhaba");

            Console.ReadKey();
            */

            /*
            for (int a = 1; a <= 7; a++)
                Console.WriteLine(a + "Sabahattin Akal");

            Console.ReadKey();
            */


            /*
            for (int a = 1; a <= 10; a++)
                Console.Write(" " + a);

            Console.ReadKey();
            */

            /*
            for (int a = 10; a >= 1; a--)
                Console.Write(" " + a);

            Console.ReadKey();
            */


            /*
            string isim;
            Console.WriteLine("İsim giriniz");
            isim = Console.ReadLine();

            for (int a = 1; a <= 10; a++)
                Console.WriteLine(" " + isim);

            Console.ReadKey();
            */


            /*
            string isim;
            int b;
            Console.WriteLine("İsim giriniz");
            isim = Console.ReadLine();

            Console.WriteLine("Bitiş giriniz");
            b = Convert.ToInt16(Console.ReadLine());

            for (int a = 1; a <= b; a++)
                Console.WriteLine(" " + isim);

            Console.ReadKey();
            */

            /*
            string isim;
            int b,c,d;
            Console.WriteLine("İsim giriniz");
            isim = Console.ReadLine();

            Console.WriteLine("Başlangıç giriniz");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Bitiş giriniz");
            c = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Artış giriniz");
            d = Convert.ToInt16(Console.ReadLine());

            for (int a = b; a <= c; a=a+d)
            {
                Console.WriteLine(a+" " + isim);
            }

            Console.ReadKey();
            */



            /*
            int top=0;

            for (int a = 1; a <= 10; a++ )
            {
                
                Console.WriteLine(a);
                top = top + a;
                
            }
            Console.WriteLine("toplam: "+top);
            Console.ReadKey();

            */





            /*
            int sayi,fak = 1;
            
            Console.WriteLine("sayi giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
                fak = fak * i;
                
            
                Console.WriteLine("faktöriyel: " + fak);
            

            
            Console.ReadKey();
            
            */


            /*
            int taban, us,snc=1;
            Console.WriteLine("taban gir");
            taban = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("üs gir");
            us = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= us; i++)
                snc = snc * taban;

            Console.WriteLine(snc);
           */



            /*
            int snc = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    snc = Convert.ToInt16(snc+i);

                    

                }
                else
                    Console.Write("");
                
                
            }
            Console.WriteLine(snc);
            */




            /*
            string metin="iomtal";


            for (int i = 1; i <= metin.Length; i++)
            {
                Console.WriteLine(metin.Substring(0, i));

            }




            for (int x = 0; x <= metin.Length; x++)
            {

               
                Console.WriteLine(metin.Substring(x));

            }
            
            Console.ReadLine();
            */


            /*
            for( int x = 1; x <= 3; x++)
            {
                for (int y = 1; y <= 5; y++)
                    Console.Write(y);
                Console.WriteLine();

            }

            */

            /*
            for (int x = 1; x <= 3; x++)
            {
                for (int y = 1; y <= 5; y++)
                    Console.Write("\t *");
                Console.WriteLine();

            }
            */


            /*
            string isim;
            isim = Console.ReadLine();

            for (int x = 0; x <= isim.Length; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    
                    Console.Write(isim[x]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
            */




            /*
            int i = 1;
            Random rdn = new Random();
            int rastgele = rdn.Next(0, 10);
            while (true)
            {
                Console.Write("Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == rastgele)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i + ". tahmininizde sayıyı buldunuz.");
            Console.ReadKey();
            */







            //while ile faktöriyel
            /*
            int sayi, snc = 1;

            Console.WriteLine("Sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi > 0)

            {
                snc = sayi * snc;
                sayi--;
            }
            Console.WriteLine("Faktoriyel:" + snc);
            Console.ReadKey();
            */

            /*
            int sayi, snc = 1;

            Console.WriteLine("Sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i>=sayi;i++)   
            {
                snc = sayi * snc;
                
            }
            Console.WriteLine("Faktoriyel:" + snc);
            Console.ReadKey();
            */

            /*
            int sayi=1;
            string ad;
            Console.WriteLine("ad gir");
            ad = Console.ReadLine();
            while (sayi<=10)
            {
                
                Console.WriteLine(sayi + " " + ad);
                sayi++;
            }
            Console.ReadKey();
            */




            /*
            string parola = "";

            while(parola!="abc123")
            {
                Console.WriteLine("parola gir");
                parola = Console.ReadLine();

            }
            Console.ReadKey();
            */


            /*
            int sayi, sayi2;
            sayi = 1;

            Console.WriteLine("Sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            while (sayi == 0)
            {
                

                int toplam;
                toplam = sayi + sayi2;

                if (sayi==0)


            }

            Console.ReadKey();
            */




            /*
            string cevap = "";
            int sayi1, sayi2, snc = 0;

            while(cevap.ToUpper() != "e")
            {
                Console.WriteLine("Sayi1 gir: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayi2 gir: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                snc = sayi1 + sayi2;

                Console.WriteLine("Toplam: " + snc);
                Console.WriteLine("Çıkmak istiyor musunuz?");
                cevap = Console.ReadLine();

            }
            */




            //1 ile 100 arasında girilen sayıları toplayan program.
            /*
            int toplam = 0;

            Console.WriteLine("1 ile 100 arasında girilen sayıları toplayan program.");
            Console.WriteLine("Toplamın sonucunu görmek için 0(sıfır)gir.");

            while (true)

            {
                Console.WriteLine("Sayı:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                    break;
                if (sayi <= 0 && sayi > 100)
                {
                    Console.WriteLine("Sayı 1 ve 100 arasında olmalı");
                    continue;
                }
                toplam = toplam + sayi;
            }
            Console.WriteLine("Toplam:" + toplam);
            Console.ReadKey();
            */

            /*
            int toplam=1;
            int sayi=1;

            while (sayi <= 0 && sayi > 100)

            {
                sayi= 
                toplam = toplam + sayi;
            }
            Console.WriteLine("Toplam:" + toplam);
            Console.ReadKey();
            */



            /*
            int sayi = 1;

            int snc=0;
            
            while (sayi <= 100)
            {
                snc = sayi + snc;
                Console.WriteLine(sayi);

                sayi++;
            }
            Console.WriteLine(snc);
            Console.ReadKey();
            */


            /*
            int sayaç=0;

            

            while (true)

            {
                Console.WriteLine("Sayı:");
                int sayi = Convert.ToInt32(Console.ReadLine());


                if (sayi == 0)
                    break;


                
                

                sayaç = sayi;
                Console.WriteLine("girilen sayı = " + sayaç);

            }
            Console.WriteLine("işlem sonlandırıldı");
            

            Console.ReadKey();

            */

            /*
            int sayi=1;

            while (true)
            {
                if(sayi == 11)
                {
                    break;
                }
                Console.WriteLine(sayi);
                sayi++;

            }
            Console.ReadKey();

            */




            /*
            int sayi, snc = 1;

            Console.WriteLine("Sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi > 0)

            {
                snc = sayi * snc;
                sayi--;
            }
            Console.WriteLine("Faktoriyel:" + snc);
            Console.ReadKey();
            */


            /*
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
            Console.ReadKey();
            
            */



            /*
            string kullanıcı,parola;
            
            do


            { 
                Console.WriteLine("Kullanıcı adı gir");
                kullanıcı= Console.ReadLine();

                Console.WriteLine("Parola gir");
                parola = Console.ReadLine();

            }

            while (kullanıcı != "eplc" || parola != "edit");
            Console.WriteLine("İşlem onaylandı");

            Console.ReadKey();

            */


            /*
            int sayi, toplam = 0;

            do


            {
                Console.WriteLine("sayı gir");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;

                if (sayi < 0)
                    break;

            }

            while (sayi >= 0);
            Console.WriteLine(toplam);


            Console.ReadKey();
            */


            //kullanıcı sıfır girene kadar girdiği
            //çift sayıların kaç tane olduğunu ekrana yazdıran program

            // int sayi, toplam = 0;


            /*
            int sayi, çift = 0,sayaç=0;

            do
            {
                Console.WriteLine("sayı girin");
                sayi = Convert.ToInt32(Console.ReadLine());
                

                if (sayi <= 0)
                {
                    break;
                }
                else if(sayi%2==0)
                
                sayaç++;


            }
            
            while (true);
            
            Console.WriteLine("Çift sayıların adeti=" + sayaç);
            



            Console.ReadKey();

            */


            //klavyeden 0 girilene kadar girilen, sayılardan çift sayıları toplayan 
            //tek sayıları çıkaran ve sonucu ekrana yazdır





            /*
            int sayi, çift = 0, tek = 0, snc = 0;

            while (true) 
            {

                Console.WriteLine("sayı girin");
                sayi = Convert.ToInt32(Console.ReadLine());


                if (sayi == 0)
                {
                    break;
                }
                else if (sayi % 2 == 0)

                    çift = sayi+çift;

                else if (sayi % 2 == 1)
                    tek = (sayi)+(tek);
                snc = çift - tek;

                
                
            }





            
            Console.WriteLine("tek sayıların adeti=" + snc);

            Console.ReadKey();
            */

            //alt alta sayıların karesini ve küpünü yazdırma
            //---------------------------------------
            /*
            Console.Write("sayılar"+"\t"+"karesi"+"\t"+"küp");
            for (int a = 1; a <= 10; a++)
            {
                Console.Write("\n" + a+"\t"+a*a+ "\t" +a*a*a+ "\t" );    
            }
            Console.ReadKey();
            */



            //---------------------------------------
            //alt alta sayıların karesini ve küpünü yazdırma (while)


            /*
            int sayi = 1;

            while (sayi<=10)
            {
                Console.WriteLine(sayi + "\t" + sayi * sayi + "\t" + sayi * sayi * sayi);
                sayi++;
            }
            Console.ReadKey();

            */



            //---------------------------------------
            // kullanıcının istediği ismi istediği kadar yazdıran program


            /*
            int b;
            string aa;
            Console.WriteLine("isim gir");
            aa = Console.ReadLine();
            Console.WriteLine("tekrar sayı gir");
            b = Convert.ToInt16(Console.ReadLine());

            for (int a = 1; a <= b; a++)
            {
                Console.WriteLine(a+" "+ aa);
            }
            Console.ReadKey();
            */

            //---------------------------------------
            // kullanıcının istediği ismi istediği kadar yazdıran program(while)

            /*
            int kere, sayaç = 1;
            string metin;

            Console.Write("Metin girin: ");
            metin = Console.ReadLine();
            Console.Write("kaç kere tekrarlansın: ");
            kere = Convert.ToInt16(Console.ReadLine());

            while(sayaç<= kere)
            {
                Console.WriteLine(sayaç + " " + metin);
                sayaç++;
            }
            Console.ReadKey();
            */







            //---------------------------------------
            // on öğrencinin not ortalaması(while)
            /*
            int not, top = 0,i=1;
            while(i<=10)
            {
                Console.Write("not gir");
                not = Convert.ToInt32(Console.ReadLine());
                top = top + not;
                i++;
            }
            Console.WriteLine("Ortalaması: " + (top / 10));
            Console.ReadKey();
            */

            //---------------------------------------
            //girilen sayıların  çift sayıların toplamını ve adetini , tek sayıların farkını ve adetini 

            /*
            int sayi, çift = 0, tek = 0, snc,sayac=0,sayac1=0;

            while (true)
            {

                Console.WriteLine("sayı girin");
                sayi = Convert.ToInt32(Console.ReadLine());


                if (sayi == 0)
                {
                    break;
                }
                else if (sayi % 2 == 0)
                {
                    çift = sayi + çift;
                    sayac++;

                }
                    
                

                else if (sayi % 2 == 1)
                {
                    tek = (sayi) - (tek);
                    sayac1++;


                }
                    


            }
            Console.WriteLine(çift);
            Console.WriteLine(tek);
            Console.WriteLine(sayac);
            Console.WriteLine(sayac1);
            Console.ReadKey();
            */


            //---------------------------------------
            //7 ile 85 arasındaki çift sayıların toplamını ve adetini , tek sayıların farkını ve adetini
            /*
            int i, ciftsayi = 0, teksayi = 0, toplam = 0, fark = 0;
            for (i = 7; i <= 85; i++) 
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                    ciftsayi++;
                }
            else if (i%2!=0)
                {
                    fark = i + fark;
                    teksayi++;

                }
            Console.WriteLine("Çift sayıların toplamı " + toplam);
            Console.WriteLine("Çift sayıların adeti " + ciftsayi);
            Console.WriteLine("Tek sayıların toplamı " + fark);
            Console.WriteLine("Tek sayıların adeti " + teksayi);
            Console.ReadKey();
            */


            //---------------------------------------
            //7 ile 85 arasındaki çift sayıların toplamını ve adetini , tek sayıların farkını ve adetini(while)


            /*
            int i =7, ciftsayi = 0, teksayi = 0, toplam = 0, fark = 0;
            while (i <= 85)
            {

            
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                    ciftsayi++;
                }
                else if (i % 2 != 0)
                {
                    fark = i + fark;
                    teksayi++;

                }
                i++;
            }
            
            Console.WriteLine("Çift sayıların toplamı " + toplam);
            Console.WriteLine("Çift sayıların adeti " + ciftsayi);
            Console.WriteLine("Tek sayıların toplamı " + fark);
            Console.WriteLine("Tek sayıların adeti " + teksayi);
            Console.ReadKey();
            */

            //---------------------------------------
            //klavyeden girilen 5 sayıdan en küçüğünü bulan program

            /*
            int sayi,enk;
            Console.WriteLine("sayı giriniz");
            

            enk = sayi;
            
           for(int i=2;i<=5;i++)
            {
                Console.WriteLine("sayi giriniz");
                sayi = Convert.ToInt16(Console.ReadLine());

                if (sayi < enk)
                    enk = sayi;
            }
            Console.WriteLine(enk);
            Console.ReadKey();
            */


            //---------------------------------------
            //klavyeden girilen 5 sayıdan en küçüğünü bulan program  (WHİLE)



            /*
            int sayi, enk,i;
            Console.WriteLine("sayı giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());

            enk = sayi;
            i = 2;
            while (i <= 5)
            {
                Console.WriteLine("sayi giriniz");
                sayi = Convert.ToInt16(Console.ReadLine());

                if (sayi < enk)
                    enk = sayi;
                i++;
            }
            Console.WriteLine(enk);
            Console.ReadKey();
            */

            /*
            int[] sayilar = { 1, 2, 3, 4, 7 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();
            */


            /*
            int[] sayi = new int[5];
            sayi[0] = 5;
            sayi[1] = 9;
            sayi[2] = 82;
            sayi[3] = 55;
            sayi[4] = 88;
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
            }
            Console.ReadKey();
            */


            /*
            int[] sayilar = { 1, 2, 3, 4, 7 };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
            */

            /*
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            foreach(string i in gunler)
            Console.WriteLine(i);
            Console.ReadKey();
            */


            /*
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            int gun;
            Console.WriteLine("Kaçıncı gün?");
            gun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Haftanın "+gun+". günü "+gunler[gun-1]);
            Console.ReadKey();

            */


            /*
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string aranGun;
            aranGun =Console.ReadLine();

            for (int a = 0; a < gunler.Length; a++) 
            {
                if (gunler[a] == aranGun)
                    Console.WriteLine((a + 1) + ". günüdür");


                
                    
            }
            
            Console.ReadKey();
            */

            
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string aranGun;
            int sayaç=1;
            Console.WriteLine("Hangi Gün? ");
            aranGun = Console.ReadLine();

            foreach (string ara in gunler)
            {
                if (ara == aranGun)
                Console.WriteLine(sayaç);
                sayaç++;
            }

            Console.ReadKey();
            

            /*
            int mevcut;
            
            
            Console.WriteLine("Sınıf mevcudu girin: ");
            mevcut = Convert.ToInt16(Console.ReadLine());
            string[] isimler = new string[mevcut];
            
            int a;
            for(a= 0; a < isimler.Length; a++)
            {
                Console.WriteLine("{0} Öğrencinin ismini girin: ", a + 1);
                isimler[a] = Console.ReadLine();

                


            }
            foreach (string isim in isimler)
                
            Console.WriteLine("Girilen isimler: " +isim);



            Console.ReadKey();
            */

            //klavyeden girilen 5 sayının en büyüğü



            /*
            int[] sayilar = new int[5];
            int enb = 0;
            for (int a = 0; a < sayilar.Length; a++)
            {
                Console.WriteLine("{0}Sayı gir: ",a+1);
                sayilar[a] = Convert.ToInt16(Console.ReadLine());
                
            }
            foreach (int say in sayilar)
            {
                if (say > enb)
                    enb = say;
            }
            Console.WriteLine(enb);
            Console.ReadKey();
            */


            /*
            int[,] küme = new int[2, 3];
            int t1 = 0, t2 = 0, t3 = 0, t4 = 0, sayaç = 0, sayaç2 = 0, sayaç3 = 0, sayaç4=0,sayaç5=0;
            küme[0, 0] = Convert.ToInt32(Console.ReadLine());
            küme[0, 1] = Convert.ToInt32(Console.ReadLine());
            küme[0, 2] = Convert.ToInt32(Console.ReadLine());


            küme[1, 0] = Convert.ToInt32(Console.ReadLine());
            küme[1, 1] = Convert.ToInt32(Console.ReadLine());
            küme[1, 2] = Convert.ToInt32(Console.ReadLine());

            foreach (var sayi in küme)
            {
                Console.WriteLine("---------------------------");
                if (sayi%2==0&&sayi>0)
                {
                    Console.WriteLine(sayi+"=Pozitif çift sayı");
                    
                    t1 = t1 + sayi;
                    sayaç++;
                }

                else if (sayi % 2 == 1&&sayi>0)
                {
                    Console.WriteLine(sayi+"=Pozitif tek sayı");

                    t2 = t2 + sayi;
                    sayaç2++;
                }
                else if(sayi%2==0&&sayi<0)
                {
                    Console.WriteLine(sayi+"=Negatif çift sayı");

                    t3 = t3 + sayi;
                    sayaç3++;
                }
                else if(sayi%2==-1&&sayi<0)
                {
                    Console.WriteLine(sayi+"=Negatif tek sayı");

                    t4 = t4 + sayi;
                    sayaç4++;
                }
                else if(sayi==0)
                {
                    Console.WriteLine(sayi + "=Sayı sıfır");

                    sayaç5++;
                }


            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("pozitif çift sayıların toplamı =" + t1);
            Console.WriteLine("pozitif çift sayıların adeti=" + sayaç);
            Console.WriteLine("---------------------------");
            Console.WriteLine("pozitif tek sayıların toplamı=" + t2);
            Console.WriteLine("pozitif tek sayıların adeti=" + sayaç2);
            Console.WriteLine("---------------------------");
            Console.WriteLine("negatif çift sayıların toplamı =" + t3);
            Console.WriteLine("negatif çift sayıların adeti=" + sayaç3);
            Console.WriteLine("---------------------------");
            Console.WriteLine("negatif tek sayıların toplamı=" + t4);
            Console.WriteLine("negatif tek sayıların adeti=" + sayaç4);
            Console.WriteLine("---------------------------");
            Console.WriteLine("sıfır sayıların adeti=" + sayaç5);

            Console.ReadKey();
            */
            /*
            int[] küme = new int[10];
            int sayaç1 = 0, sayaç2 = 0;
            küme[0] = Convert.ToInt32(Console.ReadLine());
            küme[1] = Convert.ToInt32(Console.ReadLine());
            küme[2] = Convert.ToInt32(Console.ReadLine());
            küme[3] = Convert.ToInt32(Console.ReadLine());
            küme[4] = Convert.ToInt32(Console.ReadLine());
            küme[5] = Convert.ToInt32(Console.ReadLine());
            küme[6] = Convert.ToInt32(Console.ReadLine());
            küme[7] = Convert.ToInt32(Console.ReadLine());
            küme[8] = Convert.ToInt32(Console.ReadLine());
            küme[9] = Convert.ToInt32(Console.ReadLine());


            foreach (var sayi in küme)
            {
                if(sayi%2==0)
                {
                    Console.WriteLine(sayi + "=Sayı çift");
                    sayaç1++;
                }

                else if (sayi % 2 == 1)
                {
                    Console.WriteLine(sayi + "=Sayı Tek");
                    sayaç2++;
                }



            }

            Console.WriteLine("----------------------");
            Console.WriteLine("Çift sayıların adeti=" + sayaç1);
            Console.WriteLine("----------------------");
            Console.WriteLine("Tek sayıların adeti=" + sayaç2);
            Console.ReadKey();
            */




            /*
            string metin;
            metin = Console.ReadLine();

            int sayaç1 = 0;
            foreach (char karakter in metin)
            {
                if (karakter == ' ')
                {
                    sayaç1++;
                }

            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("adet kelime vardır=" + sayaç1);
            Console.ReadKey();

            */


            
             /*
            string metin;
            metin = Console.ReadLine();

            int sayaç1 = 1;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == ' ' && metin[i - 1] != ' ')
                    sayaç1++;
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("adet kelime vardır=" + sayaç1);
            Console.ReadKey();
             */
            



            
            /*
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };

            int sayaç = 0;
            string metin;
            Console.WriteLine("metin giriniz");
            metin = Console.ReadLine();

            foreach (char karakter in metin)
            {
                foreach (char sesli in sesliler)
                {

                    if (karakter == sesli)
                    {
                        Console.WriteLine(karakter);
                        sayaç++;
                    }
                        
                }
            }
            Console.WriteLine(sayaç + "adet sesli harf vardır");

            Console.ReadKey();
            */

            /*
           string[]birlik= { "Bir","İki","Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"};
           string[]onluk= { "On","Yirmi","Otuz","Kırk","Elli","Altmış","Yetmiş","Seksen","Doksan"};
           string[]yüzlük= { "Yüz" ,"İkiyüz","Üçyüz","Dörtyüz","Beşyüz","Altıyüz","Yediyüz","Sekizyüz","Dokuzyüz"};
           string[]binlik= { "bin","ikibin","üçbin","dörtbin","beşbin","altıbin","yedibin","sekizbin"};

            long sayi, birler, onlar, yuzler, binler;

            Console.WriteLine("Sayı giriniz: ");
            sayi = Convert.ToInt64(Console.ReadLine());

            birler = sayi % 10;
            onlar = (sayi / 10) % 10;
            yuzler = (sayi / 100) % 10;
            binler = (sayi / 1000) % 10;

            Console.WriteLine(binlik[binler - 1] + " " + yüzlük[yuzler - 1] + " " + onluk[onlar - 1] + " " + birlik[birler - 1]);
            Console.ReadKey();
            */

            /*
            int[] sayi = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sayi[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int say in sayi)
            {
                Console.WriteLine(say);
            }
            Console.ReadKey();
            */
        }


    }

}

