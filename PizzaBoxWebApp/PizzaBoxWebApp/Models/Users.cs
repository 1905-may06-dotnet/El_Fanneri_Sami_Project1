using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWebApp.Models
{
    public class Users
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name cannot be blank.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage ="Last name cannot be blank")]
        public string LastName { get; set; }

        [DisplayName("Street")]
        [Required(ErrorMessage = "Street address cannot be blank")]
        public string Street { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City name cannot be blank")]
        public string City { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "State cannot be blank")]
        public string State { get; set; }

        [DisplayName("ZipCode")]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "ZipCode cannot be blank")]
        public string ZipCode { get; set; }

        [DisplayName("Phone #")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number cannot be blank")]
        public string Phone { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email cannot be blank")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password field cannot be blank")]
        public string Password { get; set; }
    }
}
