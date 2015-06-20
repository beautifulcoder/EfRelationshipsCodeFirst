using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfRelationshipsCodeFirst.Models
{
    class Role
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
