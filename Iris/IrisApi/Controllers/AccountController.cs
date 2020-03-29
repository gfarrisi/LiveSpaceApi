using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IrisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // GET: api/account/
        [HttpGet]
        public string Get()
        {
            return "Test Response!";
        }

        // GET: api/account/
        [HttpGet("GetAllAccounts")]
        public string GetAllAccounts()
        {
            List<string> account = new List<string>();
            account.Add("Anthony");
            account.Add("Brian");
            account.Add("Ellie");

            string jsonAccounts = JsonConvert.SerializeObject(account);
            return jsonAccounts;
        }

        // GET: api/account/
        [HttpGet("GetAccount/{id}")]
        public string GetAccount(int id)
        {
            if(id == 1)
            {
                return "Gabriella Farrisi";
            }
            return null;
        }
    }
}