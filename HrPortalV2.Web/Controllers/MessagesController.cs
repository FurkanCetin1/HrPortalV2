using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc;

namespace HrPortalV2.Web.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageService messageService;
        public MessagesController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public IActionResult MyMessages()
        {
            var mymessages = messageService.GetByUserName(User.Identity.Name);
            return View(mymessages);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}