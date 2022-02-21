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
            set { _Identifier = value;  }
        }


        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value;  }
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




        //Méthodes
        var Contact = new List<string>(Contact);
        Contact.Add("New York");
cities.Add("London");
cities.Add("Mumbai");
cities.Add("Chicago");
cities.Add(null);// nulls are allowed for reference type list




        static void Main(string[] args)
        {
            Livre Livre1 = new Livre("Livre1", "nnnnnnn", 50);
            Console.WriteLine("Vous lisez {0}, qui fait {1} pages.\n\nContenu:\n{2}\n", Livre1.Title, Livre1.PageCount, Livre1.Contenu);
            Livre1.Read();
            Console.WriteLine("Nblectures : {0}", Livre1.ReadCount);
        }
    }
}






