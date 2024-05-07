using FIXED_ASSET_CONTROL_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIXED_ASSET_CONTROL_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : Controller
    {
        private SqlConnectDB SQL = new SqlConnectDB("SQL_DATABASE_NAME");
        [HttpGet]
        [Route("/get")]
        public IActionResult GetData(string param)
        {

            return Ok();
        }

        [HttpPost]
        [Route("/post")]
        public IActionResult PostData([FromBody] ModelExample  param)
        {
            return Ok();
        }
    }
}
