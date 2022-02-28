using System;

namespace AlgoritmaOdev
{
    class Program
    {
        static void Main(string[] args)
        {
        /* 1.Soru 
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
         Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
         Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
          /* Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz:");
           int n = int.Parse(Console.ReadLine());
           int k= 0;
           int[] sayi= new int[n];
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("Lütfen Sayi Giriniz:");
               k = int.Parse(Console.ReadLine());
               sayi[i] =k ;
           }
           Console.WriteLine("Gİrilen Cİft sayi:");
            foreach(var item in sayi)
           {
               if(item % 2 == 0)
                    Console.WriteLine(item);
           }*/
          /* //2.Soru
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

           Console.WriteLine("1. Pozitif Sayıyı Giriniz.");
           int n= int.Parse(Console.ReadLine());
           Console.WriteLine("2. Pozitif Sayıyı Giriniz.");
           int m= int.Parse(Console.ReadLine());
           int k=0;
           int[] sayi = new int[n];
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("Lütfen Sayi Giriniz:");
               k= int.Parse(Console.ReadLine());
               sayi[i]= k;
           }
           Console.WriteLine("İkinci sayıya eşit veya Tam bölünen sayılar :");
           foreach (var item in sayi)
           {
               if(item% m ==0 || item ==m)
                    Console.WriteLine(item);
           }*/
           /* // 3.Soru
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
            Console.WriteLine("Pozitif Sayıyı Giriniz:");
            int n= int.Parse(Console.ReadLine());
            string m;
            string[] kelimeler= new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen Kelime Giriniz:");
                m= Console.ReadLine();
                kelimeler[i]=m;

            }
            Console.WriteLine("Girilen Kelimler Sondan Başa Göre");
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }*/
            //4.soru
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

          
            Console.WriteLine("Lütfen Bir Cümle Yazınız:");
            string m= Console.ReadLine();
            string[] cümle= m.Split("");
            int sayi=0;
            Console.WriteLine("Toplam cümle sayısı :"+cümle.Length);
            for(int i=0;i<cümle.Length;i++){
                char[] harf= cümle[i].ToCharArray();
                sayi+=harf.Length;
            }
            Console.WriteLine("Toplam harf sayısı:"+sayi);


        }
    }
}
