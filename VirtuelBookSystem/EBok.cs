using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelBookSystem
{
    internal class Ebok : Bok
    {
        public Ebok(string titel, string författare, string iSBN) :base(titel,författare,iSBN)
        {
            
        }
        public string FilStorlek { get; set; }
        public string DownloadUrl { get; set; }

        public override void SkrivUtInfo()
        {
            base.SkrivUtInfo();
            Console.WriteLine($"Filstorlek: {FilStorlek} \nDownloadUrl: {DownloadUrl}");
        }
    }
}
