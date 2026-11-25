namespace QuizAppLogic
{
    public class Thema
    {
        public List<Frage> Fragenliste {get; set;}
        public string? Themaname {get; private set;}

        public Thema(string namethema, List<Frage> fragen)
        {
            Themaname = namethema;
            Fragenliste = fragen;
        }
    }
}