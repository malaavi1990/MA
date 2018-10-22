using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Domain
{
    public class Slider
    {
        public int SliderId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public int Sort { get; set; }
        public DateTime CreateDate { get; set; }
        public string Link { get; set; }
    }
}
