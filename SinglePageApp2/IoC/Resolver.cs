using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Ninject.Parameters;
using SinglePageApp2.Extensions;

namespace SinglePageApp2
{
    public static class Resolver
    {

        public static readonly IKernel Kernel;


        static Resolver ()
        {
            Kernel = new StandardKernel ();
            Kernel.Load (AppDomain.CurrentDomain.GetStaticAssemblies ());
        }


        public static void AddNinjectModule ( NinjectModule module )
        {
            Kernel.Load (module);
        }

        public static T Get<T> () where T : class
        {
            try
            {
                return Kernel.Get (typeof (T)) as T;
            }
            catch (Exception e)
            {
                throw;
            }

            return null;
        }

    }
}