using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        [Key]
        [Column("id")]
        public int ContactId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Column("birth_date")]
        public DateTime Birth { get; set; }
        public int Priority { get; set; }
        public OrganizationEntity? Organization { get; set; }
        public int OrganizationId { get; set; }
    }
}
