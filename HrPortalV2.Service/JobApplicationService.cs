using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
    public class JobApplicationService : IJobApplicationService
    {
        private readonly IRepository<JobApplication> jobApplicationRepository;
        public JobApplicationService(IRepository<JobApplication> jobApplicationRepository)
        {
            this.jobApplicationRepository = jobApplicationRepository;
        }
        public void Delete(string id)
        {
            var entity = jobApplicationRepository.Get(id);
            jobApplicationRepository.Delete(entity);
        }

        public JobApplication Get(string id)
        {
            return jobApplicationRepository.Get(id, "Resume", "Job");
        }

        public IEnumerable<JobApplication> GetAll()
        {
            return jobApplicationRepository.GetAll("Resume", "Job");
        }

        public void Insert(JobApplication entity)
        {
            jobApplicationRepository.Insert(entity);
        }

        public void Update(JobApplication entity)
        {
            jobApplicationRepository.Update(entity);
        }
    }

    public interface IJobApplicationService
    {
        IEnumerable<JobApplication> GetAll();
        JobApplication Get(string id);
        void Insert(JobApplication entity);
        void Update(JobApplication entity);
        void Delete(string id);
    }
}
