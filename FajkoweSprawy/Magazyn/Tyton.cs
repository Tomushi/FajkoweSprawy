using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajkoweSprawy.Magazyn
{
    internal class Tyton
    {
        internal string Nazwa { get; set; }
        internal string Moc { get; set; }

        internal Tyton(string nazwa, string moc)
        { Nazwa = nazwa; Moc = moc; }

        public void WyswietlInformacjeOTytoniu()
        {
            Console.WriteLine($"Nazwa: {nazwa}, Moc: {moc});
        }
    }
}
