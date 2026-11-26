using System.Diagnostics.Contracts;
using QuizAppLogic;

namespace QuizAppDB;

public class QuizAppDB
{
    private void CreateConnetion()
    {
        
    }

    public List<Thema>GetThemen()
    {
        return new List<Thema>();
        //Thema wird geholt sammt fragen und antworten
    }

    public void SaveErgebnis(Ergebnis ergebnis, Nutzer nutzer)
    {
        //speicher ergebnis welche in beziehung durch eine fk zu dem jewweiligen nutzer steht
    }

    public Nutzer GetNutzer(string nutzername)
    {
        return null;
    }

    public void SaveNutzer(string nutzername)
    {
        //speicher ntuzername in tabelle nutzer
    }
}
