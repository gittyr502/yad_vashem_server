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
    public class PhotosController : ControllerBase
    {
        [HttpGet]
        public async Task<Photos> getPhotos()
        {
            Photos photos = new Photos();

            using (StreamReader r = new StreamReader("C:\\Users\\user\\Videos\\yad_vashem\\yad_vashem_server\\yad_vashem_server\\photos.json"))
            {
                string json = r.ReadToEnd();
                photos = JsonSerializer.Deserialize<Photos>(json);
            }
            return photos;
        }
    }
}
