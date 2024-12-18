using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Login> Get()
        {
            var logins = new List<Login>();
            logins.AddRange(new List<Login>
            { 
                 new Login(1, "hai", "trnaquanghai1301@gmail.com"),
                 new Login(1, "tanh", "trnaquanghai1301@gmail.com"),
                 new Login(1, "quanhg", "trnaquanghai1301@gmail.com"),
                 new Login(1, "aaa", "trnaquanghai1301@gmail.com"),
                 new Login(1, "bbbbb", "trnaquanghai1301@gmail.com")
             });
            
            return logins;
        }
    }
}
