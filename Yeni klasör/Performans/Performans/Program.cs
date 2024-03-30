using System;

namespace Performans
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9 do while(if else + else if+diziler) + 1 switch case

            //1-kullanıcının girdiği sayıya kadar not alıp kaldı geçti durumunu yazan program

            //---------------------------------------------------------------
            
            /*
            int i;
            Console.WriteLine("Kaç adet not girilsin?");
            Console.WriteLine("------------------------");
            i = Convert.ToInt32(Console.ReadLine());
            Double not, sayac = 0;
            do
            {
                Console.WriteLine("{0}. notu giriniz", sayac + 1);
                not = Convert.ToInt32(Console.ReadLine());
                if ((not >= 50) && (not <= 100))
                    Console.WriteLine("Geçti");
            
                else if(not>=0 && not<50)
                    Console.WriteLine("Kaldı");
                  else
                    Console.WriteLine("Geçersiz not girdiniz!");       
                sayac++;
            }
            while (sayac < i);
            Console.ReadKey();
            */

            //---------------------------------------------------------------

            //2-Girilen 5 sayının negatif ve pozitif sayıların adedini hesaplayan program

            //---------------------------------------------------------------

            /*
            int sayi,cift=0,tek=0,a=0;
            do
            {
                Console.WriteLine("{0}. sayıyı giriniz", sayac + 1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayac++;
                if (sayi % 2 == 0)
                {
                    cift++;
                }
                else
                    tek++;
            }
            while (sayac< 5);
            Console.WriteLine("Çift sayıların adedi: {0}",cift);
            Console.WriteLine("Tek sayıların adedi: {0}", tek);
            */

            //---------------------------------------------------------------

            //3-Kullanıcının girdiği 10 sayıdan 30'dan büyük ve ya 3'e kalansız bölünebilen sayıların adedini ekrana yazdıran program

            //---------------------------------------------------------------

            /*
            int sayi, sayac = 0, sayac2 = 0;
            do
            {
                Console.WriteLine("{0}. sayıyı giriniz",sayac2+1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayac2++;
                if (sayi > 30 || sayi % 3 == 0)
                {
                    sayac++;
           int     }
            }while (sayac2 < 10);
            Console.WriteLine("30 dan büyük ve 3 e kalansız bölünen sayıların adedi: {0}",sayac);
            */

            //---------------------------------------------------------------

            //4-Üslü sayı hesaplayan program (math.pow kullanmadan)

            //---------------------------------------------------------------

            /*
            int taban, us, sonuc = 1,sayac=0;
            Console.WriteLine("Lütfen taban sayısını giriniz");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kuvveti giriniz");
            us = Convert.ToInt32(Console.ReadLine());
            
            do
            {
                sonuc = sonuc * taban;
                sayac++;
            } while (sayac < us);

            Console.WriteLine("{0} sayısının {1}.kuvvetinin sonucu = {2}", taban, us, sonuc);

            Console.ReadLine();
            */
            

            //5-Kullanıcının girdiği sayı kadar sayı alıp çiftleri toplayan tekleri çıkaran program

            //---------------------------------------------------------------

            /*
            int s1, s2, toplam = 0, carp = 1, sayac = 0;
            Console.Write("Kaç adet sayı girilecek? ");
            s1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("{0}. sayıyı giriniz: ", sayac + 1);
                s2 = Convert.ToInt32(Console.ReadLine());
                if (s2 % 2 == 0)
                    toplam = s2 + toplam;
                else
                    carp = s2 * carp;
                sayac++;
            }
            while (sayac < s1);
            Console.WriteLine("Çift sayıların toplamı: {0}", toplam);
            Console.WriteLine("Tek sayıların çarpımı: {0}", carp);
            */

            //---------------------------------------------------------------

            //6-kullanıcının başlangıç ve bitiş sayısı arasındaki sayıların karesini alan program

            //---------------------------------------------------------------

            /*
            int s1, s2,sayac,snc=1;
            Console.WriteLine("Başlangıç sayısını giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş sayısını giriniz");
            s2 = Convert.ToInt32(Console.ReadLine());
            sayac = s1;
            do
            {
                snc = sayac * sayac;
                Console.WriteLine("{0} sayısının karesi= {1}",sayac,snc);
                sayac++;
            }
            while (sayac <= s2);
            */

            //---------------------------------------------------------------

            //7-Kullanıcının ne kadar sayı girileceğini belirlediği ve girilen sayıların en büyük ve en küçüğünü bulan program

            //---------------------------------------------------------------
            
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[sayi];
            int enbuyuk; 
            int enkucuk;
            int i = 0;
            do
            {
                dizi[i] =Convert.ToInt32(Console.ReadLine());
                enbuyuk = dizi[0];
                enkucuk = dizi[0];  

                if(dizi[i]>enbuyuk && dizi[i] != enbuyuk)
                {
                    enbuyuk = dizi[i];
                }
                else if (dizi[i] == enbuyuk)
                {
                    enbuyuk = dizi[i];
                }


                if (dizi[i] < enkucuk && dizi[i] !=enkucuk)
                {
                    enkucuk = dizi[i];
                }
                    
                else if (dizi[i]== enkucuk)
                {
                    enkucuk = dizi[i];
                }


                i++;
            }
            while (i < sayi); 
            Console.WriteLine("En küçük :{0}", enkucuk);
            Console.WriteLine("En büyük :{0}", enbuyuk);
            



            //---------------------------------------------------------------

            //8-Kullanıcı 0 a tıklayana kadar not giren ve ortalamasını alıp kaldı geçti yazdıran program

            //---------------------------------------------------------------

            /*
            int sayi, sonuc = 0,sayac=0,ortalama=0;
            do
            {
                Console.Write("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                sonuc = sonuc+sayi;
                sayac++;
            } while (sayi != 0);
            ortalama = sonuc / (sayac-1);
            Console.WriteLine("Girdiğin sayıların toplamı:{0}",ortalama );

            Console.ReadLine();
            */

            //---------------------------------------------------------------



            //9-Kullanıcının kullanıcı adını ve şifresini alıp 3 kere yanlış girilme hakkı tanıyan program

            //---------------------------------------------------------------

            /*
            string ka, sifre,ka2,sifre2;
            int hak = 3;
            Console.Write("Kullanıcı adı belirleyiniz: ");
            ka = Console.ReadLine();
            Console.Write("Şifre belirleyiniz: ");
            sifre = Console.ReadLine();


            do
            {
                Console.WriteLine("---------------------------------");
                Console.Write("Kullanıcı adınızı giriniz: ");
                ka2 = Console.ReadLine();
                Console.Write("Şifrenizi giriniz: ");
                sifre2 = Console.ReadLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine((hak-1) + " deneme hak kaldı!");

                hak--;





            } while (hak > 0 && (ka2 != ka || sifre2 != sifre));
            if (ka2 == ka && sifre2 == sifre)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("giriş yapıldı");
            }

            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("hesap bloke edildi!!");
            }
            */
            //---------------------------------------------------------------

            //10-kullanıcı t ye tıkladığında toplama c ye tıkladığında çıkarma b ye tıkladığında bölme ç ye tıkladığında çarpma işlemi yapan ve bu sayıların haricinde farklı birşeye tıkladığında başa atan program

            //---------------------------------------------------------------

            /*
            Console.WriteLine("Toplama işlemi için 't' ye tıklayınız");
            Console.WriteLine("Çıkarma işlemi için 'c' ye tıklayınız");
            Console.WriteLine("Çarpma işlemi için 'ç' ye tıklayınız");
            Console.WriteLine("Bölme işlemi için 'b' ye tıklayınız");
            string hesap =Console.ReadLine();
            double s1, s2, toplam = 0,carp=1;
            s1 = Convert.ToDouble(Console.ReadLine());
            s2 = Convert.ToDouble(Console.ReadLine());
            switch (hesap)
            {

                case "t":
                    toplam = s1 + s2;
                    Console.WriteLine("{0} + {1} = {2}",s1,s2,toplam); 
                    break;
                case "c":
                    toplam = s1 - s2;
                    Console.WriteLine("{0} - {1} = {2}", s1, s2, toplam);
                    break;
                case "b":
                    carp = s1 / s2;
                    Console.WriteLine("{0} / {1} = {2}", s1, s2, carp);
                    break;
                case "ç":
                    carp = s1 * s2;
                    Console.WriteLine("{0} * {1} = {2}", s1, s2, carp);
                    break;
                default: 
                    Console.WriteLine("İşlem türü yanlış!");
                    break;
            }

            Console.ReadLine();

            */
        }
    }
}
