using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
    public class ResumeService : IResumeService
    {
        private readonly IRepository<Resume> resumeRepository;
        public ResumeService(IRepository<Resume> resumeRepository)
        {
            this.resumeRepository = resumeRepository;
        }
        public void Delete(string id)
        {
            var entity = resumeRepository.Get(id);
            resumeRepository.Delete(entity);
        }

        public Resume Get(string id)
        {
            return resumeRepository.Get(id, "ResumeFiles", "JobApplications", "Occupation");
        }

        public IEnumerable<Resume> GetAll()
        {
            return resumeRepository.GetAll("ResumeFiles", "JobApplications", "Occupation");
        }
        public IEnumerable<Resume> GetAllByUserName(string userName)
        {
            return resumeRepository.GetMany(m => m.CreatedBy == userName, o=>o.UpdateDate,true);
        }

        public void Insert(Resume entity)
        {
            resumeRepository.Insert(entity);
        }

        public void Update(Resume entity)
        {
            resumeRepository.Update(entity);
        }
    }

    public interface IResumeService
    {
        IEnumerable<Resume> GetAll();
        IEnumerable<Resume> GetAllByUserName(string userName);
        Resume Get(string id);
        void Insert(Resume entity);
        void Update(Resume entity);
        void Delete(string id);
    }
}
