using System.ComponentModel.Design;
using System.Numerics;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden girilen 2 sayı arasındaki toplamı while,do-while ve for ile bulunuz. Ör: 3 ile 10 girildiyse, 52 olur.Sınırlar dahil DO-WHILE
            //int number1, number2, sonuc = 0;
            //Console.WriteLine("Birinci sayıyı giriniz:");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //do
            //{
            //    sonuc = sonuc + number2;
            //    number2--;

            //}
            //while (number2 > number1);


            //Console.WriteLine("Sonuç :" + (sonuc + number1));
            #endregion

            #region Klavyeden girilen 2 sayı arasındaki toplamı while,do-while ve for ile bulunuz.Ör: 3 ile 10 girildiyse, 52 olur.Sınırlar dahil WHILE
            //Console.WriteLine("Birinci sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int total = 0;
            //while(number1<=number2)
            //{
            //    total += number1;
            //    number1++;
            //}
            //Console.WriteLine(total);
            #endregion

            #region Klavyeden girilen 2 sayı arasındaki toplamı while,do-while ve for ile bulunuz.Ör: 3 ile 10 girildiyse, 52 olur.Sınırlar dahil FOR
            //Console.WriteLine("Birinci sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int total;
            //for(total = 0; number1<=number2; number1++)
            //{
            //    total += number1;
            //}
            //Console.WriteLine(total);
            #endregion

            #region Klaveyeden girilen iki sayının çarpımını * kullanmadan hesaplayınız
            //Console.WriteLine("Birinci sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            ////burda toplamı total olarak tanımlayıp 0 verdik çünkü çarpım işlemini burda tutucaz
            //int total = 0;

            ////burdaki for döngüsünde bir i tanımlıyoruz ve bu i'yi bir sayaç olarak kullanıyoruz 2.sayıya
            //for (int i = 0; i<number2; i++)
            //{
                ////burda toplamı elde etmek için totali birinci sayıyla topluyoruz number2 sayısı kadar
            //    total += number1;
            //}
            //Console.WriteLine(total);
            #endregion

            #region Klavyeden girilen bir sayının yine klavyeden girilen üssünü hesaplayınız. Üs sadece pozitif tamsayı olduğu zaman hesaplamalı.
            //Console.WriteLine("Üssü alınması gereken sayıyı giriniz:");
            //double number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Sayının üssünü giriniz");
            //int exponent = int.Parse(Console.ReadLine());

            ////Sonucumuzu burda 1 olarak tutuyoruz ki sonucumuzu üs ile çarpabilelim aşağıda
            ///
            //double result = 1;

            ////Eğer üs 0'dan küçük olursa hata göndericek ve programı kapatıcak

            //if (exponent <= 0)
            //{
            //    Console.WriteLine("exponent must be bigger than 0");
            //}

            ////eğer üs 0'da büyük ise bir for döngüsü yaratarak üssü hesaplayan fonksiyonu yazıyoruz

            //else
            //{

            //    //burda for döngüsünde i tanımlıyoruz ama bu i'yi sadece üsse kadar gelen bir sayaç olarak kullanıyoruz

            //    for(int i = 0; i<exponent; i++)
            //    {

            //        //sonucu girdiğimiz sayıyla üs kadar kez çarpıyoruz.

            //        result *= number1;
            //    }
            //    Console.WriteLine(result);
            //}
            #endregion
        }
    }
}
