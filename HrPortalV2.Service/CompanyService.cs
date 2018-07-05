using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
   public class CompanyService:ICompanyService
    {
        private readonly IRepository<Company> companyRepository;
        public CompanyService(IRepository<Company> companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public void Delete(string id)
        {
            var entity = companyRepository.Get(id);
            companyRepository.Delete(entity);
        }

        public Company Get(string id)
        {
            return companyRepository.Get(id, "Country", "City", "County", "Sector");
        }

        public IEnumerable<Company> GetAll()
        {
            return companyRepository.GetAll("Country", "City", "County", "Sector");
        }
        public IEnumerable<Company> GetAllByUserName(string userName)
        {
            return companyRepository.GetMany(m => m.CreatedBy == userName);
        }

        public void Insert(Company entity)
        {
            companyRepository.Insert(entity);
        }

        public void Update(Company entity)
        {
            companyRepository.Update(entity);
        }
    }
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
        IEnumerable<Company> GetAllByUserName(string userName);
        Company Get(string id);
        void Insert(Company entity);
        void Update(Company entity);
        void Delete(string id);
    }
}
