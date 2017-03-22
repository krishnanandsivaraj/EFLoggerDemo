using ProfilerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using EFlogger.EntityFramework6;

namespace ProfilerApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            EFloggerFor6.Initialize();
            EFloggerFor6.StartSendToClient();

            using (var test = new testEntities()) {
                var updatedUser = test.students.SingleOrDefault(x => x.StudentName == "John");
            }

            using (var test = new testEntities())
            {
                var updatedUser = test.students.SingleOrDefault(x => x.StudentName == "Jane");
            }

            using (var test = new testEntities())
            {
                var updatedUser = test.students.SingleOrDefault(x => x.Grade == "3");
            }

            using (var test = new testEntities())
            {
                var updatedUser = test.students.SingleOrDefault(x => x.Grade == "4");
            }

            using (var test = new testEntities())
            {
                var updatedUser = test.students.SingleOrDefault(x => x.StudentDescription == "John Doe");
            }

            using (var test = new testEntities())
            {
                var updatedUser = test.students.SingleOrDefault(x => x.StudentDescription == "Jane Austin");
            }
            EFloggerFor6.StopSendToClient();
            return View();
            
        }
    }
}
