namespace SwaggerDemo.Controllers
{
    #region Using Directives
    using SwaggerDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    #endregion

    public class UsersController : ApiController
    {
        User[] users = new User[]{ new User{Age=32,Name="Murat",SurName="Tatar"},
                                    new User{Age=32,Name="Fuat",SurName="Tatar"}};

        public IEnumerable<User> GetAllProducts() 
        {
            return users;
        }

    }
}
