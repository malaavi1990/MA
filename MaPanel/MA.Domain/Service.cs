using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Domain
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
