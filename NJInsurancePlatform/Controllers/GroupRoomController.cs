using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;


namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous]
    public class GroupRoomController : Controller
    {
        private readonly InsuranceCorpDbContext InsuranceCorpDbContext;

        public GroupRoomController(InsuranceCorpDbContext InsuranceCorpDbContext)
        {
            this.InsuranceCorpDbContext = InsuranceCorpDbContext;
        }
    }
}

