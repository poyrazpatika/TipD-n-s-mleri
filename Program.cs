using System;

namespace TipDönüsümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion (bilinçsiz dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c; // int, bellekte a+b+c toplam değerinin üzerinde olduğu için hata vermez.
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" +h);

            float i = h;
            Console.WriteLine("i:" +i);

            string e ="zikriye";
            char f = 'k';
            object g = e + f + d; // object, kapsayıcı bir veri tipi olduğu için atama sırasında sorun çıkmaz.
            Console.WriteLine("g:" +g);


            // explicit conversion (bilinçli dönüşüm)
            
            Console.WriteLine("***** Explicit Conversion *****");
            int x = 4;
            byte y = (byte)x; // int veri tipi, byte veri tipinden daha kapsamlı bir veri tipidir. Bu yüzden int veri tipini byte'a cast ediyoruz.
            Console.WriteLine("y:" +y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" +t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" +v);

            // ToString Methodu
            Console.WriteLine("***** ToString Methodu *****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" +yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" +zz);

            // System.Convert
            Console.WriteLine("***** System.Convert *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" +toplam);

            // Parse
            Console.WriteLine("***** Parse *****");
            ParseMethod();
        }
        
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1:" + rakam1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("double1:" + double1);


        }
    }
}
