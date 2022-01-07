using System;
using System.Collections.Generic;
using System.Linq;


namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");

                int sayi = Convert.ToInt32(Console.ReadLine());
               
                global::System.Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (global::System.Exception ex)
            {

                global::System.Console.WriteLine("Hata : " + ex.Message.ToString());
            }
             
            finally 
            {
                global::System.Console.WriteLine("İşlem Tamamlandı ");
            }
           

            try
            {
                int a = int.Parse(null);
                int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {

                global::System.Console.WriteLine("Boş değer girdiniz:");
                global::System.Console.WriteLine(ex);

            }

            catch (FormatException ex)
            {

                global::System.Console.WriteLine("Veri Tipi Uygun Değil");
                global::System.Console.WriteLine(ex);


            } 


            catch (OverflowException ex) 
            {
                global::System.Console.WriteLine("Çok Büyük yada Çok Küçük Değer Girdiniz");
                global::System.Console.WriteLine(ex);
            }

            finally
            {
                global::System.Console.WriteLine("İşlem Başarı İle Tamamlandı :) :)");
            }
        }
    }
}
    