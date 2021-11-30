using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PS.Domain;
using PS.Service;

namespace PS.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        private readonly IProductService prdsrv;
        private readonly ICategoryService catsrv;
        public ProductController(IProductService ps, ICategoryService cs)
        {
            prdsrv = ps;
            catsrv = cs;
        }
        public ActionResult Index()
        {
            return View(prdsrv.GetMany());
        }
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product p, IFormFile file)
        {
            p.ImageName = file.FileName;
            if (file != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads",
                file.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            prdsrv.Add(p);
            prdsrv.Commit();
            return RedirectToAction("Index");
        }
        // GET: Product/Create
        public ActionResult Create()
        {
            var categories = catsrv.GetMany();
            ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Name");
            return View();
        }
        // POST: Product/Index
        [HttpPost]
        public ActionResult Index(string filtre)
        {
            var list = prdsrv.GetMany();
            if (!String.IsNullOrEmpty(filtre))
            {
                list = list.Where(p => p.Name.ToString().Equals(filtre)).ToList();
            }
            return View(list);
        }
      
    }
}