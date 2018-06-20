using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Helloworld
{

    public class Message

    {
        /* Création d'une instance avec date fixe pour tester fonctionnement de la fonction GetHelloMessage 
         * Pour retester remplacer DateTime.Now par test 
         * DateTime test = new DateTime(2018, 06, 15, 17, 0, 0);
         */

        private int morning;
        private int afternoon;
        private int evening;

        public Message()

        {
            morning = 9;
            afternoon = 13;
            evening = 18;
        }

        public string GetHelloMessage()
        {
            
            
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday
                    || DateTime.Now.DayOfWeek == DayOfWeek.Sunday
                    || DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > evening // C'est le vendredi soir
                    || DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < morning) //C'est le lundi matin
                {
                    // C'est le weekend
                    return "Bon week-end ";
                }

                // C'est la semaine
                else if (DateTime.Now.Hour >= morning && DateTime.Now.Hour < afternoon)
                {
                    // C'est le matin
                    return "Bonjour "
                     ;
                }
                else if (DateTime.Now.Hour >= afternoon && DateTime.Now.Hour < evening)
                {
                    // C'est l'après midi
                    return "Bon après-midi ";
                }
                else
                {
                    // C'est le soir
                    return "Bonsoir "; ;
                }

                ReadKey();
                // Console.ReadKey(); si on n'indique pas using static System.Console; en haut de page

            
        }

    }
}