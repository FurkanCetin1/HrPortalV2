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
    public class CompaniesController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly ICountyService countyService;
        private readonly ICountryService countryService;
        private readonly ICityService cityService;
        private readonly ISectorService sectorService;
        public CompaniesController(ICompanyService companyService, ICountyService countyService, ICountryService countryService, ICityService cityService, ISectorService sectorService)
        {
            this.companyService = companyService;
            this.countyService = countyService;
            this.countryService = countryService;
            this.cityService = cityService;
            this.sectorService = sectorService;

        }
        public IActionResult Index()
        {
            var companys = companyService.GetAll();
            return View(companys);
        }
        public ActionResult Create()
        {

            var company = new Company();
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name");
            ViewData["CityId"] = new SelectList(cityService.GetAll(), "Id", "Name");
            ViewData["CountyId"] = new SelectList(countyService.GetAll(), "Id", "Name");
            ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name");
            return View(company);
        }
        // POST: City/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Insert(company);
                return RedirectToAction(nameof(Edit), new { id = company.Id, saved = true });
            }
            else
            {
                ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", company.CountryId);
                ViewData["CountyId"] = new SelectList(countyService.GetAll(), "Id", "Name", company.CountyId);
                ViewData["CityId"] = new SelectList(cityService.GetAll(), "Id", "Name", company.CountryId);
                ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name", company.CountryId);
                return View(company);
            }
        }
        public ActionResult Edit(string id, bool saved = false)
        {
            var company = companyService.Get(id);
            ViewBag.Saved = saved;
            ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", company.CountryId);
            ViewData["CountyId"] = new SelectList(countyService.GetAll(), "Id", "Name", company.CountyId);
            ViewData["CityId"] = new SelectList(cityService.GetAll(), "Id", "Name", company.CountryId);
            ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name", company.CountryId);
            return View(company);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(String id, Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Update(company);
                return RedirectToAction(nameof(Edit), new { id = company.Id, saved = true });
            }
            else
            {
                ViewData["CountryId"] = new SelectList(countryService.GetAll(), "Id", "Name", company.CountryId);
                ViewData["CountyId"] = new SelectList(countyService.GetAll(), "Id", "Name", company.CountyId);
                ViewData["CityId"] = new SelectList(cityService.GetAll(), "Id", "Name", company.CountryId);
                ViewData["SectorId"] = new SelectList(sectorService.GetAll(), "Id", "Name", company.CountryId);
                return View(countryService);
            }
           
        }
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

    }
}