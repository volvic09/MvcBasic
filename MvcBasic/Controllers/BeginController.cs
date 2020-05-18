using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic.Models;
using System.Diagnostics;

namespace MvcBasic.Controllers
{
    public class BeginController : Controller
    {
      // GET: Begin
      public ActionResult List()
      {
          return View(new List<MvcBasic.Models.Member>() { new Member() { Id = 0, Name = "test", Birth = DateTime.Now, Coment = "Coment Comment" }  });
      }
    }
}