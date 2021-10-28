using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DateAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKampıBaşlıyor.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();

            return View(contactvalues);
        }
        
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult ContactSideBarPartial()
        {
            string userEmail = (string)Session["UserMail"];
            var contactList = cm.GetList();
            ViewBag.contactCount = contactList.Count();
            var listResult = mm.GetListSendbox(userEmail);
            var sendList = listResult.FindAll(x => x.isDraft == false);
            ViewBag.sendCount = sendList.Count();
            var listResult2 = mm.GetListInbox(userEmail);
            ViewBag.inboxCount = listResult2.Count();
            var drafList = listResult.FindAll(x => x.isDraft == true);
            ViewBag.draftCount = drafList.Count();
            return PartialView();
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }

    }
}