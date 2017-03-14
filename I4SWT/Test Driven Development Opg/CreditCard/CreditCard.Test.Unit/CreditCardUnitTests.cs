using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CreditCard.Test.Unit
{

    [TestFixture]
    public class CreditCardUnitTests
    {
        private CCard _uut;
        private string firstName;

        [SetUp]
        public void SetUp()
        {

            _uut = new CCard(firstName);
        }
        [Test]
        public void CCard_IsLatinLettersOnly()
        {
            firstName = "simon121";
            Assert.That(_uut.IsLatinLetter(firstName), Is.EqualTo(firstName.Length));
        }
    }
}
