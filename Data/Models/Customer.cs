using System.ComponentModel.DataAnnotations;

namespace ExcerciseEF.Data.Models
{
    public class Customer
    {
        [Key, Required, StringLength(100)]
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
