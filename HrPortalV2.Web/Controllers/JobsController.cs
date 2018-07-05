using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc;

namespace HrPortalV2.Web.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService jobService;

        public JobsController(IJobService jobService)
        {
            this.jobService = jobService;
        }
        public IActionResult Index()
        {
            var jobs = jobService.GetAll(); 
            return View(jobs);
        }

        //Create
        public IActionResult Create()
        {
            var job = new Job();
            job.PublishDate = DateTime.Now;
            job.EndDate = job.PublishDate.AddDays(30);
            return View(job);
            
        }

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

        //Edit
        public IActionResult Edit(string id, bool saved)
        {
            var job = jobService.Get(id);
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Job job)
        {
            if (ModelState.IsValid)
            {
                jobService.Update(job);
                return RedirectToAction(nameof(Edit), new { id = job.Id });
            }
            else
            {
                return View(job);
            }
        }

        //Delete
        public IActionResult Delete(string id)
        {
            jobService.Delete(id);
            return RedirectToAction("Index");
        }

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