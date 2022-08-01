using System;
using System.Collections.Generic;
using System.Linq;
namespace homework
{
    class Parent : Student
    {
        public void OnMarkChange(int newMark)
        {
            Console.WriteLine("{0} got a new mark: {1}", base.Name, newMark);
        }
    }
}
