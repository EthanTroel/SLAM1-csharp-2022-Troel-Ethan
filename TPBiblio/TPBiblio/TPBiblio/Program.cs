using System;

namespace TPBiblio
{
    class Livre
    {
        private string _Title;


        private string _Contenu;

        private int _PageCount;


        private int _ReadCount;


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


        public void Read()
        {
            string ContenuLivre = Title + Contenu + PageCount;
            ReadCount = ReadCount++;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Vous lisez {0} ,{1} et qui fait {2}");



        }
    }
}
