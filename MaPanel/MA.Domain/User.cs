using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Domain
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string ActiveCode { get; set; }
        public bool IsActive { get; set; }
        public string ImageName { get; set; }
        public string NationalCode { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
