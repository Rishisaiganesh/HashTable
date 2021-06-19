using System;
using System.Collections.Generic;
using System.Text;
using static Hash_Table.HashMapping<K, V>;

namespace Hash_Table
{
    public class HashMapping<K,V> : HashMappingBase
    {
        public readonly int size;
        public readonly LinkedList<keyValue<K, V>>[] item;

        internal void Add(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        private object obj;

        internal string getvalue(int v)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
        public struct keyValue<K,V>
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type
        {
            public K key { get; set; }
            public V value { get; set; }

            public static implicit operator HashMapping<,>.keyValue<K, V>(HashMapping<K, V>.keyValue<K, V> v)
            {
                throw new NotImplementedException(Exception);
            }
        }
        public HashMapping(int size)
        {
            this.size = size;
            this.item = new LinkedList<keyValue<K, V>>[size];
        }
        protected LinkedList<keyValue<K,V>> getlinkedList(int position)
        {
            LinkedList<keyValue, K, V> linked = item[position];
            if (linked == null)
            {
                linked = new LinkedList<keyValue<K, V>>();
                item[position] = linked;
            }
            return linked;
        }
        public int PositionOfArray(K key)
        {
            int pos = key.GetHashCode() % size;
            return Math.Abs(pos);
        }

        public V value(K key)
        {
            int pos = PositionOfArray(key);
            LinkedList<keyValue<K, V>> linked = getlinkedList(pos);

            keyValue<K, V> Data = new keyValue<K, V>()
            {
                key = key,
                value = false
            };

            linked.AddLast(Data);
        }
        public void Remove(K key)
        {
            int pos = PositionOfArray(key);
            LinkedList<keyValue<K, V>> linked = getlinkedList(pos);
            bool DataFound = false;
            keyValue<K, V> Found = default(keyValue<K, V>);
            foreach (keyValue<K,V> Data in linked)
            {
                DataFound = true;
                Found = Data;

            }
            if (DataFound)
            {
                linked.Remove(Found);
            }
        }
        public int getOccurance(V value)
        {
            int getOccurance = 0;
            foreach (LinkedList<keyValue<K, V>> items in item)
            {
                if (items == null)
                    continue;
                foreach (keyValue<K, V> obj in items)
                {
                    if (obj.value.Equals(value))
                    {
                        getOccurance++;
                    }
                }
            }
            return getOccurance;
        }
        public void Removevalu(V value)
        {
            foreach (LinkedList<keyValue<K,V>> items in item)
            {
                if (items == null)
                    continue;
                foreach(keyValue<K,V> obj in items)
                {
                    if (obj.value.Equals(value))
                    {
                        Remove(obj.key);
                        break;
                    }
                }
            }
        }
    }
}
