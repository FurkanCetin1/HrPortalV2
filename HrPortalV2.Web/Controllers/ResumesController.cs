using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HrPortalV2.Web.Controllers
{
    public class ResumesController : ControllerBase
    {
        private readonly IResumeService resumeService;
        private readonly IOccupationService occupationService;
        private readonly IHostingEnvironment _environment;
        private readonly ICountryService countryService;
        private readonly ICityService cityService;
        private readonly ICountyService countyService;
        public ResumesController(IResumeService resumeService,IOccupationService occupationService,IHostingEnvironment _environment, ICountryService countryService, ICityService cityService, ICountyService countyService)
        {
            this._environment = _environment;
            this.resumeService = resumeService;
            this.occupationService = occupationService;
            this.countryService = countryService;
            this.cityService = cityService;
            this.countyService = countyService;
        }
        public IActionResult Index()
        {
            var resumes = resumeService.GetAll();
            return View(resumes);
        }
        [Authorize(Roles = "Candidate")]
        public IActionResult Create()
        {
            var resume = new Resume();
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name");
            ViewData["CountryId"] = new SelectList(countryService.GetAll(),"Id","Name");
            return View(resume);
        }
        [Authorize(Roles = "Candidate")]
        [HttpPost]
        public IActionResult Create(Resume resume, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                if (upload != null && upload.Length > 0)
                {
                    //upload işlemi burada yapılır.
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(upload.FileName);
                    var path = Path.Combine(_environment.WebRootPath, "Uploads","Resumes");
                    var filePath = Path.Combine(path, fileName);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        upload.CopyTo(stream);
                    }
                    resume.Photo = fileName;
                }
                resumeService.Insert(resume);
                return RedirectToAction(nameof(MyResumes), new { id = resume.Id, saved = true });
            }
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name",resume.OccupationId);
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", resume.CountryId);
            ViewData["CityId"] = new SelectList(cityService.GetAllByCountryId(resume.CountryId), "Id", "Name", resume.CityId);
            ViewData["CountyId"] = new SelectList(countyService.GetAllByCityId(resume.CityId), "Id", "Name", resume.CountyId);
            return View(resume);
        }
        [Authorize(Roles = "Candidate")]
        public IActionResult Edit(string id, bool saved)
        {
            ViewBag.Saved = saved;
            var resume = resumeService.Get(id);
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name",resume.OccupationId);
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", resume.CountryId);
            ViewData["CityId"] = new SelectList(cityService.GetAllByCountryId(resume.CountryId), "Id", "Name", resume.CityId);
            ViewData["CountyId"] = new SelectList(countyService.GetAllByCityId(resume.CityId), "Id", "Name", resume.CountyId);
            return View(resume);
        }
        [Authorize(Roles = "Candidate")]
        [HttpPost]
        public IActionResult Edit(Resume resume, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                if (upload != null && upload.Length > 0)
                {
                    //upload işlemi burada yapılır.
                    var rnd = new Random();
                    var fileName = Path.GetFileNameWithoutExtension(upload.FileName) + rnd.Next(1000).ToString() + Path.GetExtension(upload.FileName);
                    var path = Path.Combine(_environment.WebRootPath, "Uploads");
                    var filePath = Path.Combine(path, fileName);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        upload.CopyTo(stream);
                    }
                    resume.Photo = fileName;
                }
                resumeService.Update(resume);
                return RedirectToAction(nameof(Edit), new { id = resume.Id, saved = true });
            }
            ViewData["OccupationId"] = new SelectList(occupationService.GetAll(), "Id", "Name",resume.OccupationId);
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", resume.CountryId);
            ViewData["CityId"] = new SelectList(cityService.GetAllByCountryId(resume.CountryId), "Id", "Name", resume.CityId);
            ViewData["CountyId"] = new SelectList(countyService.GetAllByCityId(resume.CityId), "Id", "Name", resume.CountyId);
            return View();
        }
        public IActionResult Details(string id)
        {
            var resume = resumeService.Get(id);
            return View(resume);
        }
        [Authorize(Roles = "Candidate")]
        public ActionResult Delete(string id)
        {
            resumeService.Delete(id);
            return RedirectToAction("MyResumes");
        }
        [Authorize(Roles = "Candidate")]
        public IActionResult MyResumes()
        {
            var myresumes = resumeService.GetAllByUserName(User.Identity.Name).ToList(); // resumes
            return View(myresumes);
        }
    }
}