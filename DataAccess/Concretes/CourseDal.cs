using IntroR2.DataAccess.Abstracts;
using IntroR2.Entities;

namespace IntroR2.DataAccess.Concretes;

public class CourseDal : ICourseDal // dal : Data Access Layer
{
    List<Course> courses;
    
    public CourseDal() //Constructor
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".net8..";
        course1.Price = 0;
        
        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "java17..";
        course2.Price = 10;
        
        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "python";
        course3.Description = "python 3.12..";
        course3.Price = 15;

        courses = new List<Course> { course1, course2, course3 };

    }
    public List<Course> GetAll()
    {
        //DB işlemleri yapılır.

        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
    
}


