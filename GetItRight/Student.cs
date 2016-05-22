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

        public Student(int _id, string _name, string _firstName, string _login)
        {
            this.Id = _id;
            this.Name = _name;
            this.FirstName = _firstName;
            this.Login = _login;
        }

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

        public string Save()
        {
            string data = "#Id\n" + this.Id + '\n';
            data += "#Name\n" + this.Name + '\n';
            data += "#FirstName\n" + this.FirstName + '\n';
            data += "#Login\n" + this.Login + '\n';
            return data;
        }

    }
}
