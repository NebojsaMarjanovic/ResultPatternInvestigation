using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultPatternInvestigation
{
    /*The only way to create a Result instance is by using static methods:
     * 
    --> Success - creates a success result
    --> Failure - creates a failure result with the specified Error
    */

    public class Result
    {
        //A private constructor is a special instance constructor in C# used to restrict how an object can be created.
        private Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None ||
                !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }
        }

        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }
        public static Result Success()=>new(true,Error.None);   
        public static Result Failure(Error error) => new(false,error);
    }
}
