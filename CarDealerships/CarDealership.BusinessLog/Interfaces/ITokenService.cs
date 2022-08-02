using CarDealerships.Model;

namespace CarDealerships.BusinessLogic.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
