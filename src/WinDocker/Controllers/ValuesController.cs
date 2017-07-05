using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WinDocker.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string result;
            try
            {
                var httpClient = new HttpClient();
                result = await httpClient.GetStringAsync("http://linuxdocker/api/values");
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return Json(new { FromLinux = result });
        }
    }
}