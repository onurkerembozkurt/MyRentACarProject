using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        //Getter lar Readonly sadece CTOR içinde set edilebilir.
        public bool Success { get; }

        public string Message { get; }

        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}
