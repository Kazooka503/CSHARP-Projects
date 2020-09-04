using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TechUniversity.Models;

namespace TechUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstMidName="Jim",LastName="Harris",EntrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3, },
                new Course{CourseID=4022,Title="Microeconomics",Credits=3, },
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3, },
                new Course{CourseID=1045,Title="Intro To Marxism",Credits=3, },
                new Course{CourseID=3141,Title="Computer Science", Credits=3, },
                new Course{CourseID=2042,Title="Ethical Hacking", Credits=3, }
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=1045,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=3141,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=2042,Grade=Grade.A}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges(); 
        }
    }
}