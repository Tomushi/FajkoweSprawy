// See https:/// Coś tu trzeba wymyślić ...

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
            Console.WriteLine("Wbierz moc tytoniu");
            string moc = Console.ReadLine();
    }
}
