using System.ComponentModel.DataAnnotations;

namespace ExcerciseEF.Data.Models
{
    public class Log
    {
        [Key, Required, StringLength(100)]
        public string LogId { get; set; }

        public DateTime LoginDate { get; set; }

        public DateTime LoginTime { get; set; }

        public Transaction Transaction { get; set; }

        //public Log()
        //{
        //    this.Reports = new HashSet<Report>;
        //}
    }
}
