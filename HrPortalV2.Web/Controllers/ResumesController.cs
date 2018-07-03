using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc;

namespace HrPortalV2.Web.Controllers
{
    public class ResumesController : Controller
    {
        private readonly IResumeService resumeService;
        public ResumesController(IResumeService resumeService)
        {
            this.resumeService = resumeService;
        }
        public IActionResult Index()
        {
            var resumes = resumeService.GetAll();
            return View(resumes);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}