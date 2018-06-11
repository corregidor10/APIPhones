using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace TajamarApiReact.Controllers
{
    [Produces("application/json")]
    [Route("api/Phones")]
    public class PhonesController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<Phone>> Get()
        {
            var service = new PhoneService();
            return await service.GetPhones();
        }

        [HttpGet("{id}")]
        public async Task<PhoneDetail> GetById(int id)
        {
            var service = new PhoneService();
            return await service.GetPhoneDetail(id);
        }
    }
}