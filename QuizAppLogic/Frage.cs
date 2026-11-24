using System.Net.Mime;

namespace QuizAppLogic
{
    public class Frage
    {
        public List<Antwort> Antwortliste {get; private set;} = new List<Antwort>();
        public string? content {get; private set;}

        public Frage(List<Antwort> answerlist, string inhalt)
        {
            Antwortliste = answerlist;
            content = inhalt;
        }
    }
}