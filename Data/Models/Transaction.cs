using System.ComponentModel.DataAnnotations;

namespace ExcerciseEF.Data.Models
{
    public class Transaction
    {
        [Required, StringLength(100)]
        public string TransactionId { get; set; }

        public string TransactionName { get; set; }

        public Customer CustomerId { get; set; }
        public Employee EmployeeId { get; set; }
    }
}
