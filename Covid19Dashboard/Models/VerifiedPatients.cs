using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Covid19Dashboard.Models
{
    public class VerifiedPatients
    {
        public double? EnteringIsrael { get; set; }
        public string? CountryName { get; set; }
        public double? VerifiedCitizens { get; set; }
        public double? VerifiedForeigners { get; set; }
        public double? VerifiedByTheIncoming { get; set; }
        public int ? UntillNow { get; set; }
        public int? Year { get; set; }
        public int? SixMonth { get; set; }
        public int? ThreeMonth { get; set; }
        public int? LastMonth { get; set; }



    }
}
