using CarDealerships.BusinessLogic.Interfaces;
using CarDealerships.Common.Models;
using CarDealerships.Model;
using CarDealerships.Model.Database;
using System.Security.Cryptography;
using System.Text;

namespace CarDealerships.BusinessLogic.Implementations
{
    public class AccountService:IAccountService
    {
        private readonly CarDealershipContext _context;
        private readonly ITokenService _tokenService;
        public AccountService(CarDealershipContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public UserModel Login(LoginModel loginModel)
        {
            var user = _context.Users.SingleOrDefault(u => u.Login == loginModel.Login);
            if (user ==null)
            {
                throw new Exception("invalid login");
            }
                var hmac = new HMACSHA512(user.PasswordSalt);
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginModel.Password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != user.PasswordHash[i])
                    {
                        throw new Exception("invalid password");
                    }
                    
                }
            return new UserModel { Login = user.Login, Token = _tokenService.CreateToken(user) };
        }

        public UserModel Register(RegisterModel model)
        {   
            if (UserCheck(model.Login))
            {
                throw new Exception("user already registered");
            }
            else
            {
                var hmac = new HMACSHA512();
                var user = new User
                {
                    Login = model.Login.ToLower(),
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(model.Password)),
                    PasswordSalt = hmac.Key
                };
                _context.Users.Add(user);
                _context.SaveChanges();

                return new UserModel { Login=user.Login, Token=_tokenService.CreateToken(user)};
            }
          
        }
        private bool UserCheck(string login)
        {
            return _context.Users.Any(u => u.Login == login.ToLower());
        }
    }
}
