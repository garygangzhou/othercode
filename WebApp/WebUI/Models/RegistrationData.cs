using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    [Serializable]
    public class RegistrationData : IDataErrorInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Hobbies { get; set; }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName]
        {
            get
            {
                //because this model is used in a wizard page
                //every page in this wizard will perform validation
                //will be failed at first page, because there is such field show up in page for user
                //???

                //if ((columnName == "Name") && string.IsNullOrEmpty(Name))
                //    return "Please enter a name";
                //if ((columnName == "Email") && !IsValidEmailAddress(Email))
                //    return "Please enter a valid email address";
                //if ((columnName == "Age") && !Age.HasValue)
                //    return "Please enter a numeric age";
                return null;
            }
        }

        public bool IsValidEmailAddress(string emailaddress)
        {
            return true;
        }
    }
}