using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassEnum
{
    public static class Program
    {
        public static void Main()
        {
            List<CourseType> schoolsubjects = new List<CourseType>()
            {
                new CourseType { Description = "Beginner Algebra", Name = "Algebra 1", Subject = CourseSubject.Math },
                new CourseType { Description = "Freshman English", Name = "English 1", Subject = CourseSubject.English },
                new CourseType { Description = "Freshman Biology", Name = "Biology 1", Subject = CourseSubject.Biology },
                new CourseType { Description = "Freshman Psychology", Name = "Psychology 1", Subject = CourseSubject.Psychology },
                new CourseType { Description = "Freshman Geography", Name = "Geography 1", Subject = CourseSubject.Geography },
                new CourseType { Description = "Early Human History", Name = "Neanderthal History", Subject = CourseSubject.WorldHistory },
                new CourseType { Description = "Beginner Physics", Name = "Physics 1", Subject = CourseSubject.Physics },
                new CourseType { Description = "Beginner Spanish", Name = "Spanish 1", Subject = CourseSubject.Spanish },
            };

            // string[] courses = Enum.GetNames(typeof(CourseSubject));

            List<CourseType>.Enumerator e = schoolsubjects.GetEnumerator();

            while (e.MoveNext())
            {
                GetCourseSubjectName(e.Current.Subject);
            }
           

            //GetCourseSubjectName(CourseSubject.Math);

           

            Console.ReadLine();
        }


        public static string GetCourseSubjectName(CourseSubject subject)
        {

            Console.WriteLine(subject.ToString());
            return subject.ToString();

            //return the enum subject as a string. IOW, if you pass in CourseSubject.Math, the method should return "Math".
        }
    }



    public class CourseType
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public CourseSubject Subject { get; set; }
    }


    //Create an enum named CourseSubject. 
    //It should contain at least 8 subjects, two of which must be Geography and WorldHistory
    public enum CourseSubject
    {
        Math,
        English,
        Biology,
        Psychology,
        Geography,
        WorldHistory,
        Physics,
        Spanish
        
    }

}
