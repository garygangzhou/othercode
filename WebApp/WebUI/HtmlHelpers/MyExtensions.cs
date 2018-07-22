using DomainModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.HtmlHelpers
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void CopyToModelState(this RuleException re,
                System.Web.Mvc.ModelStateDictionary modelState, string prefix ) {
            foreach (string key in re.Errors)
                foreach (string value in re.Errors.GetValues(key))
                    modelState.AddModelError(prefix + "." + key, value);
        }
    }
}
