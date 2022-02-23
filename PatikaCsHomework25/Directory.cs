namespace project_1
{
    class Directory
    {
        private string name;

        private string surname;
        private long phoneNumber;

        public Directory(string name, string surname, long phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
    }

}