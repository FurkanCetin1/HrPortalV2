using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HrPortalV2.Data;
using HrPortalV2.Models;
using HrPortalV2.Service;

namespace HrPortalV2.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountiesController : Controller
    {
        private readonly ICountyService countyService;
        private readonly IResumeService resumeService;

        public CountiesController(ICountyService countyService, IResumeService resumeService)
        {
            this.countyService = countyService;
            this.resumeService = resumeService;
        }

        // GET: Admin/Counties
        public IActionResult Index()
        {
            return View(countyService.GetAll());
        }

        // GET: Admin/Counties/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var county = countyService.Get(id);
            if (county == null)
            {
                return NotFound();
            }

            return View(county);
        }

        // GET: Admin/Counties/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Admin/Counties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,CityId,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,IPAddress")] County county)
        {
            if (ModelState.IsValid)
            {
                countyService.Insert(county);
                return RedirectToAction(nameof(Index));
            }
          
            return View(county);
        }

        // GET: Admin/Counties/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var county = countyService.Get(id);
            if (county == null)
            {
                return NotFound();
            }
          
            return View(county);
        }

        // POST: Admin/Counties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Name,CityId,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,IPAddress")] County county)
        {
            if (id != county.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    countyService.Update(county);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountyExists(county.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
           
            return View(county);
        }

        // GET: Admin/Counties/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var county = countyService.Get(id);
            if (county == null)
            {
                return NotFound();
            }

            return View(county);
        }

        // POST: Admin/Counties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            countyService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool CountyExists(string id)
        {
            return countyService.GetAll().Any(c => c.Id == id);
        }
    }
}
