using Domain.Contracts;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class BillingService : IBillingService
    {
        private readonly IAfipService afipService;

        public BillingService(IAfipService afipService)
        {
            this.afipService = afipService;
        }

        public async Task<IEnumerable<Voucher>> Get(DateTime from, DateTime to)
        {
            return await afipService.GetVouchers(from, to);
        }
    }
}
