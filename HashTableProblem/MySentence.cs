using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    public class MySentence
    {
        private string[] words;
        MyMapNode<int, string> myMapNodeObj;
        int keyNo = 0;
        public MySentence(string sentence)
        {
            words = sentence.Split(' ');
            myMapNodeObj = new MyMapNode<int, string>(words.Length);
            foreach (string word in words)
            {
                myMapNodeObj.Add(keyNo, word);
                keyNo++;
            }
        }
        public void GetFrequency(string value)
        {
            myMapNodeObj.GetFrequency(value);
        }
    }
}
