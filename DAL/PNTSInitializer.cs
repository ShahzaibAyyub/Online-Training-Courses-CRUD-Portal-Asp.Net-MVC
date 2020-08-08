using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PNTS.Models;
namespace PNTS.DAL
{
    public class PNTSInitializer : System.Data.Entity.
    DropCreateDatabaseIfModelChanges<PNTSContext>
    {
        protected override void Seed(PNTSContext context)
        {
            var users = new List<User>
            {
                new User{FirstMidName="Huda",LastName="Abid"},
                new User{FirstMidName="Shahzaib",LastName="Ayyub"},
                new User{FirstMidName="Hamza",LastName="Zafar"},
            };
            

            var courses = new List<Course>
            {
                new Course {CourseID=1,Title="Selenuim", DeliveryMethod="Online", Price=10000, Duration=3},
                new Course {CourseID=2,Title="MachineLearning", DeliveryMethod="Online", Price=15000, Duration=2},
                new Course {CourseID=3,Title="EthicalHacking", DeliveryMethod="Online", Price=20000, Duration=1},
                new Course {CourseID=4,Title="DataScience", DeliveryMethod="Online", Price=25000, Duration=4},
                new Course {CourseID=5,Title="DevOpsEngineer", DeliveryMethod="On Site", Price=10000, Duration=3},
                new Course {CourseID=6,Title="Javascript", DeliveryMethod="On Site", Price=15000, Duration=2},
                new Course {CourseID=7,Title="PostGreSQL", DeliveryMethod="On Site", Price=20000, Duration=5},
                new Course {CourseID=8,Title="PythonScripting", DeliveryMethod="On Site", Price=25000, Duration=6}
            };
            

            var registartions = new List<Register>
            {
                new Register{UserID=1,CourseID=1},
                new Register{UserID=2,CourseID=2},
                new Register{UserID=3,CourseID=3},
            };
            users.ForEach(s => context.Users.Add(s)); context.SaveChanges();
            courses.ForEach(s => context.Courses.Add(s)); context.SaveChanges();
            registartions.ForEach(s => context.Registrations.Add(s)); context.SaveChanges();
           
        }
    }
}

