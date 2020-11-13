using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.ExchangeThings.Web.Models;

namespace Wsei.ExchangeThings.Web.Controllers
{
    [Route("api/addingController")]
    [ApiController]
    public class AddingControllercs : ControllerBase
    {
        public AddNewCompanyResponse Post(CompanyModel company)
        {
            var response = new AddNewCompanyResponse()
            {
                Success = true,
                Message = "Got ya",
                AddedCompany = company
            };


            return response;
        }
    }
}
