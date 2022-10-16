﻿// See https://aka.ms/new-console-template for more information
using System;

namespace hata_yonetimi // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            // Console.WriteLine("Bir Sayı Giriniz");
            // int sayi=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Girmiş olduğunuz sayı:"+sayi);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata:"+ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı.");
            // }

            try
            {
                //int a=int.Parse(null);
                //int a=int.Parse("test");
                int a=int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok büyük ya da çok küçük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
