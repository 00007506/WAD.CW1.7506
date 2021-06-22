using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAD.WebApp._7506.DAL.DTO
{
    public class Employee
    {
        [DisplayName("Id")]
        public int EmployeeId { get; set; }

        [Required]
        [MinLength(4)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [MinLength(10)]
        public string Address { get; set; }

        [Required]
        [MinLength(9)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public string Position { get; set; }

        [Required]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        public Branch Branch { get; set; }

    }
}
