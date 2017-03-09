using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_uge_3
{
    interface IVPDictionary
    {
        bool isEmpty();
        bool hasKey(string key);
        int get(string dictionaryKey);
        int set(string dictionaryKey, int hashValue);
    }
}
