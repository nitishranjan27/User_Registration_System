using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
As a User need to enter a valid First Name
- First name starts with Cap and has minimum 3 characters
*/

namespace User_Registration_System
{
	public class FirstName
	{
		public static string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

		public bool ValidateFirstName(string fName)
		{
			return Regex.IsMatch(fName, FIRST_NAME_REGEX);
		}
	}
}
