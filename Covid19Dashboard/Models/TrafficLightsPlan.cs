using System.ComponentModel.DataAnnotations;

namespace Covid19Dashboard.Models
{
    public class TrafficLightsPlan
    {

        public string? City { get; set; }
        public double? Grade { get; set; }
        public int? NewPatients { get; set; }
        public int? PositivePatients { get; set; }
        public double? RateOfChange { get; set; }
        public int? ActivePatients { get; set; }
    }
}
