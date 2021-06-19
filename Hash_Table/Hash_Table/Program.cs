using System;
using System.Collections;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMapping<int, string> hash = new Hashtable.HashMapping<int, string>(4);
            hash.Add(0, "hello");
            hash.Add(1, "hi");
            hash.Add(2, "how");
            hash.Add(3, "hoo");
            hash.Add(4, "you");
            string varGetvalue = hash.getvalue(3);
            Console.WriteLine("index:" + varGetvalue);
            Console.WriteLine("Occurance:" + hash.getOccurance("you"));
            string GoodThings = "Hello Every one";
            string[] sep = GoodThings.Split(" ");
            HashMapping<int, string> Hash = new HashMapping<int, string>(sep.Length);
            int key = 0;
            foreach(string getword in sep)
            {
                Hash.Add(key, getword);
                key++;

            }
            string Value1 = hash.getvalue(3);
            Console.WriteLine("Value of index is :" + Value1);

            string Message = "Linked list first use case programing";
            string[] sepStr = Message.Split(" ");
            HashMapping<int, string> objhash = new HashMapping<int, string>(sepStr.Length);
            int keys = 0;
            foreach (string getword in sepStr)
            {
                objhash.Add(keys, getword);
                key++;
            }
            Console.WriteLine("Index is Removed:");
            objhash.Removevalu(" ");




        }
    }
}
