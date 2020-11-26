using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.ExchangeThings.Web.Database;
using Wsei.ExchangeThings.Web.Models;
using Wsei.ExchangeThings.Web.Entities;

namespace Wsei.ExchangeThings.Web.Controllers
{
    [ApiController]
    [Route("api/addingController")]
    public class AddingControllercs : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;

        public AddingControllercs(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public AddNewCompanyResponse Post(CompanyModel company)
        {

            var entity = new ItemEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return new AddNewCompanyResponse()
            {
                Success = true,
                Message = "Got ya",
                AddedCompany = company
            };
    }
}
}
