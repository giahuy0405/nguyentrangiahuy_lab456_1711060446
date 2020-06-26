using gihuy_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gihuy_lab456.ViewsModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}