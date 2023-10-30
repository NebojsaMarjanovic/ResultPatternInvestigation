using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultPatternInvestigation
{
    //You can use the Error class to document all possible errors in your application.

    public sealed record Error (String Code, string Description)
    {
        public static readonly Error None = new Error(string.Empty, string.Empty);
    }
}
