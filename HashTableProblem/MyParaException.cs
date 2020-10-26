using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    class MyParaException : Exception
    {
        public enum ExceptionType 
        {
            NO_SUCH_WORD
        }
        private ExceptionType type;
        public MyParaException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
