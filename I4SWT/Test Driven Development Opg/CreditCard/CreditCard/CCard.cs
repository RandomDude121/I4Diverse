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
        private String _FirstName;
        private int ErrorCounter;
        public CCard(String FirstName)
        {
                _FirstName = FirstName;
        }

        public int IsLatinLetter(String s)
        {
            ErrorCounter = Regex.Matches(s, @"[a-zA-Z]").Count;
            return ErrorCounter;
        }
    }
}
