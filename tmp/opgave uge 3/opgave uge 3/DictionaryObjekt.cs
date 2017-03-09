using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_uge_3
{
    class DictionaryObjekt
    {
        string key;
        int hashValue;
        public int hashKey;
        string value;

        public DictionaryObjekt(string dictionaryKey, string dictionaryValue)
        {
            HashMapDictionary Dictionary = new HashMapDictionary();
            key = dictionaryKey;
            value = dictionaryValue;
            hashValue = key.GetHashCode();
            hashKey = hashValue % HashMapDictionary.HASH_MAP_DICTIONARY_SIZE;
            if (hashKey < 0)
            {
                hashKey = Math.Abs(hashKey);
                //Returnerer den absolutte værdi. Den absolutte værdi er ikke negativ.
                //Den er den samme som originalværdien men uden minustegnet.
            }

            Console.WriteLine("DictionaryObjekt skabt ---- DictionaryKey er " + dictionaryKey + ", DictionaryValue er " + dictionaryValue  + ", Hashvalue er " + hashValue + ", HashKey er " + hashKey);
        }

        //public string dictionaryKey()
        //{
        //    Console.WriteLine(key);
        //    return key; 
        //}

        //public int hashValueOfDictionaryKey() // tildeler objektet en hashværdi
        //{
        //    hashValue = key.GetHashCode();
        //    Console.WriteLine("Hashvalue er: " + hashValue);

        //    hashKey = hashValue % HashMapDictionary.HASH_MAP_DICTIONARY_SIZE;

        //    if (hashKey < 0)
        //    {
        //        hashKey = Math.Abs(hashKey);
        //        //Returnerer den absolutte værdi. Den absolutte værdi er ikke negativ.
        //        //Den er den samme som originalværdien men uden minustegnet.
        //    }

        //    Console.WriteLine("HashKey er; " + hashKey);

        //    return hashKey;
        //}

        //public void dictionaryValue(string objektnavn)
        //{
        //    Console.WriteLine("Dictionaryvalue for objekt: " + objektnavn + " er: " + value);
        //}
    }
}
