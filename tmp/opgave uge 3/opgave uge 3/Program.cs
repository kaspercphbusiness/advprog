using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_uge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMapDictionary Dictionary = new HashMapDictionary();

            Console.WriteLine("----------isEmpty(); afprøves----------");

            Dictionary.isEmpty();

            Console.WriteLine("----------Objekter skabes----------");

            DictionaryObjekt mejse = new DictionaryObjekt("mejse", "Fugl: Mejse");
            DictionaryObjekt musvit = new DictionaryObjekt("musvit", "Fugl: Musvit");
            DictionaryObjekt solsort = new DictionaryObjekt("solsort", "Fugl: Solsort");
            DictionaryObjekt skade = new DictionaryObjekt("skade", "Fugl: Skade");
            DictionaryObjekt ravn = new DictionaryObjekt("ravn", "Fugl: Ravn");
            DictionaryObjekt høg = new DictionaryObjekt("høg", "Fugl: Høg");
            DictionaryObjekt ugle = new DictionaryObjekt("ugle", "Fugl: Ugle");

            Console.WriteLine("----------set(); afprøves og testes med isEmpty();----------");

            Dictionary.set("mejse", mejse.hashKey);
            Dictionary.set("musvit", musvit.hashKey);
            Dictionary.set("solsort", solsort.hashKey);
            Dictionary.set("skade", skade.hashKey);
            Dictionary.set("ravn", ravn.hashKey);
            Dictionary.set("høg", høg.hashKey);
            Dictionary.set("ugle", ugle.hashKey);

            Dictionary.isEmpty();

            Console.WriteLine("----------hasKey(); afprøves----------");

            Dictionary.hasKey("mejse");
            Dictionary.hasKey("gråspurv");
           

            Console.ReadLine();
            
        }
    }
}
