// See https://aka.ms/new-console-template for more information

while (true)
{

    Console.WriteLine("Wähle Schere, Stein oder Papier");

    // Schere = 1
    // Stein = 2
    // Papier = 3

    var spielerInput = Console.ReadLine();

    var inputValue = 1;

    var randomGenerator = new Random();

    var zahl = randomGenerator.Next(1, 3);

    if (spielerInput == "Stein")
    {
        inputValue = 2;
    }

    if (spielerInput == "Papier")
    {
        inputValue = 3;
    }

    switch (zahl)
    {
        case 1: Console.WriteLine("Computer hat Schere gewählt");
            break;
        case 2: Console.WriteLine("Computer hat Stein gewählt");
            break;
        case 3: Console.WriteLine("Computer hat Papier gewählt");
            break;
    }

    var ergebnis = inputValue - zahl;

    switch (ergebnis)
    {
        case 0:
            Console.WriteLine("Unentschieden");
            break;
        case 1:
            Console.WriteLine("Ich hab gewonnen");
            break;
        case 2:
            Console.WriteLine("Computer hat gewonnen");
            break;
        case -1:
            Console.WriteLine("Computer hat gewonnen");
            break;
        case -2:
            Console.WriteLine("Ich hab gewonnen");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Drücke Enter um nochmal zu spielen");
    Console.ReadLine();

    Console.Clear();
}
