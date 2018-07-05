using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
    public class JobService : IJobService
    {
        private readonly IRepository<Job> jobRepository;
        public JobService(IRepository<Job> jobRepository)
        {
            this.jobRepository = jobRepository;
        }
        public void Delete(string id)
        {
            var entity = jobRepository.Get(id);
            jobRepository.Delete(entity);
        }

        public Job Get(string id)
        {
            return jobRepository.Get(id,"Company", "JobApplications");
        }

        public IEnumerable<Job> GetAll()
        {
            return jobRepository.GetAll("Company", "JobApplications");
        }

        public void Insert(Job entity)
        {
            jobRepository.Insert(entity);
        }

        public void Update(Job entity)
        {
            jobRepository.Update(entity);
        }

        public IEnumerable<Job> GetAllByUserName(string userName)
        {
            return jobRepository.GetMany(m => m.CreatedBy == userName);
        }
    }

    public interface IJobService
    {
        IEnumerable<Job> GetAll();
        IEnumerable<Job> GetAllByUserName(string userName);
        Job Get(string id);
        void Insert(Job entity);
        void Update(Job entity);
        void Delete(string id);
    }
}
