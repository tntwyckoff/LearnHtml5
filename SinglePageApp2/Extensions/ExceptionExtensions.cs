using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePageApp2.Extensions
{
    public static class ExceptionExtensions
    {

        public static string GetSummaryString (this Exception context)
        {
            return string.Format ("'{0}': {1}", context.GetType ().Name, context.Message);
        }

    }
}