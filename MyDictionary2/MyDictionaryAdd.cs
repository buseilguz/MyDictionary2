using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary2
{
    public class MyDictionaryAdd<Keys,Values>
    {
        Keys[] keysArray;
        Values[] valuesArray;
        public MyDictionaryAdd()
        {
            keysArray = new Keys[0];
            valuesArray = new Values[0];
        }

        public void Add(Keys key,Values value)
        {
            Keys[] tempKeyArray = keysArray;
            Values[] tempValueArray = valuesArray;
            keysArray = new Keys[keysArray.Length + 1];
            valuesArray = new Values[valuesArray.Length + 1];

            for (int i =  0; i < tempKeyArray.Length; i++)
            {
                keysArray[i] = tempKeyArray[i];
                valuesArray[i] = tempValueArray[i];

            }
            keysArray[keysArray.Length - 1] = key;
            valuesArray[valuesArray.Length - 1] = value;




        }

        public int howManyKey
        {
            get { return keysArray.Length; }
        }
        public int howManyValue
        {
            get { return valuesArray.Length; }
        }
        public Keys[] key
        {
            get { return keysArray; }
        }

        public Values[] value
        {
            get { return valuesArray; }
        }
    }
}
