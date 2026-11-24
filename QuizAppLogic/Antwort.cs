namespace QuizAppLogic
{
    public class Antwort
    {
        public bool rightindicator {get ; private set;}
        public bool wrongindicator {get ; private set;}
        public string? contentanswer {get; private set;}

        public Antwort(bool richtig, bool falsch, string inhaltantwort)
        {
            rightindicator = richtig;
            wrongindicator = falsch;
            contentanswer = inhaltantwort;
        }
    }
}