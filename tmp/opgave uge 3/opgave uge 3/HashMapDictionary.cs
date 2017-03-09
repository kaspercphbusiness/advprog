using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_uge_3
{
    class HashMapDictionary : IVPDictionary
    {
        public const int HASH_MAP_DICTIONARY_SIZE = 12;

        public string[] hashMapDictionary = new string[HASH_MAP_DICTIONARY_SIZE];

        public int get(string dictionaryKey)
        {
            throw new NotImplementedException();
        }

        public bool hasKey(string dictionaryKey) // Har objektet allerede en nøgle?
        {
            bool hasKey = false;
            if (hashMapDictionary.Contains("dictionaryKey"))
            {
                hasKey = true;
                Console.WriteLine(dictionaryKey + " har en hashKey");   
            }
            else if (!hashMapDictionary.Contains("dictionaryKey"))
            {
                Console.WriteLine(dictionaryKey + " har ikke en hashKey");
            }
            return hasKey;   
        }

        public bool isEmpty() // Er der objekter i hashMapDictionary?
        {
            int count = hashMapDictionary.Count(s => s != null);
            Console.WriteLine("Dictionary´s længde er: " + hashMapDictionary.Length);
            bool empty;
            if (count > 0)
            {
                Console.WriteLine("Dictionary indeholder " + count + " objekter");
                empty = false;
            }
            else
            {
                Console.WriteLine("Dictionary indeholder " + count + " objekter");
                empty = true;
            }
            return empty;

        }

        public int set(string dictionaryKey, int hashKey) // indsætter objektet i hashMapDictionary
        {

            if (hashMapDictionary[hashKey] == null)
            {
                hashMapDictionary[hashKey] = "dictionaryKey";
            }

            else if (hashMapDictionary[hashKey] != null)
            {
                while (hashMapDictionary[hashKey] != null && hashKey <= HASH_MAP_DICTIONARY_SIZE)
                {
                    hashKey = hashKey + 1;
                }
            }
            return hashKey;
        }
    }
}

