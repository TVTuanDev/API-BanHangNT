using NiemTin.BanHang.LibCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanHang.Controllers
{
    public class AccountsController : ApiController
    {
        private readonly BanHangEntity _context;
        public AccountsController()
        {
            _context = new BanHangEntity();
        }

        ~AccountsController() { _context.Dispose(); }
    }
}
