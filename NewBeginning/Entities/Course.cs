﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBeginning.Entities;

public class Course
{
	//property
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
    public int Price { get; set; }
}