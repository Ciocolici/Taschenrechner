namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstelle einen einfachen Taschenrechner.
            //Der User soll nacheinander zwei Zahlen und auch ein Zeichen für die Rechenart eingaben können.
            //(+ - * /)
            //Anschließend wir die Berechnung durchgeführt und das Ergebnis ausgegeben.
            //Nach Ausgabe des Ergebnis frage den User, ob er eine weitere Berechnung durchführen möchte, oder ob er das Programm verlassen will.

            bool nochmal = false;

            do
            {
                Console.WriteLine("Welche Zahl willst rechnen?");
                double zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wähl ein Rechenart: + - * /");
                string rechenArt = Console.ReadLine();

                Console.WriteLine("Mit welche Zahl?");
                double zahl2 = Convert.ToDouble(Console.ReadLine());
                if (rechenArt == "-")
                {
                    double summe = zahl1 - zahl2;
                    Console.WriteLine($"Das Ergebnis ist = {summe}.\nWillst du weiter berechnen? Schreib ja. Jedes andere Antwort wird das Programm schlissen.");
                    string antwort = Console.ReadLine().ToLower();
                    if (antwort == "ja")
                    {
                    }
                    else
                    {
                        nochmal = true;
                        break;
                    }
                }
                else if (rechenArt == "+")
                {
                    double summe = zahl1 + zahl2;
                    Console.WriteLine($"Das Ergebnis ist = {summe}.\nWillst du weiter berechnen? Schreib ja. Jedes andere Antwort wird das Programm schlissen.");
                    string antwort = Console.ReadLine().ToLower();
                    if (antwort == "ja")
                    {
                    }
                    else
                    {
                        nochmal = true;
                        break;
                    }
                }
                else if (rechenArt == "*")
                {
                    double summe = zahl1 * zahl2;
                    Console.WriteLine($"Das Ergebnis ist = {summe}.\nWillst du weiter berechnen? Schreib ja. Jedes andere Antwort wird das Programm schlissen.");
                    string antwort = Console.ReadLine().ToLower();
                    if (antwort == "ja")
                    {
                    }
                    else
                    {
                        nochmal = true;
                        break;
                    }
                }
                else if (rechenArt == "/")
                {
                    double summe = zahl1 / zahl2;
                    Console.WriteLine($"Das Ergebnis ist = {summe}.\nWillst du weiter berechnen? Schreib ja. Jedes andere Antwort wird das Programm schlissen.");
                    string antwort = Console.ReadLine().ToLower();
                    if (antwort == "ja")
                    {
                    }
                    else
                    {
                        nochmal = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Falsche Eingabe. Sollst + - * / verwenden, kein {rechenArt}.. Willst du nochmal versuchen? Schreib ja. Jedes andere Antwort wird das Programm schlissen.");
                    string antwort = Console.ReadLine().ToLower();
                    if (antwort == "ja")
                    {
                    }
                    else
                    {
                        nochmal = true;
                    }
                }
            } while (nochmal == false);
        }
    }
}