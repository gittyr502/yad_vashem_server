using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using yad_vashem_server.Models;

namespace yad_vashem_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        [HttpGet]
        public async Task<Names> getNames()
        {
            Names names = new Names();

            using (StreamReader r = new StreamReader("C:\\Users\\user\\Videos\\yad_vashem\\yad_vashem_server\\yad_vashem_server\\names.json"))
            {
                string json = r.ReadToEnd();
                names = JsonSerializer.Deserialize<Names>(json);
            }
            return names;
        }
    }
}
