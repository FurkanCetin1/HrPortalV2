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
using Microsoft.AspNetCore.Authorization;

namespace HrPortalV2.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize(Roles="Admin")]
    public class JobsController : Controller
	{
		private readonly IJobService jobService;
		private readonly ICompanyService companyService;

		public JobsController(IJobService jobService, ICompanyService companyService)
		{
			this.jobService = jobService;
			this.companyService = companyService;
		}


		// GET: Admin/Jobs
		public IActionResult Index()
		{
			var jobs = jobService.GetAll();
			return View(jobs);
		}

		// GET: Admin/Jobs/Details/5
		public IActionResult Details(string id)
		{
			var job = jobService.Get(id);
			return View(job);

		}

		// GET: Admin/Jobs/Create
		public IActionResult Create()
		{
			ViewBag.CompanyId = new SelectList(companyService.GetAll(), "Id", "Name");
			return View();
		}

		// POST: Admin/Jobs/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Title,Description,CompanyId,PublishDate,EndDate,IsApproved,IsActive,IsFeatured,Position,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,IPAddress")] Job job)
		{
			if (ModelState.IsValid)
			{
				jobService.Insert(job);
				return RedirectToAction(nameof(Index));
			}
			
			// GET: Admin/Jobs/Edit/5
			ViewBag.CompanyId = new SelectList(companyService.GetAll(), "Id", "Name");
			return View(job);
		}
		public IActionResult Edit(string id)
		{
			var job = jobService.Get(id);
			ViewBag.CompanyId = new SelectList(companyService.GetAll(), "Id", "Name", job.CompanyId);
			return View(job);
		}
		// POST: Admin/Jobs/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(string id, [Bind("Title,Description,CompanyId,PublishDate,EndDate,IsApproved,IsActive,IsFeatured,Position,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,IPAddress")] Job job)
		{
			if (id != job.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					jobService.Update(job);
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!JobExists(job.Id))
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
			ViewBag.CompanyId = new SelectList(companyService.GetAll(), "Id", "Name"); 
			return View(job);
		}

		// GET: Admin/Jobs/Delete/5
		public IActionResult Delete(string id)
		{
			var job = jobService.Get(id);
			return View(job);
		}

		// POST: Admin/Jobs/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(string id)
		{
			jobService.Delete(id);
			return RedirectToAction(nameof(Index));
		}

		private bool JobExists(string id)
		{
			return jobService.GetAll().Any(e => e.Id == id);
		}
	}
}
