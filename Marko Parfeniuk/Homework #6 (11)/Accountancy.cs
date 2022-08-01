using System;
using System.Linq;

namespace homework
{
    class Accountancy : Student
    {
        const int PositiveMark = 71;

        public void PayingFellowship(int newMark)
        {
            base.Marks.Add(newMark);
            Console.WriteLine(base.Marks.Sum() > PositiveMark
                ? $"Congratulations! Student {base.Name} was awarded a scholarship."
                : $"Student {base.Name} was not awarded a scholarship, :(");
        }
    }
}
