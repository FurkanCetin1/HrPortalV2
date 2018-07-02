﻿using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
  public class CountryService:ICountryService
    {
        private readonly IRepository<Country> countryRepository;
        public CountryService(IRepository<Country> countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public void Delete(string id)
        {
            var entity = countryRepository.Get(id);
            countryRepository.Delete(entity);
        }

        public Country Get(string id)
        {
            return countryRepository.Get(id);
        }

        public IEnumerable<Country> GetAll()
        {
            return countryRepository.GetAll();
        }

        public void Insert(Country entity)
        {
            countryRepository.Insert(entity);
        }

        public void Update(Country entity)
        {
            countryRepository.Update(entity);
        }
    }
    public interface ICountryService
    {
        IEnumerable<Country> GetAll();
        Country Get(string id);
        void Insert(Country entity);
        void Update(Country entity);
        void Delete(string id);
    }
}
