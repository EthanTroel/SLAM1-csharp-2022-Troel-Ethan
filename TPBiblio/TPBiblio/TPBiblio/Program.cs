using System;

namespace TPBiblio
{
    class Livre
    {
        private string _Title;


        private string _Contenu;

        private int _PageCount;


        private int _ReadCount;

        public Livre(string v1, string v2, int v3)
        {
        }

        public int ReadCount
        {
            get { return _ReadCount; }
            set { _ReadCount = value; }
        }



        public string Title
        {
            get { return _Title; }
        }


        public string Contenu
        {
            get { return _Contenu; }
        }


        public int PageCount
        {
            get { return _PageCount; }
        }


        public string Read()
        {
            _ReadCount++;
            return _Contenu;
        }



        static void Main(string[] args)
        {
            Livre Livre1 = new Livre("Livre1", "nnnnnnn", 50);
                Console.WriteLine("Vous lisez {0}, qui fait {1} pages.\n\nContenu:\n{2}\n", Livre1.Title, Livre1.PageCount, Livre1.Contenu);
                Livre1.Read();
                Console.WriteLine("Nblectures : {0}", Livre1.ReadCount);
                DateTime date = DateTime.Now;
                TimeSpan time = new TimeSpan(36, 0, 0, 0);
                DateTime combined = date.Add(time);
        }
    }
}
