using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gihuy_lab456.DTOs
{
    public class AttendanceDto
    {
        public int CourseId { get; set; }

        public static implicit operator int(AttendanceDto v)
        {
            throw new NotImplementedException();
        }
    }
}