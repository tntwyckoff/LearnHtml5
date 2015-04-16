using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Note
    {

        #region INote Members

        public int Id { get; set; }

        public int TitleId { get; set; }

        public DateTime Date { get; set; }

        public int PageNumber { get; set; }

        public string Title { get; set; }

        #endregion

        public string FullText { get; set; }

    }
}
