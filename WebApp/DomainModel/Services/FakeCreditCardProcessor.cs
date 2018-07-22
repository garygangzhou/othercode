using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;

namespace DomainModel.Services {
    public class FakeCreditCardProcessor : ICreditCardProcessor {
        public TransactionResult TakePayment(CreditCard card, decimal amount) {
            return TransactionResult.Success;
            //return TransactionResult.CardExpired;
        }
    }
}
