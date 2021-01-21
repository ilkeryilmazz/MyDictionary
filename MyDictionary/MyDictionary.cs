using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        public TValue[] items;
        public TKey[] keys;
        public TValue errorArray;
        //constructor
        public MyDictionary()
        {
            items = new TValue[0];
            keys = new TKey[0];
            

    }
       
        public void Add(TKey key,TValue item)
        {
            
            TValue[] tempArray = items;
            TKey[] tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;
            items = new TValue[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
           
            items[items.Length - 1] = item;
            
        }
        public TValue Yazdir(TKey alias)
        {

            
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(alias))
                {
                    return items[i];
                }
            }
            return errorArray;
            
        }       
    } 
}
