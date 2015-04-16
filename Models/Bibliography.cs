using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Bibliography : INote
    {

        #region INote Members

        public int Id { get; set; }

        public int TitleId { get; set; }

        public DateTime Date { get; set; }

        public int PageNumber { get; set; }

        public string Title { get; set; }

        #endregion

        public string ReferencedTitle { get; set; }

        public string ReferencedType { get; set; }

        public DateTime ReferencedPubDate { get; set; }

        public string ReferencedAuthor { get; set; }

        public int ReferencedPageNumber { get; set; }

    }
}
