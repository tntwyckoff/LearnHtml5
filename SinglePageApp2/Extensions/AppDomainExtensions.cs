using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace SinglePageApp2.Extensions
{
    public static class AppDomainExtensions
    {

        public static List<Assembly> GetStaticAssemblies (this AppDomain context)
        {
            return context.GetAssemblies ().Where (a => !a.IsDynamic).ToList ();
        }

    }
}