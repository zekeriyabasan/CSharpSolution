using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[3] { "İnek", "At", "Aslan"/*,"Kedi"*/}; // dizi sınırı var dizi 3 elemanlı 0 1 2 indexlerinde 
            /*animals[3] = "Zebra";*/ // burada hata verecektir çünkü biz dizinin boyunu verdik 3 elemanlı olmalı 0 1 2 indexleri kul.
            string[] cities = { "Adana", "İstanbul", "Ankara", "Mersin" };
            //cities[4] = "Eskişehir";

            //Çok boyutlu dizi
            string[,] regions = new string[3,3] // virgül önemli boyut sayısını belirtir.
            {
                { "Adana", "Mersin", "Antalya" },
                { "İstanbul", "Sakarya", "Balıkesir" }, 
                { "Rize", "Trabzon","Ordu" } 
            };

            WriteListToConsole(animals);
            WriteListToConsole(cities);
            WriteMuchDimensionListToConsole(regions);
            Console.ReadLine();
        }

        static void WriteListToConsole(string[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }
        static void WriteMuchDimensionListToConsole(string[,] list) // virgülü unutma boyut fazla
        {
            Console.WriteLine("-------");
            for (int i = 0; i <= list.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= list.GetUpperBound(1); j++)
                {
                    Console.WriteLine(list[i, j]); // matris olayı

                }
                Console.WriteLine("-------");
            }
        }
    }
}
