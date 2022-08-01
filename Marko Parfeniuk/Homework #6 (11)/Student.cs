using System.Collections.Generic;

namespace homework
{
    public delegate void MyDel(int m);

    class Student
    {
        string name = "Alice";
        List<int> marks = new List<int>();

        public event MyDel MarkChange;

        public void AddMark(int newMark)
        {
            MarkChange?.Invoke(newMark);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<int> Marks
        {
            get { return marks; }
        }
    }
}
