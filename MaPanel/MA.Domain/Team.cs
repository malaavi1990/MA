using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Domain
{
    public class Team
    {
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Post { get; set; }
        public string Summary { get; set; }
        public string Thumbnail { get; set; }
        public string Image { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
