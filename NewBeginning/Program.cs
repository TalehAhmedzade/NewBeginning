using NewBeginning.Business;
using NewBeginning.DataAcess.Concretes;
using NewBeginning.Entities;
using System;

Console.WriteLine("Sa");
string massage1 = "Life is hard, but you are strong, my brother. JUST DO IT";
int value = 111;
//   start      condition  increment
for(int i = 0; i < value; i++)
{
	Console.WriteLine(massage1);
}
string[] loans = { "Kredit1", "2", "3" };
for(int i = 0;i < loans.Length; i++)
	Console.WriteLine(loans[i]);
string[] loans2 = new string[]
{

};
//create referance 

CourseManager manager1 = new(new EFCourseDal());
List<Course>courses = manager1.GetAll();
for (int i = 0; i < courses.Count; i++)
{
	Console.WriteLine(courses[i].Name);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

// value types-- > int, bool,double...
//reference types --> array, class, interface...
                              //101        //102     //103      //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{

	Console.WriteLine(customer.CustomerNumber);
}
