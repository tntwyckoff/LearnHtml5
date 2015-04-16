using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface INote
    {
        int Id { get; set; }
        int TitleId { get; set; }
        DateTime Date { get; set; }
        int PageNumber { get; set; }
        string Title { get; set; }
    }
}
