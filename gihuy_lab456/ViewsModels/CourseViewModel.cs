﻿using gihuy_lab456.Models;
using gihuy_lab456.ViewsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gihuy_lab456.ViewModel
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        //public object DataTimeStyles { get; private set; }
        public IEnumerable<Category> Categories { get; set; }
        public IQueryable<Course> UpcommingCourses { get; internal set; }
        public bool ShowAction { get; internal set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}