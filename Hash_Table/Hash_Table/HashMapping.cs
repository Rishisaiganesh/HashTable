using System;
using System.Collections.Generic;
using System.Text;


namespace Hash_Table
{
    public class MyMapNode<K, V>
    {
        /// <summary>
        /// Variables
        /// </summary>
        private int size;
        private LinkedList<KeyValue<K, V>>[] items;
        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="size"></param>
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        /// <summary>
        /// Implementing Array To HashTable
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        /// <summary>
        /// Creating Linkedlist
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public V GetV(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public int Size()
        {
            return size;
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool get = false;
            KeyValue<K, V> foundItem = default;
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    get = true;
                    foundItem = item;

                }
                if (get)
                {
                    linkedlist.Remove(foundItem);
                }
            }
        }


    }
    /// <summary>
    /// Creating KeyValue class
    /// </summary>
    /// <typeparam name="k"></typeparam>
    /// <typeparam name="v"></typeparam>
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}