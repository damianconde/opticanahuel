using Domain.Contracts;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AfipService : IAfipService
    {
        public async Task<IEnumerable<Voucher>> GetVouchers(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
