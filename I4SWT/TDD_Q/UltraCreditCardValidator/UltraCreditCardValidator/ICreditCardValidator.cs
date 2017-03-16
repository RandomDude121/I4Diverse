using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraCreditCardValidator
{
	public interface ICreditCardValidator
	{
		bool ValidateName(string name);
		bool ValidateCardNumber(string cardNumber);
		bool ValidateExpiryDate(string expiryDate);
		bool ValidateCVV(string cvv);
	}
}
