using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace QuizAppLogic
{
    public class Quiz
    {
        public Thema? thema {get; private set;}
        public Nutzer? nutzer {get; private set;} 
        public Ergebnis? ergebnis {get; private set;} 
        public DateTime Datum {get; private set;}
        private int fragenindex = 1;

        public Quiz(Thema topic, Nutzer user, Ergebnis result, DateTime date)
        {
            thema = topic;
            nutzer = user;
            ergebnis = result;
            Datum = date;
        }

        public Frage naechsteFrage()
        {
            if(fragenindex > thema.Fragenliste.Count) 
            {
                return null;
            }
            
            Frage aktuellefrage = thema.Fragenliste[fragenindex - 1];
            fragenindex ++;
            return aktuellefrage;
        }
    }
}