using AutoMapper;
using CarDealerships.BusinessLogic.Interfaces;
using CarDealerships.Common.Models;
using CarDealerships.Model;
using CarDealerships.Model.Database;
using Microsoft.EntityFrameworkCore;

namespace CarDealerships.BusinessLogic.Implementations
{
    public class SalonService : ISalonService
    {
        private readonly CarDealershipContext _context;
        private readonly IMapper _mapper;
        public SalonService(CarDealershipContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Create(SalonModel model)
        {
            var salon = _mapper.Map<Salon>(model);
            _context.Salons.Add(salon);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Salon salon = Find(id);
            _context.Salons.Remove(salon);
            _context.SaveChanges();
        }

        public IEnumerable<SalonModel> Get()
        {
            var models = _mapper.Map<List<SalonModel>>(_context.Salons.AsNoTracking().ToList());
            return models;
        }

        public SalonModel Get(int id)
        {
           var model = _mapper.Map<SalonModel>(Find(id));
            return model;
        }

        public void Update(int id,SalonModel model)
        {
            var salon = _mapper.Map<SalonModel>(model);
            _context.Update(salon);
            _context.SaveChanges();
        }
        private Salon Find(int id)
        {
            Salon salon = _context.Salons.FirstOrDefault(s => s.Id == id);
            if (salon == null) throw new Exception("Object = null");
            return salon;
        }
    }
}
