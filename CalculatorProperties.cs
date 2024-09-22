using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class CalculatorProperties
    {
        int _Number1, _Number2, _Result;

        public int SetNumber1
        {
            set
            {
                _Number1 = value;
            }
            
        }

        public int SetNumber2
        {
            set
            {
                _Number2 = value;
            }
          
        }
        public int GetResult
        {
            
            get
            {
                return _Result;
            }
        }
    }
}
