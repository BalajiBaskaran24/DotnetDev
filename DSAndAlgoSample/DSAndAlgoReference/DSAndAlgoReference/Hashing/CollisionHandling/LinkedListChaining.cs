
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Hashing.CollisionHandling
{


    public class ChainedHashTable<K, V>
    {
        /// <summary>
        /// Size of hash table
        /// </summary>
        private readonly int _buckets;

        private readonly LinkedList<KeyValuePair<K, V>>[] _table;
        
        public ChainedHashTable(int buckets = 10)
        {
            _buckets = buckets;
            //Each index in hash table contains list<keyvaluepair>
            _table = new LinkedList<KeyValuePair<K, V>>[buckets];
            for (int i = 0; i < buckets; i++)
            {
                _table[i] = new LinkedList<KeyValuePair<K, V>>();
            }
        }

        /// <summary>
        /// Add element to hash table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void Add(K key, V value)
        {
            int index = HashFunction(key);
            foreach (var kvp in _table[index])
            {
                if (kvp.Key.Equals(key))//Same key
                {
                    throw new ArgumentException("Duplicate key");
                }
            }

            _table[index].AddLast(new KeyValuePair<K, V>(key, value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(K key, out V value)
        {
            int index = HashFunction(key);
            foreach (var kvp in _table[index])
            {
                if (kvp.Key.Equals(key))
                {
                    value = kvp.Value;
                    return true;
                }
            }

            value = default;
            return false;
        }

        /// <summary>
        /// Removes element from hash table
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(K key)
        {
            int index = HashFunction(key);
            for (LinkedListNode<KeyValuePair<K, V>> node = _table[index].First; node != null; node = node.Next)
            {
                if (node.Value.Key.Equals(key))
                {
                    _table[index].Remove(node);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns hash code for the given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int HashFunction(K key)
        {
            return (key.GetHashCode() & int.MaxValue) % _buckets;
        }
    }

    class LLChainingHelper
    {
        public static void Starter()
        {
            ChainedHashTable<string, string> hashTable = new();
            hashTable.Add("Alice", "123-456");
            hashTable.Add("Bob", "789-012");
            hashTable.Add("Aice", "13-456");
            hashTable.Add("Bb", "79-12");
            hashTable.Add("lice", "123-46");
            hashTable.Add("ob", "79-012");

            if (hashTable.TryGetValue("Alice", out string aliceNumber))
            {
                Console.WriteLine($"Alice's number is {aliceNumber}");
            }
            else
            {
                Console.WriteLine("Alice not found.");
            }
        }
    }
}
