﻿using System;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Problem in Hash Table Assignment");
            Console.WriteLine("===========================================");
            MyParagraph myParaObj = new MyParagraph("Paranoids are not paranoid " +
                "because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid " +
                "avoidable situations");
            myParaObj.GetFrequency("paranoid");
        }
    }
}
