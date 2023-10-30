using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultPatternInvestigation
{
    public static class ResultExtensions
    {
        //You can implement the Match extension method to provide a callback for each Result state.
        //The Match method will execute the respective callback and return the result.
        public static T Match<T>(
            this Result result,
            Func<T> onSuccess,
            Func<Error, T> onFailure)
        {
            return result.IsSuccess ? onSuccess() : onFailure(result.Error);
        }
    }
}
