using DomainModel.Abstract;
using DomainModel.Entities;
using DomainModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductsRepository productsRepository;
        private IOrderSubmitter orderSubmitter;
        private ICreditCardProcessor creditCardProcessor;

        public CartController(IProductsRepository productsRepository, IOrderSubmitter orderSubmitter, ICreditCardProcessor creditCardProcessor)
        {
            this.productsRepository = productsRepository;
            this.orderSubmitter = orderSubmitter;
            this.creditCardProcessor = creditCardProcessor;
        }
        public RedirectToRouteResult AddToCart(Cart cart, int productID, string returnUrl)
        {
            Product product = productsRepository.Products.FirstOrDefault(p => p.ProductID == productID);
            cart.AddItem(product, 1);
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart, int productID, string returnUrl)
        {
            Product product = productsRepository.Products.FirstOrDefault(p => p.ProductID == productID);
            cart.RemoveLine(product);
            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            ViewData["returnUrl"] = returnUrl;
            ViewData["CurrentCategory"] = "Cart";
            return View(cart);
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ViewResult CheckOut(Cart cart) {
            return View(cart.ShippingDetails);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ViewResult CheckOut(Cart cart, FormCollection form) {
            // Empty carts can't be checked out
            if (cart.Lines.Count == 0) {
                ModelState.AddModelError("Cart", "Sorry, your cart is empty!");
                return View();
            }

            // Invoke model binding manually
            CreditCard cc = new CreditCard();
            if (TryUpdateModel(cart.ShippingDetails, form.ToValueProvider() ) 
                && TryUpdateModel<CreditCard>(cc, form.ToValueProvider()) ) {                
                    if (creditCardProcessor.TakePayment(cc, cart.ComputeTotalValue()) == TransactionResult.Success) {
                    orderSubmitter.SubmitOrder(cart);
                    cart.Clear();
                    return View("Completed");
                }
                {
                    ViewData["PageError"] = "Order processing failed";
                    return View();
                }
            }
            else // Something was invalid
                return View();
        }

    }
}
