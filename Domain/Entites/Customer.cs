using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(50, ErrorMessage = "The Name field must be between {2} and {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Address field is required.")]
        [StringLength(100, ErrorMessage = "The Address field must be between {2} and {1} characters.", MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Contact Number field is required.")]
        [StringLength(20, ErrorMessage = "The Contact Number field must be between {2} and {1} characters.", MinimumLength = 5)]
        public string ContactNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "The Username field must contain only letters and numbers.")]
        [StringLength(20, ErrorMessage = "The Username field must be between {2} and {1} characters.", MinimumLength = 5)]
        public string Username { get; set; }
    }

}
