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


        Livre L1 = new Livre("Le petit prince", "lorem ipsum", 120);
        char r;
            do
            {
                Console.WriteLine("Vous lisez {0}, d'une longueur de {1} pages.\n\nContenu du livre :\n{2}\n", L1.title, L1.pageCount, L1.content);
                L1.Read();
                Console.WriteLine("Nombre de lectures : {0}", L1.readCount);
                Console.WriteLine("Voulez-vous relire le livre ? (O/N)");
                r = Convert.ToChar(Console.ReadLine());
            } while (r is 'O' or 'o');



        }
    }
}
