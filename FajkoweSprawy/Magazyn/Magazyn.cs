using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajkoweSprawy.Magazyn
{
    internal class Magazyn
    {
        internal List<Tyton> tytonie = new List<Tyton>();

        internal void DodajTyton(Tyton nowyTyton)
        {
            tytonie.Add(nowyTyton);
            Console.WriteLine($"Dodano tyton: {nowyTyton.Nazwa}");
        }

        internal void WyswietlTytonie()
        {
            if (tytonie.Count ==0)
            {
                Console.WriteLine("Najpierw musisz miec wpisany jakis tyton aby go wyswietlic");
                    return;
            }

            foreach (Tyton tyton in tytonie)
            {
                tyton.WyswietlInformacjeOTytoniu();
            }
        }
    }
}
