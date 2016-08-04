using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contracts
{
    public interface IStudent
    {
        void JoinCourse(Course course);
        void LeaveCourse(Course course);
    }
}
