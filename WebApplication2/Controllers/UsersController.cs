using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class UsersController : ApiController
    {

        /// <summary>
        /// User Data List
        /// </summary>
        private readonly List<Users> _userList = new List<Users>
        {
            new Users {UserID = 1, UserName = "Superman", UserEmail = "Superman@cnblogs.com"},
            new Users {UserID = 2, UserName = "Spiderman", UserEmail = "Spiderman@cnblogs.com"},
            new Users {UserID = 3, UserName = "Batman", UserEmail = "Batman@cnblogs.com"}
        };

        // GET api/Users
        public IEnumerable<Users> Get()
        {
            return _userList;
        }

        // GET api/Users/5
        public Users GetUserByID(int id)
        {
            var user = _userList.FirstOrDefault(users => users.UserID == id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
        }

        //GET api/Users/?username=xx
        public IEnumerable<Users> GetUserByName(string userName)
        {
            return _userList.Where(p => string.Equals(p.UserName, userName, StringComparison.OrdinalIgnoreCase));
        }

        //[HttpPost]
        //public ResultMessage Add(dynamic obj)
        //{
        //    System.Web.HttpRuntime.Cache.Insert("1", 2, null, DateTime.Now.AddDays(1), TimeSpan.Zero);

        //    UsersClass uc = new UsersClass();

        //    var obj1 = uc.GetAll();


        //    return new ResultMessage() { State=0,Msg = "正常" };
        //}

        [HttpPost]
        //public List<Users> Add([FromBody]Users obj)
        public List<Users> Add(dynamic obj)
        {
            System.Web.HttpRuntime.Cache.Insert("1", 2, null, DateTime.Now.AddDays(1), TimeSpan.Zero);

            UsersClass uc = new UsersClass();

            //uc.AddUsers();

            //uc.DelUsers(3);

            //uc.UpdateUsers(4);
            if (System.Web.HttpContext.Current.Session["aaa"] != null)
            {
                var bbb = System.Web.HttpContext.Current.Session["aaa"].ToString();
            }
            System.Web.HttpContext.Current.Session["aaa"] = "123";

            var cacheValue = System.Web.HttpRuntime.Cache["aaa"];

            //System.Xml.Schema.Token token = (System.Xml.Schema..Token)HttpRuntime.Cache.Get(id.ToString());

            System.Web.HttpRuntime.Cache.Remove("aaa");

            System.Web.HttpRuntime.Cache.Insert("aaa", "123");

            return uc.GetUsersByPagnation(2, 5);  //uc.GetAll();
        }


    }

    public class ResultMessage
    {
        public int State { get; set; }

        public string Msg { get; set; }
    }


}
