// Wir erstellen eine Zufällige Zahl
Random zufall = new Random();
//Wir schreiben unsere Zeichen auf
string gross = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string klein = "abcdefghijklmnopqrstuvwxyz";
string zahlen = "123456789";
string sonderzeichen = "?!#@";
// string aus alle zahlen
string alleZahlen = gross + klein + zahlen + sonderzeichen; 
// wir erstellen jetz einen leeren Code
string code = "";
//wir erstellen eine for- Schleife(Sie soll 8 mal durchgeführt werden, da wir schon 4 zeichen haben)
// dann können wir für jedem Durchlauf ein neuse Zeichen hinzufügen
// zuerst garantieren wir das mind. eins von jeder vor kommt(vor der "for" schleife)
code = code + gross[zufall.Next(gross.Length)];
code = code + klein[zufall.Next(klein.Length)];
code = code + zahlen[zufall.Next(zahlen.Length)];
code = code + sonderzeichen[zufall.Next(sonderzeichen.Length)];
for (int i = 0; i < 8; i++) 
{
    int position = zufall.Next(alleZahlen.Length);
    code = code + alleZahlen[position];
}
Console.WriteLine(code);