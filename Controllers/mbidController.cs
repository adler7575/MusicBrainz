using System;
using System.Net.Http;
using System.Threading.Tasks;
using musicbrainz.Models;
using Microsoft.AspNetCore.Mvc;


namespace musicbrainz.Controllers
{
    [Route("api/MbidController")]
    [ApiController]
    public class MbidController : ControllerBase
    {
        // http://musicbrainz.org/ws/2/artist/5b11f4ce-a62d-471e-81fc-a69a8278c7da?&fmt=json&inc=url-rels+release-groups
        public MbidController()
        {       
            
        }

        // GET api/MbidC/??
        [HttpGet("{id}")]
        public object Get(string id)
        {
            string responseBody = "Not Found";
            
            try {


                MBIdRequest MBIdR = new MBIdRequest();
                MBIdR.DoSearch(id);

            }
            catch (Exception err)
            {


            }
            return responseBody;
        }


    }
}
