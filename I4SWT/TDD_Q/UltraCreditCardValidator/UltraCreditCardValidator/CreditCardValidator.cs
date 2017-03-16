using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UltraCreditCardValidator
{
	public class CreditCardValidator : ICreditCardValidator
	{
		public bool ValidateName(string name)
		{
			if (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
				return false;
			if (!name.Contains(" "))
				return false;
			if (name.StartsWith(" ") || name.EndsWith(" "))
				return false;

			var names = name.Split(' ');

			if (names.First().Length < 2)
				return false;
			if (names.Last().Length < 2)
				return false;

			return true;
		}

		public bool ValidateCardNumber(string cardNumber)
		{
			throw new NotImplementedException();
		}

		public bool ValidateExpiryDate(string expiryDate)
		{
			throw new NotImplementedException();
		}

		public bool ValidateCVV(string cvv)
		{
			throw new NotImplementedException();
		}
	}
}