using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public DateTime CreateDate { get; set; }
        public int Visit { get; set; }
        public string Price { get; set; }
        public bool IsActive { get; set; }
    }
}
