using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IAfipService
    {
        Task<IEnumerable<Voucher>> GetVouchers(DateTime from, DateTime to);
    }
}
