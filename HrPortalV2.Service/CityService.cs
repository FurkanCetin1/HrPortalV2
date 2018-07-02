using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
   public class CityService: ICityService
    {
        private readonly IRepository<City> cityRepository;
        public CityService(IRepository<City> cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public void Delete(string id)
        {
            var entity = cityRepository.Get(id);
            cityRepository.Delete(entity);
        }

        public City Get(string id)
        {
            return cityRepository.Get(id, "Country");
        }

        public IEnumerable<City> GetAll()
        {
            return cityRepository.GetAll("Country");
        }

        public void Insert(City entity)
        {
            cityRepository.Insert(entity);
        }

        public void Update(City entity)
        {
            cityRepository.Update(entity);
        }
    }
    public interface ICityService
    {
        IEnumerable<City> GetAll();
        City Get(string id);
        void Insert(City entity);
        void Update(City entity);
        void Delete(string id);
    }
}
