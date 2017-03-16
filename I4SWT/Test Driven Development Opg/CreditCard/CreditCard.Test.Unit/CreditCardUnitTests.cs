using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CreditCard.Test.Unit
{

    [TestFixture]
    public class CreditCardUnitTests
    {
        private CCard _uut;
        private string firstName;
        private String lastName;

        [SetUp]
        public void SetUp()
        {

            _uut = new CCard(firstName,lastName);
        }
        [Test]
        public void CCard_IsLatinLettersOnly()
        {
            firstName = "simon121";
            Assert.That(_uut.IsLatinLetter(firstName), Is.EqualTo(firstName.Length));
        }

        [Test]
        public void CCard_ContainsFirstNameAndLastName()
        {
            firstName = "Simon";
            lastName = "Read";
            Assert.That(_uut.GetName().Length, Is.Positive);
        }

        [Test]
        //[ExpectedException(typeof(ArgumentException))]
        public void CCard_FirstNameIsEmpty_ReturnError()
        {
            firstName = null;
            lastName = "Reda";
            Assert.Throws<ArgumentException>(() => _uut.GetName());
        }

        [Test]
        public void CCard_LastNameIsEmpty_()
        {
            firstName = "Simon";
            lastName = null;
            Assert.Throws<ArgumentException>(() => _uut.GetName());
        }
    }
}
