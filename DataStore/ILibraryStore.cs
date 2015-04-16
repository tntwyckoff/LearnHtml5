using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataStore
{
    public interface ILibraryStore
    {

        Library LoadLibrary ();
        bool UpdateLibrary (Library data);

    }
}
