namespace QuizAppLogic.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Nutzer Philipp = new Nutzer();
        Thema autos = new Thema();
        Ergebnis ergebnistest = new Ergebnis();
        DateTime datum = new DateTime(2026, 1, 1, 14, 30, 0);
        Quiz testquiz = new Quiz(autos, Philipp, ergebnistest, datum);

        Frage Frage1 = new Frage(new List<Antwort>() ,"Können Autos Fahren?");
        Antwort antwort1zuFrage1 = new Antwort(true, false, "ja");
        Antwort antwort2zuFrage1 = new Antwort(false, true, "nein");
        Antwort antwort3zuFrage1 = new Antwort(false, true, "vielleicht");

    }
}
