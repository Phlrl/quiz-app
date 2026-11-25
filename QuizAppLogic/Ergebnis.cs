namespace QuizAppLogic
{
    public class Ergebnis
    {
        public int AnzahlDerRichtigenAntworten {get; private set;} = 0;
        public int AnzahlDerFalschenAntworten {get; private set;} = 0;

        public Ergebnis(int richtiganzahl, int falschanzahl)
        {
            AnzahlDerFalschenAntworten = richtiganzahl;
            AnzahlDerFalschenAntworten = falschanzahl;
        }

    }
}