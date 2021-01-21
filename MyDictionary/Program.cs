using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
           
            myDictionary.Add(157, "Masa");
            myDictionary.Add(192, "Telefon");
            myDictionary.Add(172, "Bilgisyar");
            myDictionary.Add(130, "Monitör");
            myDictionary.Add(78, "Kulaklık");
            myDictionary.Add(42, "Mikrofon");
            myDictionary.Add(36, "Mouse");
            myDictionary.Add(72, "Klavye");
            

            Console.WriteLine(myDictionary.Yazdir(157));

            foreach (var item in myDictionary.keys)
            {
                Console.WriteLine(myDictionary.Yazdir(item));
            }
            
        }
    }
}
