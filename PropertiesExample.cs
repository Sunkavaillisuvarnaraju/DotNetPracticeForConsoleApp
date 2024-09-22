using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class PropertiesExample
    {
        private int _EmpId;
        private string _EmpName;

        public int EmpId 
        {
            set 
            {
                _EmpId = value;
            }

            get 
            {
                return _EmpId;
            }
        }

        public string EmpName
        {
            set 
            {
                _EmpName = value;
            }
            get
            {
                return _EmpName;
            }
        }
    }
}
