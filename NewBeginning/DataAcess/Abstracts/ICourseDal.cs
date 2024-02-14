using NewBeginning.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBeginning.DataAcess.Abstracts;

public interface ICourseDal
{
	List<Course> GetAll();
	public void Add(Course course);
}