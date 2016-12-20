using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public string HelloWorld()
        {
            List<Person> person = new List<Person>(){
                new Person() {Name = "China Mobile", Age = 100, Mobiles = new string[] {"13800138000","10086"}},
                new Person() {Name = "China Telecom", Age = 100, Mobiles = new string[] {"10000","189"}},
                new Person() {Name = "China Unicom", Age = 100, Mobiles = new string[] {"10010"}}
            };

            // 序列化为JSON字串
            string _json = JsonConvert.SerializeObject(person);
            return _json;
        }

        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string[] Mobiles { get; set; }
        }


    }
}
