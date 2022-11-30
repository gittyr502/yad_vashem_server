using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using yad_vashem_server.Models;

namespace yad_vashem_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LeftController : ControllerBase
    {
        [HttpGet]  
        public async Task<Left> getLeft()
        {
            Left left = new Left();

            using (StreamReader r = new StreamReader("C:\\Users\\user\\Videos\\yad_vashem\\yad_vashem_server\\yad_vashem_server\\left.json"))
            {
                string json = r.ReadToEnd();
                left = JsonSerializer.Deserialize<Left>(json);
            }
            return left;
        }
    }
}
