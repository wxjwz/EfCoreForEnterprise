using System;

namespace Store.Core.EntityLayer.HumanResources
{
	public class Employee : IAuditEntity
    {
		public Employee()
		{
		}

        public Employee(Int32? employeeID)
        {
            EmployeeID = employeeID;
        }

		public Int32? EmployeeID { get; set; }

		public String FirstName { get; set; }

		public String MiddleName { get; set; }

		public String LastName { get; set; }

		public DateTime? BirthDate { get; set; }

        public String CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public String LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public Byte[] Timestamp { get; set; }
    }
}
