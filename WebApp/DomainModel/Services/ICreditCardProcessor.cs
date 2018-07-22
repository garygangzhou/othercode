using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services {
    public interface ICreditCardProcessor {
        TransactionResult TakePayment(CreditCard card, decimal amount);
    }
}
