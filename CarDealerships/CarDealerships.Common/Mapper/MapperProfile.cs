using AutoMapper;
using CarDealerships.Common.Models;
using CarDealerships.Model;


namespace CarDealerships.Common.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Car, CarModel>().ReverseMap();
            CreateMap<Salon, SalonModel>().ReverseMap();
            CreateMap<User, RegisterModel>().ReverseMap();
        }
    }
}
