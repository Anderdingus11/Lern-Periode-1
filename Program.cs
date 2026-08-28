Random Würfel = new Random();
int Zahl;

Zahl = Würfel.Next(1, 100);
Console.WriteLine($"Ich habe eine zufällige Zahl in meinen Kopf und sie ist {Zahl}!");
string Guess;
Guess = Console.ReadLine();