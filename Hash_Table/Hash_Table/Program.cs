using System;
using System.Collections;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hash Table");
            MyMapNode<string, string> Obj = new MyMapNode<string, string>(20);
            Obj.Add("0", "Rishi");
            Obj.Add("1", "Sai");
            Obj.Add("2", "ganesh");
            Obj.Add("3", "Creating");
            Obj.Add("4", "HashTable");
            Obj.Add("5", "In");
            Obj.Add("6", "VisuvalStudio");
            Obj.Add("7", "Paranoids");
            Obj.Add("8", "but");
            Obj.Add("9", "They");
            Obj.Add("10", "Are");
            Obj.Add("11", "parnoid");
            Obj.Add("12", "But beacuse");
            Obj.Add("13", "they keep");
            Obj.Add("14", "putting");
            Obj.Add("15", "Themselves");
            Obj.Add("16", "deliberately");
            Obj.Add("17", "into");
            Obj.Add("18", "parnoid Avoidable");
            Obj.Add("19", "situation");
            Console.WriteLine(Obj.GetV("6").GetHashCode());
            Console.WriteLine(Obj.GetV("3").GetHashCode());
            Console.WriteLine(Obj.Size() + "Getting Size of HashTable");
            Console.WriteLine("Getting Size of HashTable " + Obj.Size());
            Obj.Remove("11");
            Console.WriteLine("size of the Hash table After removing" + Obj.Size());
        }
    }
}
