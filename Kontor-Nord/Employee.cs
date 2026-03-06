using System;
namespace Kontor_Nord
{


	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Employee(int id, string name)
		{
			Id = id;
			Name = name;
		}
		public List<EmployeeName> EmployeeNames = new List<EmployeeName>()
		{
			new EmployeeName("Sofie"),
			new EmployeeName("Amir"),
			new EmployeeName("Louise"),
			new EmployeeName("Jonas"),
		};


	}
}