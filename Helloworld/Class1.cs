using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Helloworld
{

    public class Message // la classe gere la gestion de l'affichage

    {
        /* Création d'une instance avec date fixe pour tester fonctionnement de la fonction GetHelloMessage 
         * Pour retester remplacer DateTime.Now par test 
         * DateTime test = new DateTime(2018, 06, 15, 17, 0, 0);
         */
        DateTime date = DateTime.Now;//DateTime(2018, 06, 15, 17, 0, 0);
        private int morning;
        private int afternoon;
        private int evening;

        public Message(int morning = 9, int afternoon = 13, int evening = 18)

        {
            this.morning = morning;
            this.afternoon = afternoon;
            this.evening = evening;
        }

        public string GetHelloMessage()
        {
            if (date.DayOfWeek == DayOfWeek.Saturday
                || date.DayOfWeek == DayOfWeek.Sunday
                || date.DayOfWeek == DayOfWeek.Friday && date.Hour > evening // C'est le vendredi soir
                || date.DayOfWeek == DayOfWeek.Monday && date.Hour < morning) // C'est le lundi matin
            {
                // C'est le weekend
                return "Bon week-end ";
            }

            // C'est la semaine
            else if (date.Hour >= morning && date.Hour < afternoon)
            {
                // C'est le matin
                return "Bonjour "
                 ;
            }
            else if (date.Hour >= afternoon && date.Hour < evening)
            {
                // C'est l'après midi
                return "Bon après-midi ";
            }
            else
            {
                // C'est le soir
                return "Bonsoir "; ;
            }
        }
    }
}