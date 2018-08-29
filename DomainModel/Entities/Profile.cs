using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public DateTime Birthday { get; set; }
        public String PhotoUrl { get; set; }
        public virtual ICollection<Profile> Friends { get; set; }
    }
}
