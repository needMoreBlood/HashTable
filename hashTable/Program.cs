using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    public class HashTable

    {
        KeyValue[] hash;

        public static void Main() { }

        public HashTable(int size)

        {
            hash = new KeyValue[size];
        }

        private int GetPosition(object key)
        {
            return Math.Abs(key.GetHashCode()) % hash.Length;
        }

        public void PutPair(object key, object value)

        {
            var position = GetPosition(key);

            if (hash[position] is null)
                hash[position] = new KeyValue(key, value);
            else
            {
                var current = hash[position];
                if (current.Key.Equals(key))
                {
                    current.Value = value;
                    return;
                }
            }
        }

        public object GetValueByKey(object key)

        {
            var position = GetPosition(key);

            if (hash[position] is null)
                return null;

            else
            {
                var curent = hash[position];
                if (curent.Key.Equals(key))
                {
                    return curent.Value;
                }
            }

            return true;
        }
    }

    public class KeyValue
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public KeyValue(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
