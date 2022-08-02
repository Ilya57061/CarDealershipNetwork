using CarDealerships.Common.Models;
using CarDealerships.Model;


namespace CarDealerships.BusinessLogic.Interfaces
{
    public interface ISalonService
    {
        IEnumerable<SalonModel> Get();
        SalonModel Get(int id);
        void Create(SalonModel salon);
        void Update(int id,SalonModel salon);
        void Delete(int id);
    }
}
