using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MunicipalityManagementSystem.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }

        [ForeignKey("Citizen")]
        public int CitizenID { get; set; }

        [Required]
        [StringLength(100)]
        public string ReportType { get; set; }

        [Required]
        public string Details { get; set; }

        public DateTime SubmissionDate { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Under Review";

        public virtual Citizen Citizen { get; set; }
    }
}
