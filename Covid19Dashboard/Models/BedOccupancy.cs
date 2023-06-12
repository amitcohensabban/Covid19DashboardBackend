using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Covid19Dashboard.Models
{
    public class BedOccupancy
    {
        public Guid? Id { get; set; }
        public string? HospitalName { get; set; }
        public double? GeneralOccupancy { get; set; }
        public double? InternalMedicineOccupancy { get; set; }

    }
}
