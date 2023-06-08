using System.ComponentModel.DataAnnotations;

namespace Covid19Dashboard.Models
{
    public class BedOccupancy
    {
        public string? HospitalName { get; set; }
        public double? GeneralOccupancy { get; set; }
        public double? InternalMedicineOccupancy { get; set; }

    }
}
