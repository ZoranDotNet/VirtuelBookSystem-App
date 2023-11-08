using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelBookSystem
{
    internal class Ebok : Bok
    {
        public string filStorlek { get; set; }
        public string downloadUrl { get; set; }

        public override void SkrivutInfo()
        {
            base.SkrivUtInfo();
            Console.WriteLine($"Filstorlek: {filStorlek} \nDownloadUrl: {downloadUrl}");
        }
    }
}
