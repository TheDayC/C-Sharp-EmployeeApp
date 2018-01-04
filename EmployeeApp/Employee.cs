using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp {
	class Employee {
		// Field data
		private string empName;
		private int empID;
		private float currPay;
		private int empAge;
		private string empSSN;

		// Constructors
		public Employee() { }
		public Employee(string name, int age, int id, float pay, string ssn) {
			Name = name;
			ID = id;
			Pay = pay;
			Age = age;

			// Have to use member variable to assign data on construction to read only var
			empSSN = ssn;
		}

		// Methods
		public void GiveBonus(float amount) {
			Pay += amount;
		}

		public void DisplayStats() {
			Console.WriteLine("Name: {0}", Name);
			Console.WriteLine("ID: {0}", ID);
			Console.WriteLine("Age: {0}", Age);
			Console.WriteLine("Pay: {0}", Pay);
			Console.WriteLine("Social Security Number: {0}", SocialSecurityNumber);
		}

		// Properties
		public string Name {
			get { return empName; }
			set {
				// Make a check on incoming value before assignment.
				if (value.Length > 15) {
					Console.WriteLine("Error! Name length exceeds 15 characters!");
				} else {
					empName = value;
				}
			}
		}

		public int ID {
			get { return empID; }
			set { empID = value; }
		}

		public float Pay {
			get { return currPay; }
			set { currPay = value; }
		}

		public int Age {
			get { return empAge; }
			set { empAge = value; }
		}

		// Read only prop
		public string SocialSecurityNumber {
			get { return empSSN; }
		}
	}
}
