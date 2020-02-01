using AfipLoginService;
using AfipServiceClient;
using Domain.Contracts;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AfipService : IAfipService
    {
        private readonly ServiceSoap afipServiceClient;
        private readonly LoginCMS afipLogin;

        public AfipService(ServiceSoap afipServiceClient, LoginCMS afipLogin)
        {
            this.afipServiceClient = afipServiceClient;
            this.afipLogin = afipLogin;
        }

        public async Task<IEnumerable<Voucher>> GetVouchers(DateTime from, DateTime to)
        {
            string loginCmsBase64 = null;

            var auth = await afipLogin.loginCmsAsync(new loginCmsRequest
            {
                in0 = loginCmsBase64
            });

            await afipServiceClient.FECompConsultarAsync(new FECompConsultarRequest { 
                Body = new FECompConsultarRequestBody
                {
                    Auth = new FEAuthRequest
                    {
                        Cuit = 20308592295,
                        Sign = "",
                        Token = ""
                    },
                    FeCompConsReq = new FECompConsultaReq
                    {
                        
                    }
                }
            });

            //await afipServiceClient.

            var response = await afipServiceClient.FECompTotXRequestAsync(new FECompTotXRequestRequest
            {
                Body = new FECompTotXRequestRequestBody
                {
                    Auth = new FEAuthRequest
                    {
                        Cuit = 20308592295,
                        Sign = "",
                        Token = ""
                    }
                }                
            });


            return null;
        }
    }
}
