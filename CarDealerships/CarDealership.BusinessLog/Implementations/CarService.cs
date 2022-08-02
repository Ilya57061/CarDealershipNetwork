using CarDealerships.BusinessLogic.Interfaces;
using CarDealerships.Model;
using Microsoft.EntityFrameworkCore;
using CarDealerships.Model.Database;
using AutoMapper;
using CarDealerships.Common.Models;

namespace CarDealerships.BusinessLogic.Implementations
{
    public class CarService:ICarService
    {
        private readonly CarDealershipContext _context;
        private readonly IMapper _mapper;
        public CarService(CarDealershipContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper; 
        }
        public void Create(CarModel model)
        {
            var car = _mapper.Map<Car>(model);
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Car car = Find(id);
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

        public IEnumerable<CarModel> Get()
        {
            var models  = _mapper.Map<List<CarModel>>(_context.Cars.AsNoTracking().ToList());
            return models;
        }

        public CarModel Get(int id)
        {
            var model = _mapper.Map<CarModel>(Find(id));
            return model;
        }

        public void Update(int id,CarModel model)
        {
            var car = _mapper.Map<CarModel>(model);
            _context.Update(car);
            _context.SaveChanges();
        }
        private Car Find(int id)
        {
            Car car = _context.Cars.FirstOrDefault(s => s.Id == id);
            if (car == null) throw new Exception("Object = null");
            return car;
        }
    }
}
