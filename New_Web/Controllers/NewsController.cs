using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datalayer;

namespace New_Web.Controllers
{
    public class NewsController : Controller
    {
        MyCmsContext db = new MyCmsContext();
        private IPageGroupRepository pageGroupRepository;
        private IPageRepository pageRepository;

        public NewsController()
        {
            pageGroupRepository = new PageGroupRepository(db);
            pageRepository = new PageRepository(db);
        }

        // GET: News
        public ActionResult ShowGroups()
        {
            return PartialView(pageGroupRepository.GetGroupsForView());
        }

        public ActionResult ShowGroupsInMenu()
        {
            return PartialView(pageGroupRepository.GetAllGroups());
        }

        public ActionResult TopNews()
        {
            return PartialView(pageRepository.TopNews());
        }

        public ActionResult LatesNews()
        {
            return PartialView(pageRepository.LastNews());
        }

        [Route("Archive")]
        public ActionResult ArchiveNews()
        {
            return View(pageRepository.GetAllPage());
        }

        [Route("Group/{id}/{title}")]
        public ActionResult ShowNewsByGroupId(int id, string title)
        {
            ViewBag.name = title;
            return View(pageRepository.ShowPageByGroupId(id));
        }

        public ActionResult FooterGallery()
        {
            return PartialView(pageRepository.FooterGallery());
        }
        public ActionResult HotNews()
        {
            return PartialView(pageRepository.HotNews());

        }
        public ActionResult ShowPageId()
        {
            return PartialView(pageGroupRepository.GetGroupsForView());
        }
        



    }
}