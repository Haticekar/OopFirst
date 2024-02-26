using IntroR2.Entities;

namespace IntroR2.DataAccess.Abstracts;

public interface ICourseDal // Implement e edilen sınıf Method İmzalarını içermek zorunda.
{
    //Method İmzası
    List<Course> GetAll();

    void Add(Course course);
}