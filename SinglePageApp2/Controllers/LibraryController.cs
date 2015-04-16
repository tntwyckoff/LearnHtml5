using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataStore;
using Models;
using SinglePageApp2.Extensions;

namespace SinglePageApp2.Controllers
{
    public class LibraryController : ApiController
    {

        public List<Library> Get ()
        {
            Library result = null;

            try
            {
                result = Resolver.Get<ILibraryStore> ().LoadLibrary ();
            }
            catch
            { 
            }

            if (result == null || result.Id == 0)
            {
                result = Library.FakeUpInitialLibrary ();

                Resolver.Get<ILibraryStore> ().UpdateLibrary (result);                
            }

            return new List<Library> 
            { 
                result
            };
        }

        public void Put (Library data)
        {
            try
            {
                Resolver.Get<ILibraryStore> ().UpdateLibrary (data);
            }
            catch ( Exception e )
            {
                throw new WebException (string.Format ("Encountered {0}", e.GetSummaryString ()), WebExceptionStatus.UnknownError);
            }
        }

    }
}
