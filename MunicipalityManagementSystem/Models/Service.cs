using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagementSystem.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceType { get; set; }
    }
}
