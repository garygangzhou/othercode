using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace WebUI
{
    public class CartModelBinder : System.Web.Mvc.IModelBinder
    {
        private const string cartSessionKey = "_cart";
        public object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
        {
            // Some modelbinders can update properties on existing model instances. This
            // one doesn't need to - it's only used to supply action method parameters.
            if (bindingContext.Model != null)
                throw new InvalidOperationException("Cannot update instances");
            
            // Return the cart from Session[] (creating it first if necessary)
            Cart cart = (Cart)controllerContext.HttpContext.Session[cartSessionKey];
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[cartSessionKey] = cart;
            }
            return cart;
        }
    }
}
