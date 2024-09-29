using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public delegate void ValueReturningType(int Result);
    public class HelperDemo
    {
        private int _Number;
        private ValueReturningType _ValueReturningType;

        public HelperDemo(int Number , ValueReturningType valueReturningType) 
        {
            _Number = Number;
            _ValueReturningType = valueReturningType;
        }

        public void CalculateMethod()
        {
            int Result = 0;
            for (int i = 1; i <= _Number; i++) 
            {
                Result = Result + i;
            }
            _ValueReturningType?.Invoke(Result);
        }
    }
}
