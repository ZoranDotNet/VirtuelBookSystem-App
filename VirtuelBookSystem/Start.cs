using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelBookSystem
{
    internal class Start
    {
        internal void StartProgram()
        {
            List<Media> mediaList = new List<Media>();

            foreach (var item in mediaList)
            {
                item.VisaInfo();
            }
        }
    }
}
