﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbarInfo()
        {
            ViewBag.phone = context.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Addresses.Select(y => y.Email).FirstOrDefault();
            ViewBag.description = context.Addresses.Select(z => z.Description).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            ViewBag.title = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.image = context.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            var values = context.Products.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialChef()
        {
            var values = context.Chefs.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialInfo()
        {
            return PartialView();
        }

        public PartialViewResult PartialRezervation()
        {
            return PartialView();
        }


        public PartialViewResult PartialTaste()
        {

            return PartialView();
        }
        public PartialViewResult PartialOpenHours()
        {
            var values = context.OpenDayHours.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialInstagram()
        {
            return PartialView();
        }
        public PartialViewResult PartialNewsLetter()
        {
            return PartialView();
        }
        public PartialViewResult PartialCopyright()
        {
            return PartialView();
        }
    }
}