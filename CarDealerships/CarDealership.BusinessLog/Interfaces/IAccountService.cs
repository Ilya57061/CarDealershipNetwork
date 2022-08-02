using CarDealerships.Common.Models;

namespace CarDealerships.BusinessLogic.Interfaces
{
    public interface IAccountService
    {
        UserModel Register(RegisterModel userModel);
        UserModel Login(LoginModel loginModel);

    }
}
