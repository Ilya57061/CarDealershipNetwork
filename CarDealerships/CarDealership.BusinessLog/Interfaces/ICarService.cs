using CarDealerships.Common.Models;
using CarDealerships.Model;

namespace CarDealerships.BusinessLogic.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> Get();
        CarModel Get(int id);
        void Create(CarModel car);
        void Update(int id, CarModel car);
        void Delete(int id);
    }
}
