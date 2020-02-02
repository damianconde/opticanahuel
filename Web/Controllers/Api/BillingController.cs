using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BillingApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly ILogger<BillingController> _logger;
        private readonly IBillingService billingService;

        public BillingController(ILogger<BillingController> logger, IBillingService billingService)
        {
            _logger = logger;
            this.billingService = billingService;
        }

        [HttpGet]
        public async Task<ActionResult<dynamic>> Get([FromQuery] DateTime? from, [FromQuery] DateTime? to)
        {
            try
            {
                return Ok(await billingService.Get(from.GetValueOrDefault(), to.GetValueOrDefault()));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { 
                    Error = ex.Message
                });
            }
            
        }
    }
}
