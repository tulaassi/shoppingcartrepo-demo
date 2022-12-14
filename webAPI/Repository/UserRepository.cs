using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webAPI.Models;

namespace webAPI.Repository
{
    public class UserRepository :IDataRepository<User>

    {
        shopingcartEntities _userdbcontext;
    public UserRepository(shopingcartEntities userdbcontext)
    {
        _userdbcontext = userdbcontext;
    }
    public IEnumerable<User> GetAll()
    {
        return _userdbcontext.Users.ToList();

    }
   }
}
