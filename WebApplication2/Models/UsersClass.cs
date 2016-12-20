using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UsersClass
    {

        IDbContext context = null;
        public UsersClass()
        {
            context = new DbContext().ConnectionStringName("DemoDB", new SqlServerProvider());
        }

        public List<Users> GetAll()
        {
            var obj = context.Sql("select * from Users").QueryMany<Users>();
            return obj;
        }

        public List<Users> GetUsersByPagnation(int pageIndex, int limit)
        {
            var obj = context.Select<Users>("userid,userName,Age,Details")
                .From("Users")
                .OrderBy("userid desc")
                .Paging(pageIndex, limit).QueryMany();
            return obj;
        }


        public int AddUsers()
        {
            Users u = new Users()
            {
                UserName = "CCC",
                Age = 23,
                Details = "信息"
            };
            int result = context.Insert("Users").Column("UserName", u.UserName)
                .Column("Age", u.Age)
                .Column("Details", u.Details)
                .Execute();

            return result;
        }

        public int DelUsers(int id)
        {
            int result = context.Delete("Users")
                .Where("UserId", id)
                .Execute();
            return result;
        }

        public int UpdateUsers(int id)
        {
            int result = context.Update("Users")
                .Column("UserName", "SSSDDDD")
                .Where("UserId", id)
                .Execute();
            return result;
        }


        public void TransMethod()
        {
            using (var cc = context.UseTransaction(true))
            {
                cc.Commit();
            }
        }




    }
}