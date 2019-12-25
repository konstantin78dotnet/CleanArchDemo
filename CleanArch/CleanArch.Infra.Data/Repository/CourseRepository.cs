using CleanArch.Demo.Models;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx) 
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
