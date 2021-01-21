using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
           
            myDictionary.Add(1, "Masa");
            myDictionary.Add(2, "Telefon");
            myDictionary.Add(3, "Bilgisyar");
            myDictionary.Add(4, "Monitör");
            Console.WriteLine(myDictionary.Yazdir(1));
            
        }
    }
}
