using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CreditCard
{
   
    public class CCard
   {
        private String _FirstName { get; set; }
        private String _LastName { get; set; }
        private int ErrorCounter;
        public CCard(String FirstName, String LastName)
        {
            _FirstName = FirstName;
            _LastName = LastName;
        }

        public int IsLatinLetter(String s)
        {
            ErrorCounter = Regex.Matches(s, @"[a-zA-Z]").Count;
            return ErrorCounter;
        }

       public string GetName()
       {
           if (_FirstName == null)
           {
               throw new ArgumentException("Fornavn er null");
           } else if (_LastName == null)
           {
               throw new ArgumentException("Efternavn er null");
           }
           return _FirstName + " " +  _LastName;
       }

    }
}
