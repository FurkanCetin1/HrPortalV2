using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HrPortalV2.Web.Controllers
{
    public class ResumesController : Controller
    {
        private readonly IResumeService resumeService;
        private readonly IOccupationService occupationService;
        private readonly IHostingEnvironment _environment;
        public ResumesController(IResumeService resumeService,IOccupationService occupationService,IHostingEnvironment _environment)
        {
            this._environment = _environment;
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
        public async Task<IActionResult> Create(Resume resume, IFormFile File)
        {
            if (ModelState.IsValid)
            {
                if (File != null && File.Length > 0)
                {
                    //upload işlemi yapmak için konum belirle
                    string path = Path.Combine(_environment.WebRootPath, "Uploads", File.FileName);
                    //uploads dizini yoksa oluştur
                    if (!Directory.Exists(Path.Combine(_environment.WebRootPath, "Uploads")))
                    {
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, "Uploads"));
                    }
                    //belirlenen konuma upload yapılır.
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }
                    resume.Photo = File.FileName;
                }
                resumeService.Insert(resume);
                return RedirectToAction(nameof(Edit), new { id = resume.Id, saved = true });
            }
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name",resume.OccupationId);
            return View(resume);
        }
        public IActionResult Edit(string id, bool saved)
        {
            ViewBag.Saved = saved;
            var resume = resumeService.Get(id);
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name",resume.OccupationId);
            return View(resume);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Resume resume, IFormFile File)
        {
            if (ModelState.IsValid)
            {
                if (File != null && File.Length > 0)
                {
                    //upload işlemi yapmak için konum belirle
                    string path = Path.Combine(_environment.WebRootPath, "Uploads", File.FileName);
                    //uploads dizini yoksa oluştur
                    if (!Directory.Exists(Path.Combine(_environment.WebRootPath, "Uploads")))
                    {
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, "Uploads"));
                    }
                    //belirlenen konuma upload yapılır.
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }
                    resume.Photo = File.FileName;
                }
                resumeService.Update(resume);
                return RedirectToAction(nameof(Edit), new { id = resume.Id, saved = true });
            }
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name",resume.OccupationId);
            return View();
        }
        public ActionResult Delete(string id)
        {
            resumeService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult MyResumes()
        {
            var myresumes = resumeService.GetAllByUserName(User.Identity.Name).ToList(); // resumes
            return View(myresumes);
        }
    }
}