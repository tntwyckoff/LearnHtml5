﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Title : ModelBase
    {

        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Note> Notes { get; set; }

    }
}
