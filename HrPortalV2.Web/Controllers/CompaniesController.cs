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
    public class CompaniesController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly ICountyService countyService;
        private readonly ICountryService countryService;
        private readonly ICityService cityService;
        private readonly ISectorService sectorService;
        private readonly IHostingEnvironment _environment;
        public CompaniesController(ICompanyService companyService, ICountyService countyService, ICountryService countryService, ICityService cityService, ISectorService sectorService, IHostingEnvironment environment)
        {
            this.companyService = companyService;
            this.countyService = countyService;
            this.countryService = countryService;
            this.cityService = cityService;
            this.sectorService = sectorService;
            this._environment = environment;
        }
        public IActionResult Index()
        {
            var companys = companyService.GetAll();
            return View(companys);
        }
        [Authorize(Roles = "Company")]
        public ActionResult Create()
        {
            

            var company = new Company();
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name");
            
            
            ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name");
            return View(company);
        }
        // POST: City/Create
        [Authorize(Roles = "Company")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Company company, IFormFile File)
        {
            if (ModelState.IsValid)
            {
                
                if (File != null && File.Length > 0)
                {
                    // upload işlemi yapmak için konum belirle
                    string path = Path.Combine(_environment.WebRootPath, "Uploads", File.FileName);

                    // uploads dizini yoksa oluştur
                    if (!Directory.Exists(Path.Combine(_environment.WebRootPath, "Uploads")))
                    {
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, "Uploads"));
                    }

                    // belirlenen konuma upload yapılır
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }

                    // dosya adı entity'e atanır
                    company.Logo = File.FileName;
                }
                companyService.Insert(company);
                return RedirectToAction(nameof(Edit), new { id = company.Id, saved = true });
            }
            else
            {
                ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", company.CountryId);
                ViewData["CityId"] = new SelectList(cityService.GetAllByCountryId(company.CountryId), "Id", "Name", company.CityId);
                ViewData["CountyId"] = new SelectList(countyService.GetAllByCityId(company.CityId), "Id", "Name", company.CountyId);
                ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name", company.SectorId);
                return View(company);
            }
        }
        [Authorize(Roles = "Company")]
        public ActionResult Edit(string id, bool saved = false)
        {
            var company = companyService.Get(id);
            ViewBag.Saved = saved;
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", company.CountryId);
            ViewData["CityId"] = new SelectList(cityService.GetAllByCountryId(company.CountryId), "Id", "Name", company.CityId);
            ViewData["CountyId"] = new SelectList(countyService.GetAllByCityId(company.CityId), "Id", "Name", company.CountyId);
            ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name", company.SectorId);
            return View(company);
        }
        [Authorize(Roles = "Company")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(String id, Company company, IFormFile File)
        {
            if (ModelState.IsValid)
            {
                
                if (File != null && File.Length > 0)
                {
                    // upload işlemi yapmak için konum belirle
                    string path = Path.Combine(_environment.WebRootPath, "Uploads", File.FileName);

                    // uploads dizini yoksa oluştur
                    if (!Directory.Exists(Path.Combine(_environment.WebRootPath, "Uploads")))
                    {
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, "Uploads"));
                    }

                    // belirlenen konuma upload yapılır
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }

                    // dosya adı entity'e atanır

                    company.Logo = File.FileName;
                }
                companyService.Update(company);
                return RedirectToAction(nameof(Edit), new { id = company.Id, saved = true });
            }
            else
            {
                ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", company.CountryId);
                ViewData["CityId"] = new SelectList(cityService.GetAllByCountryId(company.CountryId), "Id", "Name", company.CityId);
                ViewData["CountyId"] = new SelectList(countyService.GetAllByCityId(company.CityId), "Id", "Name", company.CountyId);
                ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name", company.SectorId);
                return View(countryService);
            }
           
        }
        [Authorize(Roles = "Company")]
        public ActionResult Delete(string id)
        {
            companyService.Delete(id);
            return RedirectToAction("Index");
        }
        public IList<City> GetCities(string countryId)
        {
            IList<City> cities;
            if (string.IsNullOrEmpty(countryId))
            {
               cities = cityService.GetAll().ToList();
            }
            cities = cityService.GetAll().Where(r => r.CountryId == countryId).OrderBy(o => o.Name).ToList();
            return cities;
        }

        public IList<County> GetCounties(string cityId)
        {

            IList<County> counties;
            if (string.IsNullOrEmpty(cityId))
            {
                counties = countyService.GetAll().ToList();
            }
            counties = countyService.GetAll().Where(r => r.CityId == cityId).OrderBy(o => o.Name).ToList();
            return counties;
        }
        public IActionResult MyCompanies()
        {
            var mycompanies = companyService.GetAllByUserName(User.Identity.Name);
            return View(mycompanies);
        }
        public IActionResult Details(string id)
        {
            var company = companyService.Get(id);

            return View(company);

        }

    }
}