
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Hashing.CollisionHandling
{


    public class ChainedHashTable<K, V>
    {
        private readonly int _buckets;
        private readonly LinkedList<KeyValuePair<K, V>>[] _table;
        
        public ChainedHashTable(int buckets = 10)
        {
            _buckets = buckets;
            _table = new LinkedList<KeyValuePair<K, V>>[buckets];
            for (int i = 0; i < buckets; i++)
            {
                _table[i] = new LinkedList<KeyValuePair<K, V>>();
            }
        }

        public void Add(K key, V value)
        {
            int index = GetIndex(key);
            foreach (var kvp in _table[index])
            {
                if (kvp.Key.Equals(key))
                {
                    throw new ArgumentException("Duplicate key");
                }
            }

            _table[index].AddLast(new KeyValuePair<K, V>(key, value));
        }

        public bool TryGetValue(K key, out V value)
        {
            int index = GetIndex(key);
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

        public bool Remove(K key)
        {
            int index = GetIndex(key);
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

        private int GetIndex(K key)
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
