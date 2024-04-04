using System.ComponentModel.DataAnnotations;

namespace ExcerciseEF.Data.Models
{
    public class Report
    {
        //public Report()
        //{
        //    this.Logs = new HashSet<Log>();
        //}

        [Key, Required, StringLength(100)]
        public string ReportId { get; set; }

        public string ReportName { get; set; }

        public DateTime ReportDate { get; set; }

        public Account Account { get; set; }
        public Transaction Transaction { get; set; }

    }
}
