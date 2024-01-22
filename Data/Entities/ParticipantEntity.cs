using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("travels")]
    public class ParticipantEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartingLocation { get; set; }
        public string Destination { get; set; }
        public string Participants { get; set; }
        public string Guide { get; set; }
    }
}
