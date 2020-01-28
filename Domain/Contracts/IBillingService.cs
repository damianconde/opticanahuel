using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IBillingService
    {
        Task<IEnumerable<Voucher>> Get(DateTime from, DateTime to);
    }
}
