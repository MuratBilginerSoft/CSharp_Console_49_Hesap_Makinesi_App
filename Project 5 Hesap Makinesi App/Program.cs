using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5_Hesap_Makinesi_App
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sayi1, Sayi2, Sonuc;
            char Operator;
            char Durum;

            etiket:
           
                Console.Write("Birinci Sayıyı Giriniz:");
                Sayi1 = double.Parse(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz:");
                Sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bir Operatör Giriniz:(+ - * /):");
                Operator = char.Parse(Console.ReadLine());

                if (Operator == '+')
                {
                    Sonuc = Sayi1 + Sayi2;
                    Console.WriteLine(Sayi1 + " + " + Sayi2 + " = " + Sonuc);
                }

                else if (Operator == '-')
                {

                    Sonuc= Math.Abs(Sayi1 - Sayi2);
                    Console.WriteLine("|"+Sayi1 + " - " + Sayi2 +"| = " + Sonuc);

                //Abs Metoduyla Mutlak Değer İşlemi Yaparak İstenilen İşlemi Yukarıdaki Kodlamayala yaptım. Alttaki Kodlar İlk Kodlardır.

                //if (Sayi1 > Sayi2)
                //    {
                //        Sonuc = Sayi1 - Sayi2;
                //        Console.WriteLine(Sayi1 + " - " + Sayi2 + " = " + Sonuc);
                //    }

                //    else
                //    {
                //        Sonuc = -(Sayi1 - Sayi2);
                //        Console.WriteLine(Sayi2 + " - " + Sayi1 + " = " + Sonuc);
                //    }
                }

                else if (Operator == '*')
                {
                    Sonuc = Sayi1 * Sayi2;
                    Console.WriteLine(Sayi1 + " * " + Sayi2 + " = " + Sonuc);
                }

                else if (Operator == '/')
                {
                    Sonuc = Sayi1 / Sayi2;
                    Console.WriteLine(Sayi1 + " / " + Sayi2 + " = " + Sonuc);
                }

                else
                {
                    Console.WriteLine("Yanlış Operatör Girdiniz");
                }

                Console.WriteLine("Hesap Makinesini Kullanmaya Devam Edicek misiniz?(e/h Veya E/H):");
                Durum = Convert.ToChar(Console.ReadLine());

                if (Durum == 'E' || Durum == 'e')
                {
                    goto etiket;
                }

                else
                {
                    Console.WriteLine("Hesap Makinesini Kapatmak İçin Bir Tuşa Basınız");
                }


            

            Console.ReadKey();
            
        }

    }
}
