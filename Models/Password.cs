using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfRelationshipsCodeFirst.Models
{
    class Password
    {
        [Key, ForeignKey("User")]
        public long UserId { get; set; }
        [Required]
        [StringLength(256)]
        public string PasswordHash { get; set; }
        [Required]
        [StringLength(3)]
        public string EncryptionMethod { get; set; }
        public virtual User User { get; set; }
    }
}
