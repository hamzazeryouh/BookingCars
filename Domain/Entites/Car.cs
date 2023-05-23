using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Car
    {
        public int CarId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string?   Color { get; set; }
        public int? Year { get; set; }
        public decimal? DailyRate { get; set; }
        public bool IsAvailable { get; set; } = true;

        // Additional properties
        public string? LicensePlate { get; set; }
        public int? Mileage { get; set; }
        public string? FuelType { get; set; }
        public string? Transmission { get; set; }
        public IEnumerable<Image>? Images { get; set; }
    }
}
