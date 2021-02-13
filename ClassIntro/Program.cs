using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Trainer = "Engin Demirog";
            course1.TotalView = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Trainer = "Ahmet Mehmet";
            course2.TotalView = 190;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Trainer = "Kerem Sariturk";
            course3.TotalView = 488;

            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.Trainer = "Alieksander Kaya";
            course4.TotalView = 312;

            // Console.WriteLine(course1.CourseName + " : " + course1.Trainer);

            Course[] courses = new Course[]
            {
                course1,
                course2,
                course3,
                course4
            };

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Trainer);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Trainer { get; set; }
        public int TotalView { get; set; }

    }
}
