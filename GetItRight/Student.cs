using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GetItRight
{
    public class Student
    {
        public int Id;
        public string Name;
        public string FirstName;
        public string Login;
        public string Data;

        public Student() {}

        public void MakeData(string decision, string data)
        {
            string head = header(decision.Length, '=');
            this.Data =   head + '\n'
                        + decision + '\n'
                        + head + '\n'
                        + data;
        }

        private string header(int len, char motif)
        {
            return (len == 0) ? "" : motif+header(len - 1, motif);
        }

    }
}
