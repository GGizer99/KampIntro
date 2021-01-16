using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gizer";
            int yas = 20;

            Kurs kurs1 = new Kurs(); //Bir kurs1 değişkeni tanımladık tipi Kurs 
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //Bir kurs2 değişkeni tanımladık tipi Kurs 
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //Bir kurs3 değişkeni tanımladık tipi Kurs 
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 800;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] //new yazısı bellekte dinamik bir alan oluşturması için yazılır
            {
                kurs1,kurs2,kurs3
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi + ":" + kurslar[i].Egitmen + " : " + kurslar[i].IzlenmeOrani);
            }

            Console.WriteLine("--------------------------------");

            foreach (Kurs kurs in kurslar)  //kurs yerine xxx vb şeyler yazabilirsin 
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

            }
            Console.WriteLine("--------------------------------");
            int j = 0;
            while(j < kurslar.Length) {
                Console.WriteLine(kurslar[j].KursAdi + ":" + kurslar[j].Egitmen + " : " + kurslar[j].IzlenmeOrani);
                j++;
            };
            Console.WriteLine("--------------------------------");


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }       //Kurs tipinin değişkenleri
        public int IzlenmeOrani { get; set; }
    }
}
