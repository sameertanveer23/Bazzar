using Bazzar.Entities;
using Bazzar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bazzar.Web.Controllers
{
    public class CatagoryController : Controller
    {
        CatagoriesService catagoriesService = new CatagoriesService();

        public ActionResult Index()
        {
            var categories = catagoriesService.ViewCatagory();
            return View(categories);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  ActionResult Create(Catagory catagory)
        {
            catagoriesService.SaveCatagory(catagory);
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var category =  catagoriesService.GetCatagoryById(Id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Catagory catagory)
        {
            catagoriesService.UpdateCatagory(catagory);
            return View(catagory);
        }
    }
}