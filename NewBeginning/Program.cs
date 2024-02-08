using NewBeginning.Business;
using NewBeginning.Entities;

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
Course course1 = new Course();
CourseManager manager1 = new();
manager1.GetAll();