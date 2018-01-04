using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp {
	class Program {
		static void Main(string[] args) {
			Employee emp = new Employee("Marv", 23, 0, 20000, "321-abc");
			
			// Give the employee a bonus
			emp.GiveBonus(1000);
			emp.DisplayStats();

			Console.ReadLine();
		}
	}
}
