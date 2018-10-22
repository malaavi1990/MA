using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MA.Domain
{
    public class Role
    {
        public int RoleId { get; set; }

        [Display(Name = "نقش کاربر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
