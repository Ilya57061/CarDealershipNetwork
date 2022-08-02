
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealerships.Model
{
    [Table("Cars")]
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; }=string.Empty;
        public int SalonId { get; set; }
        public Salon? Salon { get; set; }
    }
}
