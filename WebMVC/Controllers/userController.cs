using MVCdemo.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public async Task<ActionResult> Index()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("Users"))
                {
                    string apiResponse
                        = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject
                                    <List<UserViewModel>>(apiResponse);
                }
            }
            return View(users);
        }
    }
}






