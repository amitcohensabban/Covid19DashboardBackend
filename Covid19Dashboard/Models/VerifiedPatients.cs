using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Covid19Dashboard.Models
{
    public class VerifiedPatients
    {
        public Guid? Id { get; set; }
        public double? EnteringIsrael { get; set; }
        public string? CountryName { get; set; }
        public double? VerifiedCitizens { get; set; }
        public double? VerifiedForeigners { get; set; }
        public double? VerifiedByTheIncoming { get; set; }


    }
}
