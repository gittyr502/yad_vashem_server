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
    public class RescueController : ControllerBase
    {
        [HttpGet]
        public async Task<Rescue> getRescue()
        {
            Rescue rescue = new Rescue();

            using (StreamReader r = new StreamReader("C:\\Users\\user\\Videos\\yad_vashem\\yad_vashem_server\\yad_vashem_server\\rescue.json"))
            {
                string json = r.ReadToEnd();
                rescue = JsonSerializer.Deserialize<Rescue>(json);
            }
            return rescue;
        }
    }
}
