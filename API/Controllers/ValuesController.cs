using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient.Memcached;
using Dapper;
using Models.LJX;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static string conn = "Data Source=YANGHAO;Initial Catalog=Houses;User ID=sa;pwd=123456;";

        public MYDBContext db;
        public ValuesController(MYDBContext db) { this.db = db; }
        //public List<UserModel> Show()
        //{
        //    string sql = "select * from Users";
        //    using (SqlConnection connection = new SqlConnection(conn))
        //    {
        //        List<UserModel> list = connection.Query<UserModel>(sql).ToList();
        //        return list;
        //    }
        //}
    }
}
