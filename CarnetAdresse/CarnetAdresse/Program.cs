using System;

namespace CarnetAdresse
{
    //Attributs
    class Contact
    {
        private string _Identifier;


        private string _Lastname;

        private string _Firstname;


        private int _Phone;
        private string _Email;

        private DateTime _BirthDay;

        private string _IsProfessional;

        private int _ContactedCount;




        //Propriétés

        public int ContactedCount
        {
            get { return _ContactedCount; }
            set { _ContactedCount = value; }
        }


        public string Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }


        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }


        public int Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }


        public string IsProfessional
        {
            get { return _IsProfessional; }
            set { _IsProfessional = value; }
        }


    }

        //Méthodes
        public string ContactedCount()
    {
        _ContactedCount++;
        return _ContactedCount;
    }




        static void Main(string[] args)
        {
        Contact Contact1 = new Contact("Contact1", "nnnnnnn", );
        Contact Contact2 = new Contact("Contact1", "nnnnnnn", );
        Contact Contact3 = new Contact("Contact1", "nnnnnnn", );
        Contact Contact4 = new Contact("Contact1", "nnnnnnn", );
        Contact Contact5 = new Contact("Contact1", "nnnnnnn", );
        Contact Contact6 = new Contact("Contact1", "nnnnnnn", );
        Contact Contact7 = new Contact("Contact1", "nnnnnnn", );
        Console.WriteLine();
        Contact1.Read();
        Console.WriteLine();
    }
    }
}






