using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Models;
using System.IO;

namespace DataStore
{
    public class DiskFileDataStore : ILibraryStore
    {
        const string DISK_FILENAME = "LibraryData.dat";

        string FullFilePath { get { return string.Format ("{0}{1}", @"C:\", DISK_FILENAME); } }

        #region ILibraryStore Members

        public Library LoadLibrary ()
        {
            Library result = new Library ();

            try
            {
                if (File.Exists (FullFilePath))
                {
                    BinaryFormatter bf = new BinaryFormatter ();

                    using ( FileStream fs = File.OpenRead (FullFilePath) )
                    {
                        fs.Position = 0;
                        result = bf.Deserialize (fs) as Library;
                    }
                }
            }
            catch (Exception e)
            { 
            }

            return result;
        }

        public bool UpdateLibrary (Library data)
        {
            bool result = true;

            try
            {
                BinaryFormatter bf = new BinaryFormatter ();

                using (FileStream fs = new FileStream (FullFilePath, FileMode.OpenOrCreate))
                {
                    fs.Position = 0;
                    bf.Serialize (fs, data);
                }
            }
            catch ( Exception e )
            {
            }

            return result;
        }

        #endregion

    }
}
