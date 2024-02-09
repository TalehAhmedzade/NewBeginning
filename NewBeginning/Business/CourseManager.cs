using NewBeginning.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBeginning.Business;

internal class CourseManager
{
    Course course = new Course();
    //constructor
    public CourseManager()
    {
        course.Id = 1;
        course.Name = "Test";
        course.Price = 10;
        course.Description = "Test testing";
    }
    
    //method
    public void GetAll()
	{

        Console.WriteLine(course.Id+"/"+ course.Name );
	}
}
