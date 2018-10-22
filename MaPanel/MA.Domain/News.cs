using System;

namespace MA.Domain
{
    public class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string WriterName { get; set; }
        public int Visit { get; set; }
        public string Thumbnail { get; set; }
        public string Image { get; set; }
        public string WriterImage { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
