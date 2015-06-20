﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfRelationshipsCodeFirst.Models
{
    class Program
    {
        public long Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
