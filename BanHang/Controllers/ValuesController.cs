using NiemTin.BanHang.LibCore.Entity;
using NiemTin.BanHang.LibCore.Model.ModelNew;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;

namespace BanHang.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Test(int? id)
        {
            id = id == null ? 1 : id;
            BanHangEntity _db = new BanHangEntity("AppDbLocal");

            var user = await _db.Users.Include(u => u.UserRole).FirstOrDefaultAsync(u => u.UserID == id);
            if (user == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                Status = 200,
                Message = "Test success",
                Data = user
            });
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
