using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebShopApp.Core.Services;
using WebShopApp.Models.Product;

namespace WebShopApp.Controllers
{
    public class IndexController : Controller
    {
        // GET: IndexController
        //public ActionResult Index(string searchStringCategoryName,string searchStringBrandName)
       // {
            //List<ProductIndexVM> products = _productService.GetProducts(searchStringCategoryName, searchStringBrandName)
               // .Select(products => new ProductIndexVM
               // {
                //    Id = products.Id,
                 //   ProductName = products.ProductName,
                //    BrandId = products.BrandId,
                //    BrandName = products.BrandName,
                //    CategoryId = products.CategoryId,
                //    CategoryName = products.CategoryName,
                //    Picture = products.Picture,
                 //   Quantity = products.Quantity,
                 //   Price = products.Price,
                 //   Discount = products.Discount
                
              //  }).ToList();
            //return this.View(products);
       // }

        // GET: IndexController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IndexController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IndexController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IndexController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IndexController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IndexController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IndexController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
