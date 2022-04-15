using System.ComponentModel.DataAnnotations;

namespace InspectionApi.Models
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = String.Empty;

        [StringLength(200)]
        public string Comments { get; set; } = String.Empty;


        public int InspectionId { get; set; }
        public InspectionType? InspectionType { get; set; }
    }
}
