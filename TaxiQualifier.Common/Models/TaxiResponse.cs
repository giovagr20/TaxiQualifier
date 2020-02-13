using System.Collections.Generic;

namespace TaxiQualifier.Common.Models
{
    public class TaxiResponse
    {
        public int Id { get; set; }

        public string Plaque { get; set; }

        public ICollection<TripResponse> Trips { get; set; }

        public UserResponse User { get; set; }
    }
}