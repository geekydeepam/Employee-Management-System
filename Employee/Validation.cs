using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee
{
    public class Validation
    {
        public bool isValidText(string value)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]+$");
            return regex.IsMatch(value);
            
        }
        public bool isValidNumber(string value)
        {
            Regex regex = new Regex(@"^[0-9]{10}$");
            return regex.IsMatch(value);    
        }
    }
}
