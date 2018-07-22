using DomainModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class RssController : Controller
    {
        IProductsRepository productsRepository;
        public RssController(IProductsRepository respo) {
            productsRepository = respo;
        }

        // GET: Rss
        public ActionResult Feed()
        {
            var products = (from p 
                            in productsRepository.Products
                            orderby p.CreateDate descending
                            select p).Take(10); 
            return View(products);
        }
    }
}
