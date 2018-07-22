using System.Web.Mvc;
using WebUI.HtmlHelpers;

namespace WebUI.Controllers {
    public class AccountController : Controller
    {
        private IFormsAuth _authenticationProvider;
        public AccountController(IFormsAuth authProvider) {
            this._authenticationProvider = authProvider;
        }
        
        [AcceptVerbs(HttpVerbs.Get)]
        public ViewResult LogOn() {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LogOn(string name, string password, string returnUrl) {
            if (_authenticationProvider.Authenticate(name, password)) {
                // Assign a default redirection destination if not set
                returnUrl = returnUrl ?? Url.Action("Index", "Admin");
                // Grant cookie and redirect
                _authenticationProvider.SetAuthCookie(name, false);
                return Redirect(returnUrl);
            }
            else {
                ViewData["lastLoginFailed"] = true;
                return View();
            }
        }
    }
}
