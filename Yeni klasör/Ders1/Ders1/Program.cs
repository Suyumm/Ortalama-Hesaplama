using System;
using System.Security.Cryptography.X509Certificates;

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


        }
    }
}