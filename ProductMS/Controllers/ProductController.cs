using Microsoft.AspNetCore.Mvc;
using ProductMS.Data;
using ProductMS.Models;

namespace ProductMS.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDBCon _db;
        public ProductController(ProductDBCon db) {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> allproducts = _db.Products;
            return View(allproducts);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product obj) {
            if (ModelState.IsValid) {
                _db.Products.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id) {
            if (id == null || id == 0)
            {   
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            if (obj == null)
            { 
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(obj);
        }

        public IActionResult Details(int id) {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            if (obj == null) {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult Delete(int id) {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Products.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("index");
        }


    }
}
