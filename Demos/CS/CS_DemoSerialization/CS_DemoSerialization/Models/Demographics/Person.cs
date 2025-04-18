using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DemoSerialization.Models.Demographics
{
	[Serializable]
    public class Person
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private DateTime dob;

		public DateTime DOB
		{
			get { return dob; }
			set { dob = value; }
		}

		public int Age => DateTime.Now.Year - DOB.Year;

	}
}
