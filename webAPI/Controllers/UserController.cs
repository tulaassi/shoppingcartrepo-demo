using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;
using System.Web.UI.WebControls;
using webAPI.Models;
using webAPI.Repository;




namespace webAPIdemo.Controllers
{
    [RoutePrefix("api/Users")]
    public class userController : ApiController
    {
        IDataRepository<User> _dataRepository;
        public userController()
        {
            this._dataRepository = new UserRepository(new shopingcartEntities());
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<User> GetAllusers()
        {
            var users = _dataRepository.GetAll();
            return users;
        }




    }
}


