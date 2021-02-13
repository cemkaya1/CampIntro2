using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // this part is written static
            string course1 = "Yazilim Gelistirici Yetistirme Kampi";
            string course2 = "Programlamaya Baslangic icin Temel Kurs";
            string course3 = "Java Ogreniyorum Kursu";

            // array
            // To make dynamic the program arrays are good tool
            string[] courses = 
            {
                "Yazilim Gelistirici Yetistirme Kampi",
                "Programlamaya Baslangic icin Temel Kurs",
                "Java Ogreniyorum Kursu",
                "Python Ogreniyorum Kursu"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("\nFor finished\n");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("\nPage end - footer");
        }
    }
}
