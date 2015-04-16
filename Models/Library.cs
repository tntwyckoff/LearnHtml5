using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Library : ModelBase
    {

        public int Id { get; set; }

        public List<Title> AllItems { get; set; }

        public static Library FakeUpInitialLibrary ()
        {
            return new Library
            {
                Id = 1,
                AllItems = new List<Title> 
                    { 
                        new Title 
                        {
                            Id=540346,
                            Type = "Book",
                            Name = "Hitch 22",
                            Description = "Christopher Hitchens autobiography",
                            Notes = new List<Note>
                            {
                                new Note
                                {
                                    Id = 4,
                                    Date = new DateTime (2014, 01, 01),
                                    PageNumber = 4,
                                    Title = "Bit about Alfred Nobel",
                                    FullText = "Not entirely sure why I marked this.",
                                    TitleId = 540346
                                }
                            }
                        },
                        new Title 
                        {
                            Id=249771,
                            Type = "Book",
                            Name = "ASP.NET MVC 4 and the Web API",
                            Description = "Building a REST service from Start to Finish",
                            Notes = new List<Note> ()
                        }
                    }
            };
        }
    
    }
}
