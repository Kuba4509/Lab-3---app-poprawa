using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("organizations")]
    public class OrganizationEntity
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public Address Address { get; set; }
        public ISet<ContactEntity> Contacts { set; get; }
    }
}
