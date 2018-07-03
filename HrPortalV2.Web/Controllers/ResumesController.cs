using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HrPortalV2.Web.Controllers
{
    public class ResumesController : Controller
    {
        private readonly IResumeService resumeService;
        private readonly IOccupationService occupationService;
        public ResumesController(IResumeService resumeService,IOccupationService occupationService)
        {
            this.resumeService = resumeService;
            this.occupationService = occupationService;
        }
        public IActionResult Index()
        {
            var resumes = resumeService.GetAll();
            return View(resumes);
        }
        public IActionResult Create()
        {
            var resume = new Resume();
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name");
            return View(resume);
        }
        [HttpPost]
        public IActionResult Create(Resume resume)
        {
            if (ModelState.IsValid)
            {
                resumeService.Insert(resume);
                return RedirectToAction(nameof(Edit), new { id = resume.Id, saved = true });
            }
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name");
            return View(resume);
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}