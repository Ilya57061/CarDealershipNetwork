using System.ComponentModel.DataAnnotations.Schema;
namespace CarDealerships.Model
{
    [Table("Salons")]
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; }=string.Empty;
        public List<Car>? Cars { get; set; }
    }
}
