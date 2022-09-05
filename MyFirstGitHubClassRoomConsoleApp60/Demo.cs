using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {

        public Demo(string navn, string telefon, int alder)
        {
            Navn = navn;
            Telefon = telefon;
            Alder = alder;
        }

        public string Navn { get; set; }

        public string Telefon { get; set; }

        public int Alder { get; set; } 
    }
}
