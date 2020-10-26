using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    public class MyParagraph
    {
        private string[] words;
        MyMapNode<int, string> myMapNodeObj;
        int keyNo = 0;
        public MyParagraph(string sentence)
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
        public void Remove(string wordToBeRemoved)
        {
            try
            {
                int wordNo = new int();
                int removalNo = 0;
                bool wordFound = false;
                foreach (string word in words)
                {
                    if (word == wordToBeRemoved)
                    {
                        myMapNodeObj.Remove(wordNo);
                        wordFound = true;
                        removalNo++;
                    }
                    wordNo++;
                }
                if(wordFound==true)
                    Console.WriteLine($"{wordToBeRemoved} removed at {removalNo} places");
                else
                    throw new MyParaException(MyParaException.ExceptionType.NO_SUCH_WORD, "No such word in given para/sentence");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DisplaySentence()
        {
            for(int keyNo =0;keyNo<words.Length;keyNo++)
            {
                string wordInNewSentence = myMapNodeObj.Get(keyNo);
                if(wordInNewSentence!=null)
                    Console.Write(wordInNewSentence+" ");
                else
                    Console.Write("");
            }
        }
    }
}
