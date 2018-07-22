using DomainModel.Services;
using System.Web.Mvc;
using WebUI.HtmlHelpers;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult BasicDetails(string nextButton)
        {
            if (nextButton != null && ModelState.IsValid )
                return RedirectToAction("ExtraDetails");
            return View(regData);
        }
        public ActionResult ExtraDetails(string backButton, string nextButton)
        {
            if (backButton != null)
                return RedirectToAction("BasicDetails");
            else if (nextButton != null && ModelState.IsValid )
                return RedirectToAction("Confirm");
            else
                return View(regData);
        }

        public ActionResult Confirm(string backButton, string nextButton)
        {
            if (backButton != null)
                return RedirectToAction("ExtraDetails");
            else if (nextButton != null)
                return RedirectToAction("Complete");
            else
                return View(regData);
        }
        public ActionResult Complete()
        {
            // Todo: Save regData to database; render a "completed" view
            if (ModelState.IsValid) {
                try {
                    //call business layer to save
                }
                catch (RuleException ex) {
                    //handle business layer error
                    //add business layer error to model, so it will show in view
                    ex.CopyToModelState(ModelState, "BuzLayer");
                    //return to view
                    return Content("Opps, data error.");
                }
                //everything is OK
                return Content("OK, we're done");
            }
            //view state error
            return Content("Opps, data error.");
        }

        public RegistrationData regData;
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //before any action method executing, retrieve data from posted form
            regData = (SerializationUtils.Deserialize(Request.Form["regData"])
                        ?? TempData["regData"]
                        ?? new RegistrationData()) as RegistrationData;
            TryUpdateModel(regData);
        }
        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //after action method executed, put data into tempdata for redirecting
            //TempData can be retrieved on Redirecting target controller
            if (filterContext.Result is RedirectToRouteResult)
                TempData["regData"] = regData;
        }
    }
}
