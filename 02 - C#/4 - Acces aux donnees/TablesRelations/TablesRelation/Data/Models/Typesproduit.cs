﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TablesRelation.Data.Models
{
    public partial class Typesproduit
    {
        public Typesproduit()
        {
            Categories = new HashSet<Category>();
        }

        public int IdTypeProduit { get; set; }
        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
