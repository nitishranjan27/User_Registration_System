using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
As a User need to enter a valid Last Name
- Last name starts with Cap and has minimum 3 characters
*/

namespace User_Registration_System
{
	public class LastName
	{
		public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

		public bool ValidateFirstName(string lName)
		{
			return Regex.IsMatch(lName, LAST_NAME_REGEX);
		}
	}
}
