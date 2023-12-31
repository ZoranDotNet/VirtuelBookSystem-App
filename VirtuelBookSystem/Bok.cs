﻿namespace VirtuelBookSystem
{
    internal class Bok : Media, IUtlanbar
    {
        public string Titel { get; set; }
        public string Författare { get; set; }

        public string ISBN { get; set; }

        public Bok(string titel, string författare, string iSBN)
        {
            Titel = titel;
            Författare = författare;
            ISBN = iSBN;
        }
        public Bok()
        {

        }


        public override void SpelaUpp()
        {
            Console.WriteLine("Boken är analog, går inte att spela upp");
        }

        public override void VisaInfo()
        {
            Console.WriteLine($"Titel: {Titel} \nFörfattare: {Författare} \nISBN: {ISBN}");
        }

        public virtual void SkrivUtInfo()
        {
            Console.WriteLine($"Titel: {Titel} \nFörfattare: {Författare} \nISBN: {ISBN}");
        }

        public void LanaUt()
        {
            Console.WriteLine("Bok utlånad");
        }

        public void Aterlamna()
        {
            Console.WriteLine("Bok återlämnad");
        }
    }
}
