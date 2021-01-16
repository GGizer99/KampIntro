using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[]{ 
            "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java","Python","C#"


            };
            //yeni bir dizi oluşturuyorsun new anahtar kelimesiyle

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)   // in kurslar -> kursları dolaş                                   
            {                                 // kurs -> kursları dolaşırken verilen takma ad
                Console.WriteLine(kurs);
             
            }

            Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}
