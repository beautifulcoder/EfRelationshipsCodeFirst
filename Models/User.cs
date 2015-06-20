using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfRelationshipsCodeFirst.Models
{
    class User
    {
        public long Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Company { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
    }
}
