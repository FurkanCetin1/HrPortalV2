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
        public ActionResult Create()
        {
            var job = new Job();
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Job job)
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
        public ActionResult Edit(string id, bool saved)
        {
            var job = jobService.Get(id);
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Job job)
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
    }
}