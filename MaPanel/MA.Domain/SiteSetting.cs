using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Domain
{
    public class SiteSetting
    {
        public int SiteSettingId { get; set; }
        public string SiteTitle { get; set; }
        public string Icon { get; set; }
        public string CopyRight { get; set; }
        public string Description { get; set; }
        public string KeyWord { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkTime { get; set; }
        public string SupportEmail { get; set; }
        public string InfoEmail { get; set; }
        public string Logo { get; set; }
    }
}
