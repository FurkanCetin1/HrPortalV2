using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HrPortalV2.Web.Controllers
{
    public class JobApplicationsController : Controller
    {
        private readonly IJobApplicationService jobApplicationService;
        private readonly IJobService jobService;
        private readonly IResumeService resumeService;
        
        public JobApplicationsController(IJobApplicationService jobApplicationService, IJobService jobService, IResumeService resumeService)
        {
            this.jobApplicationService = jobApplicationService;
            this.jobService = jobService;
            this.resumeService = resumeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Candidate")]
        public ActionResult MyJobApplications() // kendi yaptığım başvurular
        {
       
            var myapplications = jobApplicationService.GetAllByUserName(User.Identity.Name);
            return View(myapplications);
        }
        [Authorize(Roles = "Company")]
        public ActionResult MyJobApplicants() // ilanlarıma başvuranlar
        {
            var jobids = jobService.GetAllByUserName(User.Identity.Name).Select(s => s.Id).ToList();
            // keremden sonra
            var myapplications = jobApplicationService.GetAllByJobs(jobids);
            return View(myapplications);
        }
        [Authorize(Roles = "Candidate")]
        public IActionResult Delete(string id)
        {
            jobApplicationService.Delete(id);
            return RedirectToAction("MyJobApplications");
        }
    }
}