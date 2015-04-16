using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class IoCConfig : Ninject.Modules.NinjectModule
    {
        public override void Load ()
        {
            Bind<ILibraryStore> ().To<DiskFileDataStore> ();
        }
    }
}
