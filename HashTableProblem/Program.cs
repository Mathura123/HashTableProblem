using System;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Problem in Hash Table Assignment");
            Console.WriteLine("===========================================");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");
            hash.GetFrequency("or");
        }
    }
}
