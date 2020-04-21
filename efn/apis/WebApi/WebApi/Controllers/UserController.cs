using Orchastrator.User;
using System.Web.Http;
using user = Domain.Layer.User;

namespace WebApi.Controllers
{
    [RoutePrefix("api/v1/user")]
    public class UserController : ApiController
    {
        IUserOrc userOrc;

        [HttpPost]
        [Route("create-user")]
        public IHttpActionResult CreateProduct(user.User user)
        {
            userOrc = new UserOrc();
            return Ok(userOrc.CreateUser(user));
        }
    }
}
