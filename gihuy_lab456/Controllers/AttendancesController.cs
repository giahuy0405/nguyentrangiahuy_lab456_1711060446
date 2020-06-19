using gihuy_lab456.DTOs;
using gihuy_lab456.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gihuy_lab456.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public object AttendeeId { get; private set; }
        public string UserId { get; private set; }

        [HttpPost]
        public IHttpActionResult Follow(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == FollowingDto.FollweeId))
                return BadRequest("The Attendance already exists!");
            var attendance = new Attendance
            {
                FollowerId = userId,
                FolloweeId = FollowingDto.FollweeId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
        
    }
}
