using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MA.Domain
{
    public class User
    {
        public string UserId { get; set; }

        [Display(Name = "ایمیل")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        [StringLength(100, ErrorMessage = "{0} باید کمتر از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "{0} را بدرستی وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تلفن همراه")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string MobileNumber { get; set; }

        [Display(Name = "کد فعالسازی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        [StringLength(128)]
        public string ActiveCode { get; set; }

        [Display(Name = "وضعیت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        public bool IsActive { get; set; }

        [Display(Name = "تصویر")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string ImageName { get; set; }

        [Display(Name = "کد ملی")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "{0} باید {2} کاراکتر باشد")]
        public string NationalCode { get; set; }

        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string LastName { get; set; }

        [Display(Name = "کشور")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string Country { get; set; }

        [Display(Name = "استان")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string State { get; set; }

        [Display(Name = "شهر")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string City { get; set; }

        [Display(Name = "آدرس")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "{0} باید بین {2} و {1} کاراکتر باشد")]
        public string Address { get; set; }

        [Display(Name = "کد پستی")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "{0} باید {2} کاراکتر باشد")]
        public string PostalCode { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "تاریخ عضویت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد کنید")]
        public DateTime JoinDate { get; set; }

        [Display(Name = "نقش کاربر")]
        public int RoleId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }
    }
}
