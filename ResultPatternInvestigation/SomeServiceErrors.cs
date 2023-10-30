using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultPatternInvestigation
{
    public static class SomeServiceErrors
    {
        public static readonly Error ErrorName1 = new Error(
            "SomeServiceErrors.ErrorName1", "Message for ErrorName1");

        public static readonly Error ErrorName2 = new Error(
            "SomeServiceErrors.ErrorName2", "Message for ErrorName2");

        public static readonly Error ErrorName3 = new Error(
        "SomeServiceErrors.ErrorName3", "Message for ErrorName3");


        //Instead of static fields, you can also use static methods returning an error.
        //You would call this method with a concrete argument to get an Error instance.
        public static Error ErrorStaticMethod(Guid id) => new Error(
            "SomeServiceErrors.ErrorStaticMethod", $"This is error with Id{id} for ErrorStaticMethod");

    }
}
