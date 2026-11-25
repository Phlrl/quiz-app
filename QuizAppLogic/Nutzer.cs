using System.Runtime.InteropServices.Marshalling;
using System.Xml;

namespace QuizAppLogic
{
    public class Nutzer
    {
        public int NutzerID {get; private set;}
        public string NutzerName {get; private set;}
        public List<Quiz> Quizze {get; private set;}

        public Nutzer(int nutzerid, string nutzername)
        {
            NutzerID = nutzerid;
            NutzerName = nutzername;
            Quizze = new List<Quiz>();
        }
    }
}