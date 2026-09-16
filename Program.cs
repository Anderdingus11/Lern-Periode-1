using System.ComponentModel.Design;

Console.WriteLine("Willkommen zum Abenteuer-Spiel!");
bool sucheSchatz = true;
string antwort = "";

Console.WriteLine("Möchtest du ein Schatz suchen? (ja/nein):");
antwort = Console.ReadLine();
// Zuerst machen wir das sich das bool nach der eingabe von ja oder nein verändert
if (antwort == "ja")
{
    sucheSchatz = true;
}
else
{
    sucheSchatz = false;
}
// Jetzt machen wir die Kopfgesteuerte schleife
    while (sucheSchatz == true)
{
    Console.WriteLine("Du suchst");
    Console.WriteLine("Möchtest du weitersuchen? (ja/nein):");
    antwort = Console.ReadLine();
    // hier muss man die if schleife nochmals machen, da sie im Kopfgesteuerte Schleife ist, d.h die andere zählt nicht mehr
    if (antwort == "ja")
    {
        sucheSchatz = true;
    }
    else
    {
        sucheSchatz = false;
    }
}
Console.WriteLine("Schatzsuche beendet.");