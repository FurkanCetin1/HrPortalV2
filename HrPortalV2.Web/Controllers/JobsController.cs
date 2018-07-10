using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HrPortalV2.Web.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService jobService;
        private readonly ICompanyService companyService;

        public JobsController(IJobService jobService, ICompanyService companyService)
        {
            this.jobService = jobService;
            this.companyService = companyService;
        }
        public IActionResult Index()
        {
            var jobs = jobService.GetAll(); 
            return View(jobs);
        }
        [Authorize(Roles = "Company")]
        //Create
        public IActionResult Create()
        {
            var job = new Job();
            ViewBag.CompanyId = new SelectList(companyService.GetAll(), "Id", "Name");
            job.PublishDate = DateTime.Now;
            job.EndDate = job.PublishDate.AddDays(30);
            return View(job);
            
        }
        [Authorize(Roles = "Company")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                jobService.Insert(job);
                return RedirectToAction(nameof(Edit), new { id = job.Id, saved= true });
            }
            else
            {
                return View(job);
            }
        }
        [Authorize(Roles = "Company")]
        //Edit
        public IActionResult Edit(string id, bool saved)
        {
            var job = jobService.Get(id);
            ViewBag.Saved = saved;
            ViewBag.CompanyId = new SelectList(companyService.GetAll(), "Id", "Name");
            return View(job);
        }
        [Authorize(Roles = "Company")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, Job job)
        {
            if (ModelState.IsValid)
            {
                jobService.Update(job);
                return RedirectToAction(nameof(Edit), new { id = job.Id, saved = true });
            }
            else
            {
                return View(job);
            }
        }
        [Authorize(Roles = "Company")]
        //Delete
        public IActionResult Delete(string id)
        {
            jobService.Delete(id);
            return RedirectToAction("MyJobs");
        }
        [Authorize(Roles = "Company")]
        //MyJobs
        public IActionResult MyJobs()
        {
            var myJobs = jobService.GetAllByUserName(User.Identity.Name).ToList(); 
            return View(myJobs);
        }

        //Details
        public IActionResult Details(string id)
        {
            var job = jobService.Get(id);
            return View(job);

        }
    }
}