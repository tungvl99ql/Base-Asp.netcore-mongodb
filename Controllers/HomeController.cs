using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkynetScan.Interface;
using SkynetScan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Nethereum.Web3;
using System.Numerics;

namespace SkynetScan.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IBlock _blockcontext;

        public HomeController(IBlock blockcontext)
        {
            _blockcontext = blockcontext;
        }

        public IActionResult Index()
        {
            var a =  _blockcontext.CountBlock();
            return View();
        }

       
    }
}
