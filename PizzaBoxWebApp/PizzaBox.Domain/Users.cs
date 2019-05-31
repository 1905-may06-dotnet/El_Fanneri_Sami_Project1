using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Users
    {
        public int Id { get; set; }
        private string firstName;
        private string lastName;
        private string street;
        private string city;
        private string state;
        private string zipCode;
        private string phone;
        private string email;
        private string password;

        public string FirstName { get => firstName; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("First name cannot be empty");

                firstName = value;
            }
        }

        public string LastName { get => lastName; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name cannot be empty");

                lastName = value;
            }
        }

        public string Street { get => street; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Street address cannot be empty");

                street = value;
            }
        }

        public string City { get => city; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("City field cannot be empty");

                city = value;
            }
        }

        public string State { get => state; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("State field cannot be empty");

                state = value;
            }
        }

        public string ZipCode { get => zipCode; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("ZipCode cannot be empty");

                zipCode = value;
            }
        }

        public string Phone { get => phone; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Phone number cannot be empty");

                phone = value;
            }
        }

        public string Email { get => email; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Email cannot be empty");

                email = value;
            }
        }

        public string Password { get => password; set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Password field cannot be empty");

                password = value;
            }
        }
    }
}
