using System.ComponentModel;

namespace DomainModel.Entities {
    public class CreditCard : IDataErrorInfo{
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public string ExpiryDate { get; set; }
        public string SecurityCode { get; set; }

        public string Error {
            get {
                return string.Empty ;
            }
        }

        public string this[string columnName] {
            get {
                if ((columnName == "CardNumber") && string.IsNullOrEmpty(CardNumber))
                    return "Please enter card name";
                if ((columnName == "CardholderName") && string.IsNullOrEmpty(CardholderName))
                    return "Please enter card holder name";
                if ((columnName == "ExpiryDate") && string.IsNullOrEmpty(ExpiryDate))
                    return "Please enter a expiry date";
                if ((columnName == "SecurityCode") && string.IsNullOrEmpty(SecurityCode))
                    return "Please enter security code";
                return null;
            }
        }
    }
}
