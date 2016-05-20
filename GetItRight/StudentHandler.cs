using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetItRight
{
    public class StudentHandler
    {
        List<Student> Students;
        private int _lenght;
        public int Lenght
        {
            get { return _lenght; }
            private set {}
        }

        public StudentHandler()
        {
            this.Students = new List<Student>();
            this.Lenght = 0;
        }

        public Student this[int index]
        {
            get { return this.Students[index]; }
            set { this.Students[index] = value; }
        }

        public void AddStudent()
        {
            this.Students.Add(new Student());
            this.Students[this.Lenght].Id = this.Lenght;
            UpdateLength();
        }

        private void UpdateLength()
        {
            this._lenght ++;
        }

    }
}
