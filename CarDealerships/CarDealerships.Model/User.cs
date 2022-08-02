using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealerships.Model
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }=string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt  { get; set; }


    }
}
