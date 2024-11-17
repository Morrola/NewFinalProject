using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Models
{
    public class CourseController : Controller
    {

        public ActionResult Index()
        {
            var lstCoursese = new List<CourseModel>
            {
                new CourseModel
                {
                    Id = 1,
                    Title = "Xamarin Forms 4",
                Description = "This is Description for Xamarin Forms courses",
                },
                new CourseModel
                {
                    Id = 2,
                    Title = "Introduction to programing using c#",
                    Description = "This is Description for programing using c#",
                }

             };
            return View(lstCoursese);
        }
    }
}