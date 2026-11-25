using Xunit.Abstractions;

namespace QuizAppLogic.Tests;

public class QizTest
{
    private readonly ITestOutputHelper _output;

    public QizTest(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Fact]
    public void TestQuiz()
    {
        
        
        Nutzer nutzer = new Nutzer(1, "test-nutzer");

        Quizstarten quizstarten = new Quizstarten();
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
      
         for (int i = 0; i < quizstarten.Themen.Count ; i++) {
            _output.WriteLine((i + 1 ) +  ". " + quizstarten.Themen[i].Themaname);
        }

        Thema gewaeltesThema = quizstarten.Themen[4];

        Ergebnis ergebnis = new Ergebnis(0,0);
        DateTime datum = DateTime.Now;

        Quiz quiz = new Quiz(gewaeltesThema, nutzer, ergebnis, datum);

        do
        {
            Frage aktuellefrage = quiz.naechsteFrage();
            if (aktuellefrage == null)
            {
                break;
            }
            _output.WriteLine(aktuellefrage.content);
        } while (true);
        
    }
}
