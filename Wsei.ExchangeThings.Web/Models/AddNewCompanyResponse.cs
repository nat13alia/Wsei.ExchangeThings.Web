using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wsei.ExchangeThings.Web.Models
{
    public class AddNewCompanyResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public CompanyModel AddedCompany { get; set; }
    }
}
