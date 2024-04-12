using FajkoweSprawy.Magazyn;
using System.Diagnostics.Metrics;

Magazyn maga = new Magazyn();

bool czyKontynuowac = true;

Console.WriteLine("Tytoń i jego rodzaje");

while (czyKontynuowac)
{
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Dodaj tyton");
    Console.WriteLine("2. Wyswietl tytonie");
    Console.WriteLine("3. Zamknij program");
    Console.WriteLine("Wpisz numer operacji i potwierdz klawisze Enter");

    string operacja = Console.ReadLine();

    switch (operacja)
    {
        case "1":
            Console.WriteLine("Wpisz nazwe i wcisnij Enter");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Moc tytoniu");
            Console.WriteLine("1. Lekki");
            Console.WriteLine("2. Sredni");
            Console.WriteLine("3. Mocny");
            string moc = Console.ReadLine();
            break;
        case "2":
            maga.WyswietlTytonie();
            break;
        case "3":
            czyKontynuowac = false;
            Console.WriteLine("Zamykam program");
            break;

        default:
            Console.WriteLine("Nie ma takiej operacji, sprobuj ponownie");
            break;

    }
}
