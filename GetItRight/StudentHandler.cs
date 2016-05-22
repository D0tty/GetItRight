using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GetItRight
{
    public class StudentHandler
    {
        List<Student> Students;
        private int _lenght;

        public int Lenght
        {
            get { return _lenght; }
            private set { }
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

        public void AddStudent(string _filestudent)
        {
            string[] attribs = _filestudent.Split('\n');
            this.Students.Add(new Student(Int32.Parse(attribs[1]),attribs[3],attribs[5],attribs[7]));
            this.Students[this.Lenght].Id = this.Lenght;
            UpdateLength();
        }

        private void UpdateLength()
        {
            this._lenght ++;
        }

        public void PopLast()
        {
            this.Students.RemoveAt(this._lenght - 1);
        }

        public void SaveList(string filename)
        {
            if (!File.Exists(".\\" + filename))
            {
                string data = string.Empty;
                for (int i = 0; i < this._lenght - 1; i++)
                {
                    data += this.Students[i].Save() + '\f';
                }
                data += this.Students[this._lenght - 1].Save();
                FileStream fs = new FileStream("." + "\\" + filename, FileMode.Create);
                byte[] bytedata = Encoding.ASCII.GetBytes(data);
                fs.Write(bytedata, 0, bytedata.Length);
                fs.Close();
                MessageBox.Show(@"List Saved to " + filename + @" correctly");
            }
            else
            {
                MessageBox.Show(@"Error with the filename");
            }
        }

        public bool LoadList(string filename)
        {
            if (File.Exists(".\\" + filename))
            {
                FileStream fs = new FileStream(".\\" + filename, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();
                string[] file = Encoding.ASCII.GetString(data).Split('\f');
                for (int i = 0; i < file.Length; i++)
                {
                    this.AddStudent(file[i]);
                }
                return true;
            }
            else
            {
                MessageBox.Show(@"Error: " + filename + @" does not exist");
                return false;
            }
        }
    }
}
