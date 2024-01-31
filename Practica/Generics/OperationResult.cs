using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Generics
{
    public class OperationResult <T>
    {
        public bool Success { get; set; }
        public T Result { get; set; }
        public List<string> Errors { get; set; }

        public OperationResult()
        {
            Errors = new List<string>();
            Success = false;
        }

        public void AddMessage(string message) {  Errors.Add(message); }
        public void SetSuccesResult(T result) { Result = result; }
    }
}
