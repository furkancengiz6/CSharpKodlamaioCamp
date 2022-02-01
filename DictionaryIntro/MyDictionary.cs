using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntro
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];  
        }
        public void Add(TKey key , TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;
            keys = new TKey[keys.Length+1];
            values = new TValue[keys.Length+1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
               
            }
            for (int j = 0; j < tempValue.Length; j++)
            {
                values[j] = tempValue[j];
            }
            keys[keys.Length-1] = key;
            values[values.Length-1] =value;
            
        }
       public int Length
        { get { return keys.Length; } }
        public void Print() {
            for (int i = 0; i < keys.Length; i++)
            {
Console.WriteLine($"Key : {keys[i]} | Value :{values[i]}");
            }
            
        }        

    }
}
