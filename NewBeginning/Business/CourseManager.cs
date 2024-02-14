using NewBeginning.DataAcess.Abstracts;
using NewBeginning.DataAcess.Concretes;
using NewBeginning.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBeginning.Business;

internal class CourseManager
{
    //dependency Injection
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
	{
        //business rules
        
        return _courseDal.GetAll();

	}
}
