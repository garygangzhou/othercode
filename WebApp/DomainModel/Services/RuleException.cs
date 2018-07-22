using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public class RuleException : Exception
    {
        public NameValueCollection Errors { get; private set; }
        public RuleException(string key, string value)
        {
            Errors = new NameValueCollection { { key, value } };
        }
        public RuleException(NameValueCollection errors)
        {
            Errors = errors;
        }
       
        //Populates a ModelStateDictionary for generating UI feedback   
        //moved to web ui application, as Extension     
        //public void CopyToModelState(System.Web.ModelBinding.ModelStateDictionary modelState, string prefix)
        //{
        //    foreach (string key in Errors)
        //        foreach (string value in Errors.GetValues(key))
        //            modelState.AddModelError(prefix + "." + key, value);
        //}       
    }
}
