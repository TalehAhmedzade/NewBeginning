﻿using NewBeginning.Business;
using NewBeginning.DataAcess.Abstracts;
using NewBeginning.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewBeginning.DataAcess.Concretes;

public class CourseDal : ICourseDal//Data Acess VB ile elaqe
{
	List<Course> courses ;
	public CourseDal()
	{
		Course course1 = new Course();
		course1.Id = 1;
		course1.Name = "Test1";
		course1.Price = 10;
		course1.Description = "Test testing1";
		Course course2 = new Course();
		course2.Id = 2;
		course2.Name = "Test2";
		course2.Price = 10;
		course2.Description = "Test testing2";
		Course course3 = new Course();
		course3.Id = 3;
		course3.Name = "Test3";
		course3.Price = 10;
		course3.Description = "Test testing3";
		
		courses =new List<Course> {course1,course2,course3};
	}
	public List<Course> GetAll()
	{
		//Data BAse Isleri yerine yetirilir . SQL oyren
		return courses;
	}
	public void Add(Course course)
	{
		courses.Add(course);
	}
}


