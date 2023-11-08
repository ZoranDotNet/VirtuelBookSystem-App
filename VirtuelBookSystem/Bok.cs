using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelBookSystem
{
    internal class Bok : Media
    {
        public string Titel { get; set; }
        public string Författare { get; set; }

        public string ISBN { get; set; }

      
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

    }
}
