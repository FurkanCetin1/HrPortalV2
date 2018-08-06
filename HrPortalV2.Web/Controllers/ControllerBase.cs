﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc.Filters;
namespace HrPortalV2.Web.Controllers
{
    public class ControllerBase : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var _messageService = HttpContext.RequestServices.GetService(typeof(IMessageService)) as MessageService;
            if (User.IsInRole("Candidate"))
            {
                var _resumeService = HttpContext.RequestServices.GetService(typeof(IResumeService)) as ResumeService;
                var myresumes = _resumeService.GetAllByUserName(User.Identity.Name).Select(c => c.Id).ToList(); // resumes
                var mymessages = _messageService.GetAllByTo(myresumes);
                ViewBag.MessageCount = mymessages.Count().ToString();
            }
            else
            {
                var _companyService = HttpContext.RequestServices.GetService(typeof(ICompanyService)) as CompanyService;
                var mycompanies = _companyService.GetAllByUserName(User.Identity.Name).Select(c => c.Id).ToList();
                var mymessages = _messageService.GetAllByTo(mycompanies);
                ViewBag.MessageCount = mymessages.Count().ToString();
            }
            base.OnActionExecuting(context);
        }
    }
}