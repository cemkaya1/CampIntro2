using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsMyDictionary
{
    class MyList<K,V>
    {
        K[] key;
        V[] value;
        public MyList()
        {
            key = new K[0];
            value = new V[0];
        }
        public void AddItems(K keyItem, V valueItem)
        {
            K[] tempKey = key;
            V[] tempValue = value;
            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            //for (int i = 0; i < 2; i++)
            //{
            //    key[i] = tempKey[i];
            //    value[i] = tempValue[i];
            //}
            key[key.Length - 1] = keyItem;
            value[value.Length - 1] = valueItem;
        }
        public void ListItems()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("Licance plate code: " + key[i] + ", " + "City Name: " + value[i]);
            }
        }
        public int ItemsLenght
        {
            get { return key.Length; }
        }
    }
}
