using IntroR2.DataAccess.Abstracts;
using IntroR2.DataAccess.Concretes;
using IntroR2.Entities;

namespace IntroR2.Business;

public class CourseManager
{
    //DEPENDENCY INJECTION 
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)  //NEWLENEN şey interface i içeren methodu vermek zorunda 
    {
        //Course ı new leyen yöntemi söylemek zorunda 
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // Business Rules
       
        return _courseDal.GetAll();
    }
}