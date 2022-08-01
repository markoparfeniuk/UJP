using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name = "Alice" };
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(50);
            student.AddMark(30);
        }
    }
}