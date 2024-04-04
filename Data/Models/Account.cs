using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcerciseEF.Data.Models
{
    public class Account
    {
        [ForeignKey("Customer")]
        [Key, Required, StringLength(100)]
        public string AccountId { get; set; }

        public string AccountName { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
