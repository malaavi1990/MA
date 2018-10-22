using System;

namespace MA.Domain
{
    public class NewsCategory
    {
        public int NewsCategoryId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
