using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MunicipalityManagementSystem.Models
{
    public class ServiceRequest
    {
        [Key]
        public int RequestID { get; set; }

        [ForeignKey("Citizen")]
        public int CitizenID { get; set; }

        [ForeignKey("Service")]
        public int ServiceID { get; set; }

        public DateTime RequestDate { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Pending";

        public virtual Citizen Citizen { get; set; }
        public virtual Service Service { get; set; }
    }
}
