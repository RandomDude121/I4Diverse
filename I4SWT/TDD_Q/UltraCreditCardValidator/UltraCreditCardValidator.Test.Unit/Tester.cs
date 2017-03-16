using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UltraCreditCardValidator.Test.Unit
{
	[TestFixture]
    public class Tester
	{
		private ICreditCardValidator _uut;

		[SetUp]
		public void SetUp()
		{
			_uut = new CreditCardValidator();
		}

        [Category("Name")]
	    [TestCase("Jens Hansen")]
		[TestCase("Bo Jacobsen")]
		[TestCase("Bent Do")]
		public void ValidateName_FirstNameAndLastName_True(string name)
	    {
			Assert.That(_uut.ValidateName(name), Is.True);   
	    }

        [Category("Name")]
        [TestCase("Jens")]
		[TestCase("Hansen")]
		public void ValidateName_OnlyOneName_False(string name)
		{
			Assert.That(_uut.ValidateName(name), Is.False);
		}

        [Category("Name")]
        [TestCase(" Jens Hansen")]
		[TestCase("Jens Hansen ")]
		public void ValidateName_NoSpacesInFrontOrBehind_False(string name)
		{
			Assert.That(_uut.ValidateName(name), Is.False);
		}

        [Category("Name")]
        [TestCase("Jens Hansen0")]
		[TestCase("Jens£ Hansen")]
		[TestCase("0 ee")]
		[TestCase("^ Ee")]
		public void ValidateName_NotLatinLettersOnly_False(string name)
		{
			Assert.That(_uut.ValidateName(name), Is.False);
		}

        [Category("Name")]
        [TestCase("J. Hansen")]
		[TestCase("J Hansen")]
		[TestCase("Jens H.")]
		[TestCase("Jens H")]
		public void ValidateName_NoInitialsAsFirstOrLastName_False(string name)
		{
			Assert.That(_uut.ValidateName(name), Is.False);
		}
		

	}
}
