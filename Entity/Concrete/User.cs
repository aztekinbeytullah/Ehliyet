using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; } //(int, not null)
        public byte[] Name { get; set; } //(varbinary(80)80)
        public string Email { get; set; } //(nvarchar(80), null)
        public string Phone { get; set; } //(nvarchar(11), null)
        public string City { get; set; } //(nvarchar(25), null)
        public string Password { get; set; } //(nvarchar(500), null)
        public DateTime DateOfRegistration { get; set; } //(date, null)
    }
}
