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

        public void GetHelloMessage()
        {
            do
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    // C'est le weekend
                    AfficherBonWeekEnd();
                }
                // C'est le vendredi soir

                else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > evening)
                {
                    // C'est le weekend
                    AfficherBonWeekEnd();
                }

                else

                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < morning)
                    {
                        //C'est le lundi matin
                        AfficherBonWeekEnd();
                    }

                    // C'est la semaine
                    else if (DateTime.Now.Hour >= morning && DateTime.Now.Hour < afternoon)
                    {
                        // C'est le matin
                        AfficherBonjour();
                    }
                    else if (DateTime.Now.Hour >= afternoon && DateTime.Now.Hour < evening)
                    {
                        // C'est l'après midi
                        AfficherBonApresmidi();
                    }
                    else if (DateTime.Now.Hour >= evening)
                    {
                        // C'est le soir
                        AfficherBonsoir();
                    }
                }
                ReadKey();
                // Console.ReadKey(); si on n'indique pas using static System.Console; en haut de page
            } while (ReadLine() != "exit");
        }

        public void AfficherBonWeekEnd()
        {
            WriteLine("Bon week-end " + Environment.UserName);
        }

        public void AfficherBonjour()
        {
            WriteLine("Bonjour " + Environment.UserName);
        }

        public void AfficherBonApresmidi()
        {
            WriteLine("Bon après-midi " + Environment.UserName);
        }

        public void AfficherBonsoir()
        {
            WriteLine("Bonsoir " + Environment.UserName);
            // Console.WriteLine("Bonsoir " + Environment.UserName);
        }
    }
}
