namespace QuizAppLogic
{
    public class Ergebnis
    {
        public int AnzahlDerRichtigenAntworten {get; set;} = 0;
        public int AnzahlDerFalschenAntworten {get; set;} = 0;

        public Ergebnis(int richtiganzahl, int falschanzahl)
        {
            AnzahlDerFalschenAntworten = richtiganzahl;
            AnzahlDerFalschenAntworten = falschanzahl;
        }

    }
}