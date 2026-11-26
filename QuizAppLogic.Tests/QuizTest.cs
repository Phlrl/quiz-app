using Xunit.Abstractions;

namespace QuizAppLogic.Tests;

public class QuizTest
{
    private readonly ITestOutputHelper _output;

    public QuizTest(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Fact]
    public void TestQuiz()
    {
        
        
        Nutzer nutzer = new Nutzer(1, "test-nutzer");

        QuizApp quizstarten = new QuizApp();
        List<Thema> Themen = new List<Thema>();
        Themen.Add(new Thema("Allgemeinwissen", new List<Frage>()));
        Themen.Add(new Thema("Geschichte", new List<Frage>()));
        Themen.Add(new Thema("Geografie", new List<Frage>()));
        Themen.Add(new Thema("Naturwissenschaften", new List<Frage>()));
        Themen.Add(new Thema("Mathematik", new List<Frage>
        {
            new Frage(new List<Antwort>
            {
                new Antwort(false, true, "54"),
                new Antwort(true, false, "56"),
                new Antwort(false, true, "64"),
                new Antwort(false, true, "49")
            }, "Wie viel ist 7 mal 8?"),
            new Frage(new List<Antwort>
            {
                new Antwort(false, true, "8"),
                new Antwort(true, false, "9"),
                new Antwort(false, true, "10"),
                new Antwort(false, true, "7")
            }, "Was ist die Quadratwurzel von 81?"),
            new Frage(new List<Antwort>
            {
                new Antwort(false, true, "25 %"),
                new Antwort(false, true, "50 %"),
                new Antwort(true, false, "75 %"),
                new Antwort(false, true, "80 %")
            }, "Wie viel Prozent sind drei Viertel?")
        }));
        Themen.Add(new Thema("Literatur", new List<Frage>()));
        Themen.Add(new Thema("Musik", new List<Frage>()));
        Themen.Add(new Thema("Sport", new List<Frage>()));
        Themen.Add(new Thema("Film und Fernsehen", new List<Frage>()));
        Themen.Add(new Thema("Informatik", new List<Frage>()));

        quizstarten.Themen = Themen;
      
         for (int i = 0; i < quizstarten.Themen.Count ; i++) { //themen werden aus liste genommen
            _output.WriteLine((i + 1 ) +  ". " + quizstarten.Themen[i].Themaname); //themen werden displayed
        }

        Thema gewaeltesThema = quizstarten.Themen[4]; //thema 5 wurde gewählt

        Ergebnis ergebnis = new Ergebnis(0,0);
        DateTime datum = DateTime.Now;

        Quiz quiz = new Quiz(gewaeltesThema, nutzer, ergebnis, datum);

        do
        {
            Frage aktuellefrage = quiz.naechsteFrage(); //wenns noch fragen gibt gibt die methode die frage zurück wenn es keine mehr gibt wird null zurückgegeben und der do loop gebreakt
            if (aktuellefrage == null) //wenn nicht null wird das if statement geskippt
            {
                break;
            }
            
            _output.WriteLine(aktuellefrage.content);
            _output.WriteLine("Antwortmöglichkeiten:");
            
            for (int i = 0; i < aktuellefrage.Antwortliste.Count; i++) //antworten werden aus liste genommen solange bis der index größer ist als der count 
            {
                _output.WriteLine((i + 1) + ". " + aktuellefrage.Antwortliste[i].contentanswer); // antworten werden displayed
            }
            
            // Nutzer wählt immer antowrt 2
            Antwort gewaehlteAntwort = aktuellefrage.Antwortliste[1];
            _output.WriteLine("Gewählte Antwort: " + gewaehlteAntwort.contentanswer
                + " ist " + gewaehlteAntwort.rightindicator);
            
            if (gewaehlteAntwort.rightindicator) // wenn die antowrt richtig ist wird die anzahl der richtigen antowrten und 1 erhöht wenn nicht dann der der falschen antowrten 
            {
                quiz.ergebnis.AnzahlDerRichtigenAntworten++;
            }
            else
            {
                quiz.ergebnis.AnzahlDerFalschenAntworten++;
            }
            
        } while (true); //wird gebrochen wenn keine fragen mehr vorhanden sind (aktuelle fragen == null)
        
        _output.WriteLine("Ergebnis: " + quiz.ergebnis.AnzahlDerRichtigenAntworten + " richtige Antworten, "
            + quiz.ergebnis.AnzahlDerFalschenAntworten + " falsche Antworten."); //ergebnis wird displayed
    }
}