using System;
using System.Collections;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hash Table");
            MyMapNode<string, string> Obj = new MyMapNode<string, string>(10);
            Obj.Add("0", "Rishi");
            Obj.Add("1", "Sai");
            Obj.Add("2", "ganesh");
            Obj.Add("3", "Creating");
            Obj.Add("4", "HashTable");
            Obj.Add("5", "In");
            Obj.Add("6", "VisuvalStudio");
            Console.WriteLine(Obj.GetV("6").GetHashCode());
            Console.WriteLine(Obj.GetV("3").GetHashCode());
            Console.WriteLine(Obj.Size() + "Getting Size of HashTable");
            Obj.Remove("1");
            Console.WriteLine("Getting Size of HashTable After Removing" + Obj.Size());
        }
    }
}
